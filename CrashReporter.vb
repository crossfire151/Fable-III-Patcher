Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web.UI.Design.WebControls

Public Class CrashReporter
    Public Function PHP(ByVal url As String, ByVal method As String, ByVal data As String)
        Try

            Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(url)
            request.Method = method
            Dim postData = data
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()
            Return (responseFromServer)
        Catch ex As Exception
            Dim error1 As String = ErrorToString()
            If error1 = "Invalid URI: The format of the URI could not be determined." Then
                MsgBox("ERROR! Must have HTTP:// before the URL.")
            Else
                MsgBox(error1)
            End If
            Return ("ERROR")
        End Try
    End Function


    Public Function UploadCrashWithFile(ByVal url As String, ByVal name As String, ByVal email As String, ByVal identifier As String) As String
        Try
            Dim filePath As String = Path.Combine(My.Application.Info.DirectoryPath, "applicationCrash.log")
            Dim boundary As String = "---------------------------" & DateTime.Now.Ticks.ToString("x")
            Dim boundaryBytes As Byte() = Encoding.ASCII.GetBytes(vbCrLf & "--" & boundary & vbCrLf)
            Dim endBoundaryBytes As Byte() = Encoding.ASCII.GetBytes(vbCrLf & "--" & boundary & "--" & vbCrLf)

            Dim request = DirectCast(WebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "multipart/form-data; boundary=" & boundary
            request.KeepAlive = True
            request.Credentials = CredentialCache.DefaultCredentials

            Using requestStream As Stream = request.GetRequestStream()
                ' Write simple form fields
                Dim formTemplate As String = "Content-Disposition: form-data; name=""{0}""" & vbCrLf & vbCrLf & "{1}"
                Dim fields = New Dictionary(Of String, String) From {
                    {"name", name},
                    {"email", email},
                    {"identifier", identifier}
                }

                For Each kvp In fields
                    requestStream.Write(boundaryBytes, 0, boundaryBytes.Length)
                    Dim formItem As String = String.Format(formTemplate, kvp.Key, kvp.Value)
                    Dim formItemBytes As Byte() = Encoding.UTF8.GetBytes(formItem)
                    requestStream.Write(formItemBytes, 0, formItemBytes.Length)
                Next

                ' Attach file if it exists
                If File.Exists(filePath) Then
                    requestStream.Write(boundaryBytes, 0, boundaryBytes.Length)
                    Dim header As String = String.Format("Content-Disposition: form-data; name=""file""; filename=""{0}""" & vbCrLf & "Content-Type: application/octet-stream" & vbCrLf & vbCrLf, Path.GetFileName(filePath))
                    Dim headerBytes As Byte() = Encoding.UTF8.GetBytes(header)
                    requestStream.Write(headerBytes, 0, headerBytes.Length)

                    Using fileStream As FileStream = File.OpenRead(filePath)
                        fileStream.CopyTo(requestStream)
                    End Using
                Else
                    ' If file not found, you can either continue without file or return an error.
                    ' Here we continue and let the server decide how to handle missing file.
                End If

                ' Finish multipart
                requestStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length)
            End Using

            Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                Using responseStream As Stream = response.GetResponseStream()
                    Using reader As New StreamReader(responseStream)
                        Return reader.ReadToEnd()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Return "ERROR: " & ex.ToString()
        End Try
    End Function
    Private Sub CrashReporter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appid.Text = Guid.NewGuid.ToString()
    End Sub

    Private Sub LogInButton2_Click(sender As Object, e As EventArgs) Handles LogInButton2.Click
        Clipboard.SetText(appid.Text)
        MsgBox("Referance Copied to Clipboard, after you completed the crashlog upload you can give us this in a Support ticket on the Support forum or our discord.", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub LogInButtonWithProgress1_Click(sender As Object, e As EventArgs) Handles SendCrash.Click
        sender.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SendCrash.Value += 1
        Dim url As String = "https://support.crossfire151.co.uk/app/post/"
        If SendCrash.Value = 100 Then
            Timer1.Stop()
            Dim response As String = UploadCrashWithFile(url, NameText.Text, EmailText.Text, appid.Text)
            ' Show server response or handle it as required
            MsgBox(response, MsgBoxStyle.Information, "Upload Result")
            SendCrash.Value = 0
            SendCrash.Enabled = True
            If response.Contains("Whoops, you cannot upload this again. Please start a new session.") Then
                Close()
            ElseIf response.Contains("Thank you for uploading your Crash Log. We will contact you with an update soon.") Then
                Close()
            End If
        End If
    End Sub
End Class