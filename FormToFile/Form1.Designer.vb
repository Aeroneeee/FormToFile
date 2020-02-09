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
        Me.components = New System.ComponentModel.Container()
        Me.nametxtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.agetxtbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addresstxtbox = New System.Windows.Forms.TextBox()
        Me.Txt = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Xml = New System.Windows.Forms.PictureBox()
        Me.Json = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.Txt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Xml, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Json, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nametxtbox
        '
        Me.nametxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nametxtbox.Location = New System.Drawing.Point(26, 96)
        Me.nametxtbox.Name = "nametxtbox"
        Me.nametxtbox.Size = New System.Drawing.Size(273, 30)
        Me.nametxtbox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Provicali", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NAME"
        '
        'closeBtn
        '
        Me.closeBtn.AutoSize = True
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeBtn.Font = New System.Drawing.Font("Comfortaa", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Location = New System.Drawing.Point(266, 412)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(39, 17)
        Me.closeBtn.TabIndex = 2
        Me.closeBtn.Text = "Close"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Provicali", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "AGE"
        '
        'agetxtbox
        '
        Me.agetxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agetxtbox.Location = New System.Drawing.Point(26, 169)
        Me.agetxtbox.MaxLength = 3
        Me.agetxtbox.Name = "agetxtbox"
        Me.agetxtbox.Size = New System.Drawing.Size(273, 30)
        Me.agetxtbox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Provicali", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ADDRESS"
        '
        'addresstxtbox
        '
        Me.addresstxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addresstxtbox.Location = New System.Drawing.Point(26, 243)
        Me.addresstxtbox.Name = "addresstxtbox"
        Me.addresstxtbox.Size = New System.Drawing.Size(273, 30)
        Me.addresstxtbox.TabIndex = 5
        '
        'Txt
        '
        Me.Txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt.Image = Global.FormToFile.My.Resources.Resources.txt
        Me.Txt.Location = New System.Drawing.Point(26, 300)
        Me.Txt.Name = "Txt"
        Me.Txt.Size = New System.Drawing.Size(70, 85)
        Me.Txt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Txt.TabIndex = 8
        Me.Txt.TabStop = False
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
        Me.Xml.Location = New System.Drawing.Point(126, 300)
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
        Me.Json.Location = New System.Drawing.Point(228, 300)
        Me.Json.Name = "Json"
        Me.Json.Size = New System.Drawing.Size(70, 85)
        Me.Json.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Json.TabIndex = 10
        Me.Json.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Keep Calm Med", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProvider1.SetIconAlignment(Me.Label5, System.Windows.Forms.ErrorIconAlignment.TopLeft)
        Me.Label5.Location = New System.Drawing.Point(20, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 37)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CREATE A FILE"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        Me.Controls.Add(Me.Txt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.addresstxtbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.agetxtbox)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nametxtbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.SystemColors.ButtonFace
        CType(Me.Txt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Xml, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Json, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nametxtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents closeBtn As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents agetxtbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents addresstxtbox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Txt As PictureBox
    Friend WithEvents Xml As PictureBox
    Friend WithEvents Json As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
