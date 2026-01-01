Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Try
                ' Log file in application startup directory
                Dim logFile As String = Path.Combine(My.Application.Info.DirectoryPath, "applicationCrash.log")
                Const listenerName As String = "AppFileLog"

                ' Add a TextWriterTraceListener that writes to the chosen file if not already present
                If Trace.Listeners(listenerName) Is Nothing Then
                    Dim fs As New FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.Read)
                    Dim tw As New TextWriterTraceListener(fs, listenerName)
                    Trace.Listeners.Add(tw)
                End If

                ' Write the exception using My.Application.Log (will go to Trace listeners)
                My.Application.Log.WriteException(e.Exception, TraceEventType.Critical,
                                                  "Application shut down at " & My.Computer.Clock.GmtTime.ToString())

                ' Ensure data is written immediately
                Trace.Flush()
            Catch logEx As Exception
                ' Fallback: attempt to append to a simple fallback file if the main logging fails
                Try
                    Dim fallback As String = Path.Combine(My.Application.Info.DirectoryPath, "application_fallback.log")
                    File.AppendAllText(fallback, DateTime.UtcNow.ToString("o") & " - Logging failed: " & logEx.ToString() & Environment.NewLine)
                Catch
                    ' Swallow any exceptions here to avoid recursive failures
                End Try
            End Try

            ' Let the application exit after an unhandled exception
            e.ExitApplication = True
        End Sub
    End Class
End Namespace
