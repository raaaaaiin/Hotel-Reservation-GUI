Public Class Form2

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel3.Controls.Clear()
        Form1.TopLevel = False
        Panel3.Controls.Add(Form1)
        Form1.Show()
        Panel2.Show()


    End Sub

    Private Sub Panel28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel28.Click, Label36.Click
        Panel2.Controls.Clear()
        Dashboard.TopLevel = False
        Panel2.Controls.Add(Dashboard)
        Dashboard.Show()
    End Sub

    Private Sub Panel30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel30.Click, Label37.Click
        Panel2.Controls.Clear()
        Booking.TopLevel = False
        Panel2.Controls.Add(Booking)
        Booking.Show()
    End Sub

    Private Sub Label38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel32.Click, Label38.Click
        Panel2.Controls.Clear()
        Guest.TopLevel = False
        Panel2.Controls.Add(Guest)
        Guest.Show()
    End Sub

    Private Sub Panel36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel36.Click, Label40.Click
        Panel2.Controls.Clear()
        Form3.TopLevel = False
        Panel2.Controls.Add(Form3)
        Form3.Show()
    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel34.Click, Label39.Click
        Panel2.Controls.Clear()
        Panel3.Controls.Clear()
        Panel3.Show()
        reservation.TopLevel = False
        Panel3.Controls.Add(reservation)
        reservation.Show()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel8.Click, Label1.Click
        Panel2.Hide()
        Panel6.Show()
        Panel3.Controls.Clear()
        Panel3.Show()
        Form1.TopLevel = False
        Panel3.Controls.Add(Form1)
        Form1.Show()
    End Sub
End Class