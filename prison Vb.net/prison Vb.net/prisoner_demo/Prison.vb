﻿Imports System.Data.SqlClient

Public Class Prison
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer


    Private Sub Prison_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmd.CommandText = "select * from Prison"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into Prison(Prison_Id,Prison_Name,Address,Capacity,Contact,Cell_Blocks) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')"
        cmd.ExecuteNonQuery()
        disp_data()

        MessageBox.Show("Record Inserted Successfully")
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update Prison set Prison_Name='" + TextBox2.Text + "',Address='" + TextBox3.Text + "',Capacity='" + TextBox4.Text + "',Contact='" + TextBox5.Text + "',Cell_Blocks='" + TextBox6.Text + "' where Prison_Id='" + TextBox1.Text + "' "
        cmd.ExecuteNonQuery()

        disp_data()

        MessageBox.Show("Record updated Successfully")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        disp_data()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Prison where Prison_Id='" + TextBox1.Text + "'"
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
        cmd.CommandText = "delete from Prison where Prison_Id='" + TextBox1.Text + "'"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record updated Successfully")
    End Sub
    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)

            TextBox1.Text = dr.Cells(0).Value.ToString()
            TextBox2.Text = dr.Cells(1).Value.ToString()
            TextBox3.Text = dr.Cells(2).Value.ToString()
            TextBox4.Text = dr.Cells(3).Value.ToString()
            TextBox5.Text = dr.Cells(4).Value.ToString()
            TextBox6.Text = dr.Cells(5).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrisonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrisonToolStripMenuItem.Click
        Prisoner.Show()
        Me.Hide()

    End Sub

    Private Sub VisitorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitorToolStripMenuItem.Click
        Visitor.Show()
        Me.Hide()

    End Sub

    Private Sub CrimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrimeToolStripMenuItem.Click
        Crime.Show()
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

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("PLZ enter only letters")
        End If

    End Sub


    Private Sub TextBox5_Keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
            MessageBox.Show("This Field Will Accept Numbers Only")

        End If
    End Sub



    Private Sub TextBox4_Keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
            MessageBox.Show("This Field Will Accept Numbers Only")

        End If
    End Sub



    Private Sub TextBox6_Keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
            MessageBox.Show("This Field Will Accept Numbers Only")

        End If
    End Sub


End Class