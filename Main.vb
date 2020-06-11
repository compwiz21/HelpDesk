Imports System.Net

Public Class Main

    'Declare the variables
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Panel11_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel11.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub Panel111_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel11.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel11_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel11.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InstallSoftware.Show()
        Me.Hide()
    End Sub
    Private Sub PreloadSoftware()
        Label5.Visible = True
        ProgressBar1.Visible = True
        Try
            If Not My.Computer.FileSystem.FileExists("C:\Zone6Helpdesk\Software.zip") Then
                Dim client As WebClient = New WebClient

                AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged

                AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted

                client.DownloadFileAsync(New Uri("http://ldc.prestonbarnes.com/Software.zip"), "C:\Zone6Helpdesk\Software.zip")

            Else
                ProgressBar1.Maximum = 100
                ProgressBar1.Value = 100
                PictureBox3.Visible = True
                Label9.Text = "Fast Internet My Friend. Preload Complete..."

            End If

        Catch ex As Exception

        End Try

    End Sub
    Dim CancelDownload As Boolean = False
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
            Dim percentage As Double = bytesIn / totalBytes * 100

        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())


    End Sub
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        PictureBox3.Visible = True
        Label9.Text = "Fast Internet My Friend. Preload Complete..."

    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreloadSoftware()

    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '    Application.Exit()
    End Sub
End Class