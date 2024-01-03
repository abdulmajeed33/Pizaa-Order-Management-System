Public Class Settings


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim obj As New Billing()
        obj.Show()
        Me.Hide()
    End Sub
End Class