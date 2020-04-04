Public Class InstallSoftware
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Timer1.Enabled = False
        InstallChocoApps()
    End Sub
    Sub InstallChocoApps()
        ' RunCmd("@""%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe"" -NoProfile -ExecutionPolicy Bypass -Command ""iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))"" && SET ""PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin""", "", False, True)

        Dim Packages() As String = {"bluebeamvu"}
        For Each p In Packages
            RunCmd("choco install " & p & " --force -y --no-progress", "", False, True)
        Next
    End Sub

    Sub RunCmd(command As String, arguments As String, permanent As Boolean, display As Boolean)
        Try
            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
            pi.FileName = "cmd.exe"
            pi.WindowStyle = ProcessWindowStyle.Hidden
            pi.CreateNoWindow = False
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
End Class