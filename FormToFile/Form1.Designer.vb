<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Text = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Xml = New System.Windows.Forms.PictureBox()
        Me.Json = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Text, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Xml, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Json, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'name
        '
        Me.name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name.Location = New System.Drawing.Point(26, 96)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(273, 30)
        Me.name.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Location = New System.Drawing.Point(266, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Close"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Age"
        '
        'age
        '
        Me.age.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.Location = New System.Drawing.Point(26, 169)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(273, 30)
        Me.age.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Address"
        '
        'address
        '
        Me.address.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(26, 243)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(273, 30)
        Me.address.TabIndex = 5
        '
        'Text
        '
        Me.Text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Text.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text.Image = Global.FormToFile.My.Resources.Resources.txt
        Me.Text.Location = New System.Drawing.Point(26, 310)
        Me.Text.Name = "Text"
        Me.Text.Size = New System.Drawing.Size(70, 85)
        Me.Text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Text.TabIndex = 8
        Me.Text.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FormToFile.My.Resources.Resources.lines1
        Me.PictureBox1.Location = New System.Drawing.Point(316, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(284, 455)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Xml
        '
        Me.Xml.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Xml.Image = Global.FormToFile.My.Resources.Resources.xml
        Me.Xml.Location = New System.Drawing.Point(126, 310)
        Me.Xml.Name = "Xml"
        Me.Xml.Size = New System.Drawing.Size(70, 85)
        Me.Xml.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Xml.TabIndex = 9
        Me.Xml.TabStop = False
        '
        'Json
        '
        Me.Json.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Json.Image = Global.FormToFile.My.Resources.Resources.json
        Me.Json.Location = New System.Drawing.Point(228, 310)
        Me.Json.Name = "Json"
        Me.Json.Size = New System.Drawing.Size(70, 85)
        Me.Json.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Json.TabIndex = 10
        Me.Json.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 33)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Create A File"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(589, 447)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Json)
        Me.Controls.Add(Me.Xml)
        Me.Controls.Add(Me.Text)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.SystemColors.ButtonFace
        CType(Me.Text, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Xml, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Json, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents age As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Text As PictureBox
    Friend WithEvents Xml As PictureBox
    Friend WithEvents Json As PictureBox
    Friend WithEvents Label5 As Label
End Class
