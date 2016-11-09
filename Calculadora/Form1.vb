Imports System.Math
Public Class Form1
    Dim op As Integer
    Dim dato1, dato2, rpta As Double
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtver.Text = txtver.Text & “0”
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtver.Text = txtver.Text & “1”
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtver.Text = txtver.Text & “2”
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtver.Text = txtver.Text & “3”
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtver.Text = txtver.Text & “4”
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtver.Text = txtver.Text & “5”
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtver.Text = txtver.Text & “6”
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtver.Text = txtver.Text & “7”
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtver.Text = txtver.Text & “8”
    End Sub

    Private Sub btnmas_Click(sender As Object, e As EventArgs) Handles btnmas.Click
        op = 1
        lbldesc.Text = txtver.Text & "+"
        dato1 = Val(txtver.Text)
        txtver.Clear()
    End Sub

    Private Sub btnmenos_Click(sender As Object, e As EventArgs) Handles btnmenos.Click
        op = 2
        lbldesc.Text = txtver.Text & "-"
        dato1 = Val(txtver.Text)
        txtver.Clear()
    End Sub

    Private Sub btnpor_Click(sender As Object, e As EventArgs) Handles btnpor.Click
        op = 3
        lbldesc.Text = txtver.Text & "x"
        dato1 = Val(txtver.Text)
        txtver.Clear()
    End Sub

    Private Sub btnentre_Click(sender As Object, e As EventArgs) Handles btnentre.Click
        op = 4
        lbldesc.Text = txtver.Text & "/"
        dato1 = Val(txtver.Text)
        txtver.Clear()
    End Sub

    Private Sub btnigual_Click(sender As Object, e As EventArgs) Handles btnigual.Click
        dato2 = Val(txtver.Text)
        Select Case op
            Case 1
                lbldesc.Text = ""
                rpta = dato1 + dato2
            Case 2
                lbldesc.Text = ""
                rpta = dato1 - dato2
            Case 3
                lbldesc.Text = ""
                rpta = dato1 * dato2
            Case 4
                lbldesc.Text = ""
                rpta = dato1 / dato2
        End Select
        txtver.Text = rpta
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtver.Text = txtver.Text & “9”
    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        txtver.Text = txtver.Text & “.”
    End Sub

    Private Sub btnoff_Click(sender As Object, e As EventArgs) Handles btnoff.Click
        End
    End Sub

    Private Sub btnraiz_Click(sender As Object, e As EventArgs) Handles btnraiz.Click
        rpta = Val(txtver.Text) ^ (1 / 2)
        lbldesc.Text = "√(" & txtver.Text & ")"
        txtver.Clear()
        txtver.Text = rpta
    End Sub

    Private Sub btncuadrado_Click(sender As Object, e As EventArgs) Handles btncuadrado.Click
        rpta = (Val(txtver.Text))
        lbldesc.Text = "(" & txtver.Text & ")²"
        rpta = rpta * rpta
        txtver.Clear()
        txtver.Text = rpta
    End Sub

    Private Sub btnsen_Click(sender As Object, e As EventArgs) Handles btnsen.Click
        rpta = (Val(txtver.Text))
        lbldesc.Text = "sen(" & txtver.Text & ")"
        rpta = Sin(rpta)
        txtver.Clear()
        txtver.Text = rpta
    End Sub

    Private Sub btncos_Click(sender As Object, e As EventArgs) Handles btncos.Click
        rpta = (Val(txtver.Text))
        lbldesc.Text = "cos(" & txtver.Text & ")"
        rpta = Cos(rpta)
        txtver.Clear()
        txtver.Text = rpta
    End Sub

    Private Sub btntan_Click(sender As Object, e As EventArgs) Handles btntan.Click
        rpta = (Val(txtver.Text))
        lbldesc.Text = "tan(" & txtver.Text & ")"
        rpta = Tan(rpta)
        txtver.Clear()
        txtver.Text = rpta
    End Sub

    Private Sub btnc_Click(sender As Object, e As EventArgs) Handles btnc.Click
        txtver.Clear()
        lbldesc.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
