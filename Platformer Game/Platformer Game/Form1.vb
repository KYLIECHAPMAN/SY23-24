Public Class Form2DPlatFormer
    Dim movespeed As Integer = 10
    Dim isjumping As Boolean
    Private Sub Form2DPlatFormer_keydown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isjumping = True
        End Select
        TextBox1.Select()
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        PicPlayer.Left += movespeed
    End Sub

    Private Sub Form2DPlatFormer_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isjumping = False
        End Select
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        PicPlayer.Left -= movespeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        PicPlayer.Top -= movespeed
    End Sub

    Private Sub Form2DPlatFormer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If PicPlayer.Bounds.IntersectsWith(PicGround.Bounds) Then
            tmrGravity.Stop()
        Else
            If isjumping = False Then
                tmrGravity.Start()
            End If
        End If
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
                If b.Tag = "win" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Visible = False
                    End If
                End If
            End If
        Next

    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        PicPlayer.Top += movespeed
    End Sub

End Class
