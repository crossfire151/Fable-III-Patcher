﻿Imports System.Data.Common
Imports System.Net
Public Class DLC
#Region "CloudServer"
    Dim CloudServer As String = "https://cloud.crossfire151.xyz/download/f_files_downloads_33jhuf-_-ih83h2!uhgr7u9g3b/"
    Dim InquisitorPack As String = CloudServer & "4d53090a0ecf000e_INQUISITOR.cab"
    Dim TraitorsKeepPack As String = CloudServer & "4d53090a0ecf0010_TRAITORS.cab"
    Dim UnderstonePack As String = CloudServer & "4d53090a0ecf0000_UNDERSTONE.cab"

    Private Sub SaveLocationButton_Click(sender As Object, e As EventArgs) Handles SaveLocationButton.Click
        FolderBrowserDialog1.ShowDialog()
        If Not FolderBrowserDialog1.SelectedPath = "" Then
            SaveLocationButton.Tag = FolderBrowserDialog1.SelectedPath
            SaveLocationButton.Enabled = False
            My.Computer.FileSystem.CreateDirectory(SaveLocationButton.Tag & "\DLC")
            Step3.Enabled = True
            DownloadedFiles.Navigate(Application.StartupPath & "\Downloads")
            Fable3DLCLocation.Navigate(SaveLocationButton.Tag & "\DLC")
        End If
    End Sub

    Private Sub LogInButton1_Click(sender As Object, e As EventArgs) Handles LogInButton1.Click
        Step3.Enabled = False
        Step4.Enabled = True
    End Sub

    Private Sub DoneButton_Click(sender As Object, e As EventArgs) Handles DoneButton.Click
        If My.Settings.Lang = "English" Then
            If DoneButton.Text = "Done" Then
                If Clipboard.GetText = "" Then
                    MsgBox("It appears you have not copied anything. This information is required in order to enable usage of the DLC.", MsgBoxStyle.Critical, "Missing information")
                Else
                    MsgBox("Great, here's what we found in your clipboard: " & Clipboard.GetText & ". Please click Confirm if this is correct, if not; please try again.", MsgBoxStyle.Information, "We found this")
                    DoneButton.Text = "Confirm"
                End If
            ElseIf DoneButton.Text = "Confirm" Then
                LicenceSetupButton.Enabled = False
                RenameLicenceButton.Enabled = True
                LicencePanel.Visible = False
            End If
        ElseIf My.Settings.Lang = "Polish" Then
            If DoneButton.Text = "Zrobione" Then
                If Clipboard.GetText = "" Then
                    MsgBox("Zdaje się, że nic nie skopiowałeś. Te ID jest wymagane, by możliwe było korzystanie z DLC.", MsgBoxStyle.Critical, "Brakujące informacje")
                Else
                    MsgBox("Świetnie, znaleźliśmy to w schowku: " & Clipboard.GetText & ". Wciśnij 'Potwierdź' jeśli się zgadza, jeśli nie; spróbuj ponownie.", MsgBoxStyle.Information, "To znaleźliśmy")
                    DoneButton.Text = "Potwierdź"
                End If
            ElseIf DoneButton.Text = "Potwierdź" Then
                LicenceSetupButton.Enabled = False
                RenameLicenceButton.Enabled = True
                LicencePanel.Visible = False
            End If
        End If
    End Sub

    Private Sub DoneButton_TextChanged(sender As Object, e As EventArgs) Handles DoneButton.TextChanged
        If My.Settings.Lang = "English" Then
            If DoneButton.Text = "Confirm" Then
                RetryButton.Visible = True
            ElseIf DoneButton.Text = "Done" Then
                If RetryButton.Visible = True Then
                    RetryButton.Visible = False
                End If
            End If
        ElseIf My.Settings.Lang = "Polish" Then
            If DoneButton.Text = "Potwierdź" Then
                RetryButton.Visible = True
            ElseIf DoneButton.Text = "Zrobione" Then
                If RetryButton.Visible = True Then
                    RetryButton.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub xuidPanelClose_Click(sender As Object, e As EventArgs) Handles xuidPanelClose.Click
        LicencePanel.Visible = False
    End Sub

    Private Sub LogInButton2_Click(sender As Object, e As EventArgs) Handles LicenceSetupButton.Click
        LicencePanel.Visible = True
        LicencePanel.Size = New Point(918, 426)
        LicencePanel.Location = New Point(227, 58)
        LicencePanel.BringToFront()
    End Sub

    Private Sub RenameLicenceButton_Click(sender As Object, e As EventArgs) Handles RenameLicenceButton.Click
        Dim FileLoc As String = Application.StartupPath & "\Downloads\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\0009XXXXXXXXXXX.LIC"
        Dim ToRename As String = Clipboard.GetText & ".LIC"
        My.Computer.FileSystem.RenameFile(FileLoc, ToRename)
        RenameLicenceButton.Enabled = False
    End Sub

    Private Sub OpenStep5Panel_Tick(sender As Object, e As EventArgs) Handles OpenStep5Panel.Tick
        Step5Progress.Increment(1)
        Step5Panel.Size = New Point(1373, Step5Progress.Value)
        If Step5Progress.Value = Step5Progress.Maximum Then
            OpenStep5Panel.Stop()
            LicenceCopyFromLocation.Navigate(Application.StartupPath & "\Downloads\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\")
            LicenceCopyToLocation.Navigate("C:\Users\%USERNAME%\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\")
        End If
    End Sub

    Private Sub LicenceAllocationClose_Click(sender As Object, e As EventArgs) Handles LicenceAllocationClose.Click
        LicenceAllocationClose.Enabled = False
        CloseStep5Panel.Start()
    End Sub

    Private Sub CloseStep5Panel_Tick(sender As Object, e As EventArgs) Handles CloseStep5Panel.Tick
        Step5Progress.Value -= 1
        Step5Panel.Size = New Point(1373, Step5Progress.Value)
        If Step5Progress.Value = Step5Progress.Minimum Then
            CloseStep5Panel.Start()
            If LicenceAllocationClose.Enabled = True Then
                My.Settings.PatchComplete = "1"
                My.Settings.Save()
                Form1.Close()
                If My.Settings.Lang = "English" Then
                    Launcher.SmartButton.Text = "Play"
                ElseIf My.Settings.Lang = "Polish" Then
                    Launcher.SmartButton.Text = "Graj"
                End If
                Launcher.BringToFront()
                Close()
                End If
            End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        LicDoneButton.Visible = True
    End Sub

    Private Sub LicDoneButton_Click(sender As Object, e As EventArgs) Handles LicDoneButton.Click
        CloseStep5Panel.Start()
    End Sub

    Private Sub LogInButton2_Click_1(sender As Object, e As EventArgs) Handles LogInButton2.Click
        LogInButton2.Enabled = False
        Phase1()
    End Sub

    Public Sub Phase1()
        If Not My.Computer.FileSystem.DirectoryExists("C:\Users\%USERNAME%\AppData\Local\Microsoft\") Then
            My.Computer.FileSystem.CreateDirectory("C:\Users\%USERNAME%\AppData\Local\Microsoft\")
        End If
        Phase2()
    End Sub

    Public Sub Phase2()
        If Not My.Computer.FileSystem.DirectoryExists("C:\Users\%USERNAME%\AppData\Local\Microsoft\Xlive\") Then
            My.Computer.FileSystem.CreateDirectory("C:\Users\%USERNAME%\AppData\Local\Microsoft\Xlive\")
        End If
        Phase3()
    End Sub
    Public Sub Phase3()
        If Not My.Computer.FileSystem.DirectoryExists("C:\Users\%USERNAME%\AppData\Local\Microsoft\Xlive\DLC\") Then
            My.Computer.FileSystem.CreateDirectory("C:\Users\%USERNAME%\AppData\Local\Microsoft\Xlive\DLC\")
        End If
        Phase4()
    End Sub
    Public Sub Phase4()
        If Not My.Computer.FileSystem.DirectoryExists("C:\Users\%USERNAME%\AppData\Local\Microsoft\Xlive\DLC\4D53090A\") Then
            My.Computer.FileSystem.CreateDirectory("C:\Users\%USERNAME%\AppData\Local\Microsoft\Xlive\DLC\4D53090A\")
        End If
        Phase5()
    End Sub
    Public Sub Phase5()
        If Not My.Computer.FileSystem.DirectoryExists("C:\Users\%USERNAME%\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\") Then
            My.Computer.FileSystem.CreateDirectory("C:\Users\%USERNAME%\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\")
        End If
        Phase6()
    End Sub

    Public Sub Phase6()
        If Not My.Computer.FileSystem.DirectoryExists("C:\Users\%USERNAME%\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\") Then
            My.Computer.FileSystem.CreateDirectory("C:\Users\%USERNAME%\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\")
        End If
        Allocation()
    End Sub

    Public Sub Allocation()
        OpenStep5Panel.Start()
    End Sub

    Private Sub DLC1_Click(sender As Object, e As EventArgs) Handles DLC1.Click
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Downloads\" & DLC1.Tag) Then
            Downloader.Show()
            Downloader.RequestedFile.Text = DLC1.Tag
            Downloader.DownloadGoStart.Start()
        Else
            Beep()
            DLC1.Enabled = False
            DLC1.BorderColour = Color.FromArgb(25, 25, 25)
            DLC2.Enabled = True
            DLC2.BorderColour = Color.Lime
        End If
    End Sub

    Private Sub DLC2_Click(sender As Object, e As EventArgs) Handles DLC2.Click
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Downloads\" & DLC2.Tag) Then
            Downloader.Show()
            Downloader.RequestedFile.Text = DLC2.Tag
            Downloader.DownloadGoStart.Start()
        Else
            Beep()
            DLC2.Enabled = False
            DLC2.BorderColour = Color.FromArgb(25, 25, 25)
            DLC3.Enabled = True
            DLC3.BorderColour = Color.Lime
        End If
    End Sub

    Private Sub DLC3_Click(sender As Object, e As EventArgs) Handles DLC3.Click
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Downloads\" & DLC3.Tag) Then
            Downloader.Show()
            Downloader.RequestedFile.Text = DLC3.Tag
            Downloader.DownloadGoStart.Start()
        Else
            Beep()
            DLC3.Enabled = False
            DLC3.BorderColour = Color.FromArgb(25, 25, 25)
            DLC4.Enabled = True
            DLC4.BorderColour = Color.Lime
        End If
    End Sub

    Private Sub DLC4_Click(sender As Object, e As EventArgs) Handles DLC4.Click
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Downloads\" & DLC4.Tag) Then
            Downloader.Show()
            Downloader.RequestedFile.Text = DLC4.Tag
            Downloader.DownloadGoStart.Start()
        Else
            Beep()
            DLC4.Enabled = False
            DLC4.BorderColour = Color.FromArgb(25, 25, 25)
            Step2.Enabled = True
            LogInButton1.BorderColour = Color.Lime
        End If
    End Sub

    Private Sub DLC_Load(sender As Object, e As EventArgs) Handles Me.Load
        Lang()
    End Sub

    Public Sub Lang()
        If My.Settings.Lang = "Polish" Then
            ThemeContainer1.Text = "Instalator DLC"
            LicDoneButton.Text = "Zrobione"
            LogInLabel5.Text = "Skopiuj wszystkie pliki z lewej strony na prawą!"
            LogInLabel4.Text = "Krok 5 - Alokacja pliku licencji"
            RetryButton.Text = "Spróbuj ponownie"
            DoneButton.Text = "Zrobione"
            LogInLabel3.Text = "Podaj swój Gamertag poniżej i wciśnij 'Get'." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Poda ci to twoje unikalne ID." &
    "Skopiuj ciąg znaków przy XUID (HEX)."
            LogInLabel2.Text = "Konfiguracja licencji - XUID Grabber"
            Step4.Text = "Krok 4 - Plik licencji | Konfiguracja i Przygotowanie"
            LogInButton2.Text = "Przenieś pliki licencyjne do właściwego miejsca"
            LicenceSetupButton.Text = "Przygotuj Licencję..."
            Step3.Text = "Step 3 - Lokalizacja DLC | Przygotowanie"
            LogInButton1.Text = "Następny krok"
            Step2.Text = "Krok 2 - Wskaż lokalizację Fable III"
            Step1.Text = "Krok 1 - Pobierz DLC"
            DLC4.Text = "Pobierz pliki licencyjne"
            DLC3.Text = "Pobierz Paczkę Inkwizytora"
            DLC2.Text = "Pobierz Traitor's Keep"
            Text = "Fable 3 | Pobieranie DLC"
            RenameLicenceButton.Text = "Zmień nazwę pliku licencyjnego"
            SaveLocationButton.Text = "Wskaż lokalizację Fable III..."
            DLC1.Text = "Pobierz Understone"
            LogInLabel1.Text = "Z lewej strony gdzie są archiwa ZIP, wypakuj je. Do tego rekomenduję WinRARa." & vbNewLine & "Każdy plik osobnie kliknij prawym przyciskiem myszy i użyj opcji WinRARa ""Wypakuj tutaj..." & vbNewLine & "Kiedy wypakujesz już wszystkie archiwa ZIP:
Przenieś następujące foldery: 01_Understone, 02_TraitorsKeep, 03_InquisitorsPack na prawą stronę." & vbNewLine & "To wszystko co na razie trzeba zrobić, kliknij na przycisk niżej."
        End If
    End Sub

#End Region
    'C:\Users\%USERNAME%\AppData\Local\Microsoft\Xlive\DLC\4D53090A\00000002\D7FCB87DC6790538CC5EE45EC44EC782603B8ACB\
    'C:\Users\%USERNAME%\Saved Games\Lionhead Studios\Fable 3 - as reference
End Class