<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrisonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrisonerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(389, -56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(531, 55)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "ADD PRISONER DATA"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrisonToolStripMenuItem, Me.CrimeToolStripMenuItem, Me.PrisonerToolStripMenuItem, Me.VisitorToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1457, 28)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrisonToolStripMenuItem
        '
        Me.PrisonToolStripMenuItem.Image = Global.prisoner_demo.My.Resources.Resources.icons8_prison_251
        Me.PrisonToolStripMenuItem.Name = "PrisonToolStripMenuItem"
        Me.PrisonToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.PrisonToolStripMenuItem.Text = "Prison"
        '
        'VisitorToolStripMenuItem
        '
        Me.VisitorToolStripMenuItem.Image = Global.prisoner_demo.My.Resources.Resources.icons8_visitors_25
        Me.VisitorToolStripMenuItem.Name = "VisitorToolStripMenuItem"
        Me.VisitorToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.VisitorToolStripMenuItem.Text = "Visitor"
        '
        'CrimeToolStripMenuItem
        '
        Me.CrimeToolStripMenuItem.Image = Global.prisoner_demo.My.Resources.Resources.icons8_handcuffs_251
        Me.CrimeToolStripMenuItem.Name = "CrimeToolStripMenuItem"
        Me.CrimeToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.CrimeToolStripMenuItem.Text = "Crime"
        '
        'PrisonerToolStripMenuItem
        '
        Me.PrisonerToolStripMenuItem.Image = Global.prisoner_demo.My.Resources.Resources.icons8_prisoner_25
        Me.PrisonerToolStripMenuItem.Name = "PrisonerToolStripMenuItem"
        Me.PrisonerToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.PrisonerToolStripMenuItem.Text = "Prisoner"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.prisoner_demo.My.Resources.Resources.icons8_exit_25
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BackgroundImage = Global.prisoner_demo.My.Resources.Resources.images1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TextBox7)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(78, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1303, 757)
        Me.Panel2.TabIndex = 27
        '
        'Button7
        '
        Me.Button7.Image = Global.prisoner_demo.My.Resources.Resources.icons8_search_25
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(860, 677)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(101, 31)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Search"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 342)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1256, 306)
        Me.DataGridView1.TabIndex = 26
        '
        'Button6
        '
        Me.Button6.Image = Global.prisoner_demo.My.Resources.Resources.icons8_display_25
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(707, 677)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 31)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Display"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(956, 236)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 60)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Browse"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.prisoner_demo.My.Resources.Resources.icons8_delete_25
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(558, 678)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 31)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Delete "
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(933, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 182)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Image = Global.prisoner_demo.My.Resources.Resources.icons8_update_25
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(403, 677)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 33)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Update"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(202, 216)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(167, 34)
        Me.TextBox4.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Image = Global.prisoner_demo.My.Resources.Resources.icons8_save_251
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(260, 677)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add "
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(660, 153)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(147, 34)
        Me.TextBox3.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(202, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 34)
        Me.TextBox1.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(66, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 27)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Staff id"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.ComboBox1.Location = New System.Drawing.Point(202, 150)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(167, 34)
        Me.ComboBox1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(439, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Record"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(660, 293)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(147, 34)
        Me.TextBox7.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(489, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 27)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Contact No."
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(202, 290)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(167, 34)
        Me.TextBox6.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(65, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 27)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Salary"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(489, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 27)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Join date"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(660, 216)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(147, 34)
        Me.TextBox5.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 27)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(489, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 27)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "DOB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Gender"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(660, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(147, 34)
        Me.TextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(489, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Staff Name"
        '
        'StaffRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1457, 813)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Name = "StaffRecord"
        Me.Text = "StaffRecord"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PrisonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisitorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrisonerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
