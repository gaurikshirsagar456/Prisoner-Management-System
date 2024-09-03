﻿Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class StaffRecord
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub StaffRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmd.CommandText = "select * from StaffRecord"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 90

        Dim pic1 As New DataGridViewImageColumn

        DataGridView1.DataSource = dt
        pic1 = DataGridView1.Columns(8)
        pic1.ImageLayout = DataGridViewImageCellLayout.Stretch

        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            If Integer.Parse(TextBox6.Text) < 0 Then
                TextBox6.Text = "0"
            End If

            cmd.CommandText = "insert into StaffRecord(S_Id,S_name,S_gender,S_DOB,S_address,Join_date,Salary,Contact,S_img) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + ComboBox1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "',@d5)"

            ' code for img
            Dim ms As New MemoryStream()
            Dim img As New Bitmap(PictureBox1.Image)
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@d5", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)

            cmd.ExecuteNonQuery()
            disp_data()

            MessageBox.Show("Record Inserted Successfully")

        Catch ex As SqlException
            If ex.Number = 2627 Then ' Check if the error number is for a duplicate key violation
                MessageBox.Show("Data with the specified S_Id already exists. Please enter a different S_Id.")
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
        cmd.CommandText = "update StaffRecord set S_name='" + TextBox2.Text + "', S_gender='" + ComboBox1.Text + "',S_DOB='" + TextBox3.Text + "', S_address='" + TextBox4.Text + "',Join_date='" + TextBox5.Text + "',Salary='" + TextBox6.Text + "',Contact='" + TextBox7.Text + "', S_img=@d5 where S_id='" + TextBox1.Text + "' "

        'code for img
        Dim ms As New MemoryStream()
        Dim img As New Bitmap(PictureBox1.Image)
        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim data As Byte() = ms.GetBuffer()
        Dim p As New SqlParameter("@d5", SqlDbType.Image)
        p.Value = data

        cmd.Parameters.Add(p)
        cmd.ExecuteNonQuery()
        disp_data()

        MessageBox.Show("Record updated Successfully")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim openfilledialog1 As New OpenFileDialog
        openfilledialog1.Filter = "images|*.jpg;*.png;*.gif;*.bmp"
        If openfilledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openfilledialog1.FileName)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from StaffRecord where S_id='" + TextBox1.Text + "'"
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
        cmd.CommandText = "delete from StaffRecord where S_name='" + TextBox2.Text + "'"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record deleted Successfully")
    End Sub


    Private Sub TextBox7_Keypress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
            MessageBox.Show("This Field Will Accept Numbers Only")

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        disp_data()
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

            'code for image 
            Dim data As Byte() = DirectCast(dr.Cells(8).Value, Byte())
            Dim ms As New MemoryStream(data)
            PictureBox1.Image = Image.FromStream(ms)

        Catch ex As Exception

        End Try
    End Sub

   

    Private Sub PrisonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrisonToolStripMenuItem.Click
        Prison.Show()
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

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result = MessageBox.Show("Do you really want to exit...", "caption", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            MessageBox.Show("Exiting the application....")
            Application.Exit()
        End If
    End Sub

    Private Sub PrisonerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrisonerToolStripMenuItem.Click
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