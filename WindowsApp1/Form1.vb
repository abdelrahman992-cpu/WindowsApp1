Public Class Form1

    Dim total1, total2, total3 As Decimal
    Dim price1 As Decimal = 30.0
    Dim price2 As Decimal = 25.0
    Dim price3 As Decimal = 1.5
    Dim price4 As Decimal = 2.0
    Dim price5 As Decimal = 1.0
    Dim price6 As Decimal = 2.5
    Dim price7 As Decimal = 3.0
    Dim price8 As Decimal = 5.5
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.menu2.Visible = False
        Me.menu3.Visible = False
        Me.menu4.Visible = False

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles menu1.Enter

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles drink.CheckedChanged
        If drink.Checked = True Then
            Me.menu4.Visible = True
            Me.Label3.Visible = True
            Me.drink.Checked = True
            Me.Label3.Text = Format(total3, "#.0")
            Me.total3 = price5
        Else
            Me.menu4.Visible = False
            Me.Label3.Visible = False
            Me.total3 = 0.0
        End If
    End Sub

    Private Sub chicken_CheckedChanged(sender As Object, e As EventArgs) Handles chicken.CheckedChanged
        If chicken.Checked = True Then
            Me.menu2.Visible = True
            Me.Label1.Visible = True
            Me.chicken1.Checked = True
            Me.Label1.Text = Format(total1, "#.0")
            Me.total1 = price1
        Else
            Me.menu2.Visible = False
            Me.Label1.Visible = False
            Me.total1 = 0.0
        End If
    End Sub

    Private Sub salad_CheckedChanged(sender As Object, e As EventArgs) Handles salad.CheckedChanged
        If salad.Checked = True Then
            Me.menu3.Visible = True
            Me.salad1.Checked = False
            Me.salad2.Checked = False
            Me.Label1.Text = Format(total2, "#.0")
            Me.total2 = 0
            Me.Label2.Visible = True

        Else
            Me.menu3.Visible = False
            Me.Label2.Visible = False
            Me.total2 = 0.0
        End If
    End Sub

    Private Sub chicken1_CheckedChanged(sender As Object, e As EventArgs) Handles chicken1.CheckedChanged
        If chicken1.Checked = True Then
            total1 = price1
            Label1.Text = Format(total1, "#.0")
        Else
            total1 = price2
            Label1.Text = Format(total1, "#.0")
        End If
    End Sub
    Private Sub drink1_CheckedChanged(sender As Object, e As EventArgs) Handles drink1.CheckedChanged
        total3 = price5
        Label3.Text = Format(total3, "#.0")
    End Sub

    Private Sub drink2_CheckedChanged(sender As Object, e As EventArgs) Handles drink2.CheckedChanged
        total3 = price6
        Label3.Text = Format(total3, "#.0")
    End Sub

    Private Sub drink3_CheckedChanged(sender As Object, e As EventArgs) Handles drink3.CheckedChanged
        total3 = price7
        Label3.Text = Format(total3, "#.0")
    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs) Handles menu3.Enter

    End Sub

    Private Sub salad1_CheckedChanged_1(sender As Object, e As EventArgs) Handles salad1.CheckedChanged
        If salad1.Checked = True Then
            total2 = price3 + total2
            Label2.Text = Format(total2, "#.0")
        Else
            total2 = total2 - price3
            Label2.Text = Format(total2, "#.0")
        End If
    End Sub


    Private Sub salad2_CheckedChanged_1(sender As Object, e As EventArgs) Handles salad2.CheckedChanged
        If salad2.Checked = True Then
            total2 = price4 + total2
            Label2.Text = Format(total2, "#.0")
        Else
            total2 = total2 - price4


            Label2.Text = Format(total2, "#.0")
        End If
    End Sub

    Private Sub drink4_CheckedChanged(sender As Object, e As EventArgs) Handles drink4.CheckedChanged
        total3 = price8
        Label3.Text = Format(total3, "#.0")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Decimal
        x = total1 + total2 + total3
        Me.Label4.Text = Format(x, "##.0 pounds")
    End Sub



End Class
