Public Class Frontpage
    Private Sub adminbtn_Click(sender As Object, e As EventArgs) Handles adminbtn.Click
        Me.Hide()
        admin.Show()
    End Sub

    Private Sub superadminbtn_Click(sender As Object, e As EventArgs) Handles superadminbtn.Click
        Me.Hide()
        Collegeui.Show()
    End Sub
End Class