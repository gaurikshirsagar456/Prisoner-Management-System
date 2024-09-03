Imports System.Data.SqlClient
Public Class Visitor
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer

    Private Sub Visitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmd.CommandText = "select * from Visitor"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into Visitor(V_Id,V_Name,Gender,DOB,Address,Relation,Prisoner_Id,InTime,OutTime) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + ComboBox1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')"
            cmd.ExecuteNonQuery()
            disp_data()

            MessageBox.Show("Record Inserted Successfully")

        Catch ex As SqlException
            If ex.Number = 2627 Then ' Check if the error number is for a duplicate key violation
                MessageBox.Show("Data with the specified V_Id already exists. Please enter a different V_Id.")
            Else
                MessageBox.Show("Error inserting data: " & ex.Message)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update Visitor set V_Name='" + TextBox2.Text + "',Gender='" + ComboBox1.Text + "', DOB='" + TextBox3.Text + "',Address='" + TextBox4.Text + "',Relation='" + TextBox5.Text + "',Prisoner_Id='" + TextBox6.Text + "',InTime='" + TextBox7.Text + "',OutTime='" + TextBox8.Text + "' where V_Id='" + TextBox1.Text + "' "
        cmd.ExecuteNonQuery()

        disp_data()

        MessageBox.Show("Record updated Successfully")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandText = "delete from Visitor where V_Id='" + TextBox1.Text + "'"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record deleted Successfully")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        disp_data()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Visitor where V_Id='" + TextBox1.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)

            TextBox1.Text = dr.Cells(0).Value.ToString()
            TextBox2.Text = dr.Cells(1).Value.ToString()
            ComboBox1.Text = dr.Cells(2).Value.ToString()
            TextBox3.Text = dr.Cells(3).Value.ToString()
            TextBox4.Text = dr.Cells(4).Value.ToString()
            TextBox5.Text = dr.Cells(5).Value.ToString()
            TextBox6.Text = dr.Cells(6).Value.ToString()
            TextBox7.Text = dr.Cells(7).Value.ToString()
            TextBox8.Text = dr.Cells(8).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrisonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrisonToolStripMenuItem.Click
        Prison.Show()
        Me.Hide()
    End Sub

    Private Sub CrimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrimeToolStripMenuItem.Click
        Crime.Show()
        Me.Hide()
    End Sub

    Private Sub VisitorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitorToolStripMenuItem.Click
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

    Private Sub StaffRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffRecordToolStripMenuItem.Click
        Prisoner.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("PLZ enter only letters")
        End If
    End Sub
End Class