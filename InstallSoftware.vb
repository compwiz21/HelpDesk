Imports System.ComponentModel
Imports System.Net


Public Class InstallSoftware
    Dim installstep As Integer = 1
    Sub installChocolatey()


        powershellscript = "Set-ExecutionPolicy Bypass -Scope Process -Force; iwr https://chocolatey.org/install.ps1 -UseBasicParsing | iex"
        RunPowerShell()


    End Sub

    Sub InstallChocoApps()
        RunCmd("@""%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe"" -NoProfile -ExecutionPolicy Bypass -Command ""iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))"" && SET ""PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin""", "", False, True)

        Dim Packages() As String = {"zoom", "whatsapp", "pdfcreator", "bluebeamvu", "teamviewer"}
        For Each p In Packages
            Background_InstallSoftware.ReportProgress(10)
            RunCmd("choco install " & p & " --force -y --no-progress", "", False, True)
            installstep = installstep + 1

        Next
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
    Dim powershellscript As String

    Sub RunPowerShell()



        Try
            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            pi.Arguments = powershellscript
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Background_Chocolatey.RunWorkerAsync()
    End Sub

    Private Sub Background_Chocolatey_DoWork(sender As Object, e As DoWorkEventArgs) Handles Background_Chocolatey.DoWork
        installChocolatey()
    End Sub

    Private Sub Background_Chocolatey_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Background_Chocolatey.RunWorkerCompleted
        Label5.Text = "Pre-Requisites installed. Now installing required software....please be patient, this can take a while."
        prerequisitecheckbox.Checked = True
        ProgressBar1.Location = New Point(280, 259)
        Background_InstallSoftware.RunWorkerAsync()
    End Sub



    Private Sub InstallSoftware_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label5.Text = "Installing Software"

        Background_Chocolatey.RunWorkerAsync()
    End Sub

    Private Sub Background_InstallSoftware_DoWork(sender As Object, e As DoWorkEventArgs) Handles Background_InstallSoftware.DoWork
        InstallChocoApps()
    End Sub

    Private Sub Background_InstallSoftware_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Background_InstallSoftware.RunWorkerCompleted
        teamviewercheckbox.Checked = True
        Installskype()

    End Sub

    Private Sub Background_InstallSoftware_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles Background_InstallSoftware.ProgressChanged
        If installstep < 2 Then
            zoomcheckbox.Checked = True
            ProgressBar1.Location = New Point(306, 283)
        Else
            If installstep = 2 Then
                whatsappcheckbox.Checked = True
                ProgressBar1.Location = New Point(312, 305)
            Else
                If installstep = 3 Then
                    pdfcreatorcheckbox.Checked = True
                    ProgressBar1.Location = New Point(313, 324)
                Else
                    If installstep = 4 Then
                        bluebeamvucheckbox.Checked = True
                        ProgressBar1.Location = New Point(312, 347)
                    Else
                        If installstep = 5 Then
                            teamviewercheckbox.Checked = True
                            ProgressBar1.Location = New Point(372, 372)
                        End If
                    End If
                End If
            End If
        End If

        ProgressBar3.PerformStep()
    End Sub

    Private Sub InstallSkype()

        Dim s As String
        s = "msiexec.exe /qn /i ""C:\Zone6HelpDesk\SkypeForBusinessPlugin.msi"""
        Shell(s, AppWinStyle.NormalFocus)
        ProgressBar1.Location = New Point(327, 395)
        skypeforbusinesscheckbox.Checked = True
        InstallIE()
    End Sub
    Private Sub InstallIE()

        RunCmd("C:\Zone6HelpDesk\AddShortcuts.bat", "", False, True)
        ProgressBar1.Location = New Point(376, 418)
        ieshortcutscheckbox.Checked = True
        UnPinEdge()
    End Sub

    Sub UnPinEdge()

        Dim s As String
        s = "powershell.exe ""C:\Zone6helpdesk\Unpin.ps1"""
        Shell(s, AppWinStyle.NormalFocus)
        ProgressBar1.Location = New Point(334, 441)
        unpinedgecheckbox.Checked = True
        PINInternetExplorer()
    End Sub

    Private Sub PINInternetExplorer()

        RunCmd("C:\Zone6HelpDesk\syspin.exe ""%PROGRAMFILES%\Internet Explorer\iexplore.exe"" 5386", "", False, True)
        Label2.Text = "IE Pinned to Taskbar."
        pinietaskbarcheckbox.Checked = True
    End Sub
End Class