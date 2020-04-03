Public Class Main

    'Declare the variables
    Dim drag2 As Boolean
    Dim mousex2 As Integer
    Dim mousey2 As Integer

    Private Sub Panel11_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel11.MouseDown
        drag2 = True 'Sets the variable drag to true.
        mousex2 = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey2 = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub Panel111_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel11.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag2 Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel11_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel11.MouseUp
        drag2 = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

End Class