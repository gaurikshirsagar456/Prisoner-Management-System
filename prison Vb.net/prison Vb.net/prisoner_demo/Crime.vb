Imports System.Data.SqlClient

Public Class Crime
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private Sub Crime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\gauri\OneDrive\Documents\Visual Studio 2012\Projects\prisoner_demo\prisoner_demo\Database1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        disp_data()

    End Sub

    Public Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Crime"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\gauri\OneDrive\Documents\Visual Studio 2012\Projects\prisoner_demo\prisoner_demo\Database1.mdf;Integrated Security=True")
                con.Open()

                Dim cmd As New SqlCommand()
                cmd.Connection = con
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO Crime (Crime_id, C_Loc, Crime_Desc, Criminal, Date_Commit, Date_Reported, Article, Status, Reported_By) VALUES (@CrimeId, @CLoc, @CrimeDesc, @Criminal, @DateCommit, @DateReported, @Article, @Status, @ReportedBy)"

                ' Use parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@CrimeId", TextBox1.Text)
                cmd.Parameters.AddWithValue("@CLoc", TextBox2.Text)
                cmd.Parameters.AddWithValue("@CrimeDesc", TextBox7.Text)
                cmd.Parameters.AddWithValue("@Criminal", TextBox3.Text)

                ' Convert date strings to DateTime objects
                Dim dateCommit As DateTime
                If DateTime.TryParse(TextBox4.Text, dateCommit) Then
                    cmd.Parameters.AddWithValue("@DateCommit", dateCommit)
                Else
                    ' Handle invalid date format
                    MessageBox.Show("Invalid Date Commit format. Please enter a valid date.")
                    Return
                End If

                Dim dateReported As DateTime
                If DateTime.TryParse(TextBox5.Text, dateReported) Then
                    cmd.Parameters.AddWithValue("@DateReported", dateReported)
                Else
                    ' Handle invalid date format
                    MessageBox.Show("Invalid Date Reported format. Please enter a valid date.")
                    Return
                End If

                cmd.Parameters.AddWithValue("@Article", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@Status", ComboBox2.Text)
                cmd.Parameters.AddWithValue("@ReportedBy", TextBox6.Text)

                cmd.ExecuteNonQuery()
                disp_data()

                MessageBox.Show("Record Inserted Successfully")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error inserting record: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            Dim cmd As New SqlCommand()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE Crime SET C_Loc=@CLoc, Crime_Desc=@CrimeDesc, Criminal=@Criminal, Date_Commit=@DateCommit, Date_Reported=@DateReported, Article=@Article, Status=@Status, Reported_By=@ReportedBy WHERE Crime_id=@CrimeId"

            ' Use parameters to avoid SQL injection
            cmd.Parameters.AddWithValue("@CLoc", TextBox2.Text)
            cmd.Parameters.AddWithValue("@CrimeDesc", TextBox7.Text)
            cmd.Parameters.AddWithValue("@Criminal", TextBox3.Text)

            ' Convert date strings to DateTime objects
            Dim dateCommit As DateTime
            If DateTime.TryParse(TextBox4.Text, dateCommit) Then
                cmd.Parameters.AddWithValue("@DateCommit", dateCommit)
            Else
                ' Handle invalid date format
                MessageBox.Show("Invalid Date Commit format. Please enter a valid date.")
                Return
            End If

            Dim dateReported As DateTime
            If DateTime.TryParse(TextBox5.Text, dateReported) Then
                cmd.Parameters.AddWithValue("@DateReported", dateReported)
            Else
                ' Handle invalid date format
                MessageBox.Show("Invalid Date Reported format. Please enter a valid date.")
                Return
            End If

            cmd.Parameters.AddWithValue("@Article", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@Status", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@ReportedBy", TextBox6.Text)
            cmd.Parameters.AddWithValue("@CrimeId", TextBox1.Text)

            cmd.ExecuteNonQuery()
            disp_data()

            MessageBox.Show("Record updated Successfully")
        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message)
        End Try
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        disp_data()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Crime where Crime_id='" + TextBox1.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandText = "delete from Crime where Crime_Id='" + TextBox1.Text + "'"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record deleted Successfully")
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)

            TextBox1.Text = dr.Cells(0).Value.ToString()
            TextBox2.Text = dr.Cells(1).Value.ToString()
            TextBox7.Text = dr.Cells(2).Value.ToString()
            TextBox3.Text = dr.Cells(3).Value.ToString()
            TextBox4.Text = dr.Cells(4).Value.ToString()
            TextBox5.Text = dr.Cells(5).Value.ToString()
            ComboBox2.Text = dr.Cells(6).Value.ToString()
            ComboBox2.Text = dr.Cells(7).Value.ToString()
            TextBox6.Text = dr.Cells(8).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CrimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrimeToolStripMenuItem.Click
        Prisoner.Show()
        Me.Hide()

    End Sub

    Private Sub PrisonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrisonToolStripMenuItem.Click
        Prison.Show()
        Me.Hide()

    End Sub

    Private Sub VisitorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitorToolStripMenuItem.Click
        Visitor.Show()
        Me.Hide()

    End Sub

    Private Sub StaffRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffRecordToolStripMenuItem.Click
        StaffRecord.Show()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result = MessageBox.Show("Do you really want to exit...", "caption", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            MessageBox.Show("Exiting the application....")
            Application.Exit()
        End If

    End Sub


    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("PLZ enter only letters")
        End If

    End Sub

End Class