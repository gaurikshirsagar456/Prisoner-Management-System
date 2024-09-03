<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crime
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrisonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.Location = New System.Drawing.Point(954, -89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(298, 32)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Manage Prisoner Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(455, -122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 55)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Staff Record"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BackgroundImage = Global.prisoner_demo.My.Resources.Resources.images1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.TextBox7)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(52, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1289, 836)
        Me.Panel2.TabIndex = 33
        '
        'Button7
        '
        Me.Button7.Image = Global.prisoner_demo.My.Resources.Resources.icons8_search_25
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(892, 772)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 32)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Search"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = true
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 502)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1262, 252)
        Me.DataGridView1.TabIndex = 35
        '
        'Button6
        '
        Me.Button6.Image = Global.prisoner_demo.My.Resources.Resources.icons8_display_25
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(751, 772)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(113, 31)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Display"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = true
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label14.Location = New System.Drawing.Point(183, 213)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(188, 27)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Crime Description"
        '
        'Button3
        '
        Me.Button3.Image = Global.prisoner_demo.My.Resources.Resources.icons8_delete_25
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(620, 774)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 29)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Delete "
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(467, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(331, 55)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "CRIME DATA"
        '
        'Button2
        '
        Me.Button2.Image = Global.prisoner_demo.My.Resources.Resources.icons8_update_25
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(477, 772)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Update"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = true
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox7.Location = New System.Drawing.Point(408, 185)
        Me.TextBox7.Multiline = true
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(697, 85)
        Me.TextBox7.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Image = Global.prisoner_demo.My.Resources.Resources.icons8_save_25
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(355, 770)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add "
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label13.Location = New System.Drawing.Point(219, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 27)
        Me.Label13.TabIndex = 25
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox6.Location = New System.Drawing.Point(939, 445)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(166, 34)
        Me.TextBox6.TabIndex = 24
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ComboBox2.FormattingEnabled = true
        Me.ComboBox2.Items.AddRange(New Object() {"Active", "Closed"})
        Me.ComboBox2.Location = New System.Drawing.Point(408, 441)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(193, 34)
        Me.ComboBox2.TabIndex = 23
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox4.Location = New System.Drawing.Point(939, 309)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(166, 34)
        Me.TextBox4.TabIndex = 22
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox3.Location = New System.Drawing.Point(408, 316)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(193, 34)
        Me.TextBox3.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox1.Location = New System.Drawing.Point(408, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(193, 34)
        Me.TextBox1.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.Location = New System.Drawing.Point(183, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 27)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Crime id"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Items.AddRange(New Object() {"Murder-PC 302  ", "Kidnapping or Maiming for Begging", "Section 363A", "Rape - Section 375", "Robbery - Section 390", "Hit and Run cases - Sections 279, 304A, and 338", "Attempt to suciede - Section 309"})
        Me.ComboBox1.Location = New System.Drawing.Point(939, 382)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(167, 34)
        Me.ComboBox1.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.Location = New System.Drawing.Point(729, 448)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 27)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Reported By"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(183, 452)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 27)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(729, 389)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 27)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Article"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox5.Location = New System.Drawing.Point(408, 382)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(193, 34)
        Me.TextBox5.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(183, 389)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 27)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Date Reported"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(729, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 27)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Date Commited"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(183, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Criminal"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox2.Location = New System.Drawing.Point(939, 97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 34)
        Me.TextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(729, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Crime Location"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrisonToolStripMenuItem, Me.CrimeToolStripMenuItem, Me.VisitorToolStripMenuItem, Me.StaffRecordToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1395, 28)
        Me.MenuStrip1.TabIndex = 36
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
        Me.CrimeToolStripMenuItem.Image = Global.prisoner_demo.My.Resources.Resources.icons8_prisoner_25
        Me.CrimeToolStripMenuItem.Name = "CrimeToolStripMenuItem"
        Me.CrimeToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.CrimeToolStripMenuItem.Text = "Prisoner"
        '
        'StaffRecordToolStripMenuItem
        '
        Me.StaffRecordToolStripMenuItem.Image = Global.prisoner_demo.My.Resources.Resources.icons8_staff_251
        Me.StaffRecordToolStripMenuItem.Name = "StaffRecordToolStripMenuItem"
        Me.StaffRecordToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.StaffRecordToolStripMenuItem.Text = "Staff Record"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.prisoner_demo.My.Resources.Resources.icons8_exit_25
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Crime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1395, 892)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Crime"
        Me.Text = "Crime"
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PrisonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisitorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
