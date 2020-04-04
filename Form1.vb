Imports System.Net
Imports System.Net.Mail
Imports System.Threading
Imports System.Management
Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Timer1.Stop()
        Timer2.Enabled = True
        Timer2.Start()
        PictureBox2.Visible = True
        Label3.Visible = True
        GetSpiceWorksVersion()
        GetPDFCreatorVersion()
        GetBluebeamVersion()
        GetWatchtowerCadVersion()
        GetWindowsOSVersion()
        GetWindowsOSBuildVersion()
        GetPowerBIDesktopVersion()
        Label7.Text = ("Timer1")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        Timer2.Stop()

        PictureBox3.Visible = True
        Label4.Visible = True
        'InstallSpiceworks.Enabled = True
        'InstallSpiceworks.Start()
        Label8.Text = "Timer2"
        Timer3.Enabled = True
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Enabled = False
        Timer3.Stop()
        PictureBox4.Visible = True
        Label5.Visible = True
        Label9.Text = "Timer3"
        Timer4.Enabled = True
        Timer4.Start()

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer5.Enabled = False
        Timer5.Stop()

        Label11.Text = "Timer5"

        PictureBox5.Visible = True
        Label6.Visible = True

        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Enabled = False
        Timer4.Stop()
        PictureBox5.Visible = True
        Label6.Visible = True
        PictureBox4.Visible = True
        Label5.Visible = True
        Timer5.Enabled = True
        Timer5.Start()
        Label10.Text = "Timer4"
    End Sub
    Dim PDFCreatorVersionChecked As Boolean = False
    Dim BluebeamVersionChecked As Boolean = False
    Dim WatchtowerCadVersionChecked As Boolean = False
    Dim WindowsOSVersionChecked As Boolean = False
    Dim WindowsOSBuildVersionChecked As Boolean = False
    Dim pdfcreatorversion As String
    Dim bluebeamversion As String
    Dim watchtowercadversion As String
    Dim windowsosversion As String
    Dim windowsosbuildversion As String
    Dim powerbidesktop As String
    Dim powerbidesktopchecked As Boolean = False
    Dim spiceworksversion As String
    Private Sub GetSpiceWorksVersion()
        Try
            If My.Computer.FileSystem.FileExists("C:\Zone6HelpDesk\Spiceworks.txt") Then
                spiceworksversion = My.Computer.FileSystem.ReadAllText("C:\Zone6Helpdesk\Spiceworks.txt")
                If spiceworksversion <> "" Then
                    Dim nonNumericCharacters As New System.Text.RegularExpressions.Regex("[^0-9.]")
                    Dim numericOnlyString As String = nonNumericCharacters.Replace(spiceworksversion, String.Empty)
                    spiceworksversion = numericOnlyString
                    'SpiceworksVersionLabel.Text = spiceworksversion
                    'SpiceworksVersionLabel.Visible = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetPowerBIDesktopVersion()
        Try
            If My.Computer.FileSystem.FileExists("C:\Zone6Helpdesk\PowerBIDesktop.txt") Then
                powerbidesktopchecked = True
                powerbidesktop = My.Computer.FileSystem.ReadAllText("C:\Zone6Helpdesk\PowerBIDesktop.txt")
                If powerbidesktop <> "" Then
                    powerbidesktop = "Installed"
                    'PowerBiColor.Visible = True
                Else
                    powerbidesktop = "Not Installed"
                    'PowerBIGray.Visible = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetWindowsOSBuildVersion()
        Try
            If My.Computer.FileSystem.FileExists("C:\Zone6Helpdesk\WindowsBuildNumber.txt") Then
                WindowsOSBuildVersionChecked = True
                windowsosbuildversion = My.Computer.FileSystem.ReadAllText("C:\Zone6Helpdesk\WindowsBuildNumber.txt")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetWindowsOSVersion()
        Try
            If My.Computer.FileSystem.FileExists("C:\Zone6Helpdesk\WindowsOS.txt") Then
                WindowsOSVersionChecked = True
                windowsosversion = My.Computer.FileSystem.ReadAllText("C:\Zone6Helpdesk\WindowsOS.txt")

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetPDFCreatorVersion()
        Try
            If My.Computer.FileSystem.FileExists("C:\Zone6Helpdesk\PDFCreator.txt") Then
                PDFCreatorVersionChecked = True


                pdfcreatorversion = My.Computer.FileSystem.ReadAllText("C:\Zone6Helpdesk\PDFCreator.txt")
                If pdfcreatorversion = "" Then
                    'PDFCreatorGray.Visible = True
                    'PDFCreatorColor.Visible = False
                Else
                    'PDFCreatorColor.Visible = True
                    'PDFCreatorGray.Visible = False
                    Dim nonNumericCharacters As New System.Text.RegularExpressions.Regex("[^0-9.]")
                    Dim numericOnlyString As String = nonNumericCharacters.Replace(pdfcreatorversion, String.Empty)
                    pdfcreatorversion = numericOnlyString
                    'PDFCreatorVersionLabel.Text = pdfcreatorversion
                    'PDFCreatorVersionLabel.Visible = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetBluebeamVersion()
        Try
            If My.Computer.FileSystem.FileExists("C:\Zone6Helpdesk\Bluebeam.txt") Then
                BluebeamVersionChecked = True

                bluebeamversion = My.Computer.FileSystem.ReadAllText("C:\Zone6Helpdesk\Bluebeam.txt")
                If bluebeamversion = "" Then
                    'BlueBeamGray.Visible = True
                    'BlueBeamColor.Visible = False
                Else
                    'BlueBeamGray.Visible = False
                    'BlueBeamColor.Visible = True
                    Dim nonNumericCharacters As New System.Text.RegularExpressions.Regex("[^0-9.]")
                    Dim numericOnlyString As String = nonNumericCharacters.Replace(bluebeamversion, String.Empty)
                    bluebeamversion = numericOnlyString
                    'BlueBeamVersionLabel.Text = bluebeamversion
                    'BlueBeamVersionLabel.Visible = True


                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetWatchtowerCadVersion()
        Try
            If My.Computer.FileSystem.FileExists("C:\Zone6Helpdesk\WatchtowerCad.txt") Then


                watchtowercadversion = My.Computer.FileSystem.ReadAllText("C:\Zone6Helpdesk\WatchtowerCad.txt")
                If watchtowercadversion = "" Then
                    'WTCadGray.Visible = True
                    'WTCadColor.Visible = False
                Else
                    'WTCadColor.Visible = True
                    'WTCadGray.Visible = False

                    Dim nonNumericCharacters As New System.Text.RegularExpressions.Regex("[^0-9]")
                    Dim numericOnlyString As String = nonNumericCharacters.Replace(watchtowercadversion, String.Empty)
                    watchtowercadversion = numericOnlyString
                    'WTCadVersionLabel.Text = watchtowercadversion
                    'WTCadVersionLabel.Visible = True

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Function IsProcessRunning(ByVal name As String) As Boolean
        For Each clsProcess As Process In Process.GetProcesses()

            If clsProcess.ProcessName.StartsWith(name) Then
                Return True
            End If
        Next

        Return False
    End Function
    Dim SpiceworksInstalled As Boolean = False
    Dim timerrunning As Boolean = True
    Private Sub InstallSpiceworks_Tick(sender As Object, e As EventArgs) Handles InstallSpiceworks.Tick
        InstallSpiceworks.Stop()
        InstallSpiceworks.Enabled = False


        If Not My.Computer.FileSystem.DirectoryExists("C:\Zone6HelpDesk") Then
            My.Computer.FileSystem.CreateDirectory("C:\Zone6HelpDesk")
        End If
        Try
            'Dim remoteUri As String = "http://download.spiceworks.com/Platform-Tools/current/Spiceworks%20TLS%20Agent.msi"
            'Dim fileName As String = "C:\Zone6HelpDesk\Spiceworks.msi"
            'Dim password As String = "..."
            'Dim username As String = "..."

            'Using client As New WebClient()

            '    client.DownloadFile(remoteUri, fileName)
            'End Using
            If Not My.Computer.FileSystem.FileExists("C:\Zone6HelpDesk\Spiceworks.msi") Then My.Computer.Network.DownloadFile("http://ldc.prestonbarnes.com/Spiceworks.msi", "C:\Zone6HelpDesk\Spiceworks.msi")
            Dim s As String
            s = "msiexec.exe /qn /i ""C:\Zone6HelpDesk\Spiceworks.msi"" SPICEWORKS_SERVER=""zone6helpdesk.mykeyauto.com"" SPICEWORKS_PORT=""443"" SPICEWORKS_AUTH_KEY=""YHmBSOeFxHVhrgE96LbVcyNMGEI="" ADDLOCAL=""FeatureService"""
            Shell(s, AppWinStyle.NormalFocus)

            SpiceworksInstalled = True



        Catch ex As Exception
            MsgBox("Can't download file")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
    End Sub
    'Declare the variables
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

End Class

