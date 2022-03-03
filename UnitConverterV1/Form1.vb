Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim UnitSele1 As String
        UnitSele1 = ComboBox1.SelectedItem

        If UnitSele1 = "VELOCITY" Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add("m/s")
            ComboBox3.Items.Add("knots")
            ComboBox3.Items.Add("km/h")
            ComboBox3.Items.Add("mph")
            ComboBox3.Items.Add("cm/s")

            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("m/s")
            ComboBox4.Items.Add("knots")
            ComboBox4.Items.Add("km/h")
            ComboBox4.Items.Add("mph")
            ComboBox4.Items.Add("cm/s")
        End If


    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged


    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Value1 As Integer
        Value1 = TextBox1.Text
        Dim Con1 As String
        Con1 = ComboBox3.SelectedItem
        Dim Con2 As String
        Con2 = ComboBox4.SelectedItem
        Dim result As Double


        If Con1 = "m/s" Then
            If Con2 = "knots" Then
                result = Value1 * (1 / 1000) * (3600) * (1 / 1.852)
                TextBox2.Text = result
            End If
            If Con2 = "km/h" Then
                result = Value1 * (1 / 1000) * (3600)
                TextBox2.Text = result
            End If
            If Con2 = "mph" Then
                result = Value1 * (1 / 1000) * (3600) / (1.609344)
                TextBox2.Text = result
            End If
            If Con2 = "cm/s" Then
                result = Value1 * (100)
                TextBox2.Text = result
            End If

        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

End Class
