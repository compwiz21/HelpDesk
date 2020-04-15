Imports System.ComponentModel
Imports System.Net


Public Class InstallSoftware
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Timer1.Enabled = False
        InstallBluebeamVU()

    End Sub
    Sub InstallBluebeam()
        '  RunCmd("@""%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe"" -NoProfile -ExecutionPolicy Bypass -Command ""iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))"" && SET ""PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin""", "", False, True)
        Timer2.Enabled = True
        Timer2.Start()
        Dim Packages() As String = {"bluebeamvu"}
        For Each p In Packages
            RunCmd("C:\Zone6HelpDesk\BluebeamVu.exe", "", False, True)
        Next
        Timer2.Stop()
        PictureBox4.Visible = True
        Label5.Visible = True

    End Sub

    Sub RunCmd(command As String, arguments As String, permanent As Boolean, display As Boolean)
        Try
            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
            pi.FileName = "cmd.exe"
            pi.WindowStyle = ProcessWindowStyle.Hidden
            pi.CreateNoWindow = True
            pi.Verb = "runas"
            pi.UseShellExecute = False
            p.StartInfo = pi
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardOutput = True
            p.Start()
            p.WaitForExit()
            p.Close()


        Catch ex As Exception

        End Try
    End Sub

    Sub RunPowerShell(command As String, arguments As String, permanent As Boolean, display As Boolean)
        Try
            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
            pi.FileName = "powershell.exe"
            pi.WindowStyle = ProcessWindowStyle.Hidden
            pi.CreateNoWindow = True
            pi.Verb = "runas"
            pi.UseShellExecute = False
            p.StartInfo = pi
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardOutput = True
            p.Start()
            p.WaitForExit()
            p.Close()


        Catch ex As Exception

        End Try
    End Sub
    Private Sub InstallChocolatey()
        RunPowerShell("Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))", "", False, True)


    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Background_Chocolatey.DoWork
        InstallChocolatey()
    End Sub

    Private Sub BackgroundWorker1_Disposed(sender As Object, e As EventArgs) Handles Background_Chocolatey.Disposed

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Background_Chocolatey.RunWorkerCompleted
        PictureBox3.Visible = True
        Label3.Visible = True
        InstallBluebeamVU()
        InstallBluebeam()



    End Sub

    Private Sub Background_Bluebeam_DoWork(sender As Object, e As DoWorkEventArgs) Handles Background_Bluebeam.DoWork
        InstallBluebeamVU()

    End Sub

    Private Sub Background_Bluebeam_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Background_Bluebeam.RunWorkerCompleted
        PictureBox4.Visible = True
        Label4.Visible = True
    End Sub

    Private Sub InstallBluebeamVU()
        Label5.Visible = True
        ProgressBar3.Visible = True
        Try
            If Not My.Computer.FileSystem.FileExists("C:\Zone6HelpDesk\BlueBeamVu.exe") Then
                Dim client As WebClient = New WebClient

                AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged

                AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted

                client.DownloadFileAsync(New Uri("https://downloads.bluebeam.com/software/downloads/2017.0.40/BbRevu2017.0.40_CAD.exe"), "C:\Zone6Helpdesk\BluebeamVu.exe")
            Else
                ProgressBar3.Value = 100

                PictureBox3.Visible = True
                Label3.Visible = True
                Timer2.Start()
                InstallBluebeam()
            End If

        Catch ex As Exception

        End Try


    End Sub
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        ProgressBar3.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        PictureBox3.Visible = True
        Label3.Visible = True
        Timer2.Start()
        InstallBluebeam()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label5.Text = "Downloaded Bluebeam. Now Installing..." Then
            Label5.Text = "Downloaded Bluebeam. Now Installing......"
        Else
            Label5.Text = "Downloaded Bluebeam. Now Installing..."
        End If
    End Sub
End Class