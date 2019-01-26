<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2048
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2048))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.lbl15 = New System.Windows.Forms.Label()
        Me.lbl16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblScoreMax = New System.Windows.Forms.Label()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaShell
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(43, 556)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Score"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblScore.Image = CType(resources.GetObject("lblScore.Image"), System.Drawing.Image)
        Me.lblScore.Location = New System.Drawing.Point(150, 556)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(163, 45)
        Me.lblScore.TabIndex = 5
        Me.lblScore.Text = "le score..."
        '
        'btnRestart
        '
        Me.btnRestart.BackColor = System.Drawing.Color.Transparent
        Me.btnRestart.BackgroundImage = CType(resources.GetObject("btnRestart.BackgroundImage"), System.Drawing.Image)
        Me.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRestart.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestart.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnRestart.Location = New System.Drawing.Point(32, 624)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(120, 48)
        Me.btnRestart.TabIndex = 6
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = False
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.Transparent
        Me.btnUndo.BackgroundImage = CType(resources.GetObject("btnUndo.BackgroundImage"), System.Drawing.Image)
        Me.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUndo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnUndo.Location = New System.Drawing.Point(350, 623)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(120, 48)
        Me.btnUndo.TabIndex = 7
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl1.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl1.Location = New System.Drawing.Point(87, 183)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(80, 80)
        Me.lbl1.TabIndex = 8
        Me.lbl1.Text = "2048"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl2.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl2.Location = New System.Drawing.Point(172, 183)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(80, 80)
        Me.lbl2.TabIndex = 9
        Me.lbl2.Text = "2048"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl3.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl3.Location = New System.Drawing.Point(258, 183)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(80, 80)
        Me.lbl3.TabIndex = 10
        Me.lbl3.Text = "2048"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl4
        '
        Me.lbl4.BackColor = System.Drawing.Color.Transparent
        Me.lbl4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl4.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl4.Location = New System.Drawing.Point(344, 184)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(80, 80)
        Me.lbl4.TabIndex = 11
        Me.lbl4.Text = "2048"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.Color.Transparent
        Me.lbl5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl5.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl5.Location = New System.Drawing.Point(87, 266)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(80, 80)
        Me.lbl5.TabIndex = 12
        Me.lbl5.Text = "2048"
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6
        '
        Me.lbl6.BackColor = System.Drawing.Color.Transparent
        Me.lbl6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl6.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl6.Location = New System.Drawing.Point(172, 266)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(80, 80)
        Me.lbl6.TabIndex = 13
        Me.lbl6.Text = "2048"
        Me.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl7
        '
        Me.lbl7.BackColor = System.Drawing.Color.Transparent
        Me.lbl7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl7.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl7.Location = New System.Drawing.Point(258, 265)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(80, 80)
        Me.lbl7.TabIndex = 14
        Me.lbl7.Text = "2048"
        Me.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl8
        '
        Me.lbl8.BackColor = System.Drawing.Color.Transparent
        Me.lbl8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl8.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl8.Location = New System.Drawing.Point(344, 265)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(80, 80)
        Me.lbl8.TabIndex = 15
        Me.lbl8.Text = "2048"
        Me.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl9
        '
        Me.lbl9.BackColor = System.Drawing.Color.Transparent
        Me.lbl9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl9.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl9.Location = New System.Drawing.Point(87, 349)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(80, 80)
        Me.lbl9.TabIndex = 16
        Me.lbl9.Text = "2048"
        Me.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl10
        '
        Me.lbl10.BackColor = System.Drawing.Color.Transparent
        Me.lbl10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl10.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl10.Location = New System.Drawing.Point(173, 349)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(80, 80)
        Me.lbl10.TabIndex = 17
        Me.lbl10.Text = "2048"
        Me.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl11
        '
        Me.lbl11.BackColor = System.Drawing.Color.Transparent
        Me.lbl11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl11.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl11.Location = New System.Drawing.Point(257, 348)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(80, 80)
        Me.lbl11.TabIndex = 18
        Me.lbl11.Text = "2048"
        Me.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl12
        '
        Me.lbl12.BackColor = System.Drawing.Color.Transparent
        Me.lbl12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl12.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl12.Location = New System.Drawing.Point(343, 348)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(80, 80)
        Me.lbl12.TabIndex = 19
        Me.lbl12.Text = "2048"
        Me.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl13
        '
        Me.lbl13.BackColor = System.Drawing.Color.Transparent
        Me.lbl13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl13.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl13.Location = New System.Drawing.Point(87, 432)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(80, 80)
        Me.lbl13.TabIndex = 20
        Me.lbl13.Text = "2048"
        Me.lbl13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl14
        '
        Me.lbl14.BackColor = System.Drawing.Color.Transparent
        Me.lbl14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl14.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl14.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl14.Location = New System.Drawing.Point(172, 431)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(80, 80)
        Me.lbl14.TabIndex = 22
        Me.lbl14.Text = "2048"
        Me.lbl14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl15
        '
        Me.lbl15.BackColor = System.Drawing.Color.Transparent
        Me.lbl15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl15.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl15.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl15.Location = New System.Drawing.Point(257, 431)
        Me.lbl15.Name = "lbl15"
        Me.lbl15.Size = New System.Drawing.Size(80, 80)
        Me.lbl15.TabIndex = 23
        Me.lbl15.Text = "2048"
        Me.lbl15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl16
        '
        Me.lbl16.BackColor = System.Drawing.Color.Transparent
        Me.lbl16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl16.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl16.ForeColor = System.Drawing.SystemColors.Info
        Me.lbl16.Location = New System.Drawing.Point(344, 431)
        Me.lbl16.Name = "lbl16"
        Me.lbl16.Size = New System.Drawing.Size(80, 80)
        Me.lbl16.TabIndex = 24
        Me.lbl16.Text = "2048"
        Me.lbl16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(256, 556)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 45)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Best"
        '
        'lblScoreMax
        '
        Me.lblScoreMax.AutoSize = True
        Me.lblScoreMax.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreMax.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreMax.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblScoreMax.Image = CType(resources.GetObject("lblScoreMax.Image"), System.Drawing.Image)
        Me.lblScoreMax.Location = New System.Drawing.Point(341, 556)
        Me.lblScoreMax.Name = "lblScoreMax"
        Me.lblScoreMax.Size = New System.Drawing.Size(163, 45)
        Me.lblScoreMax.TabIndex = 26
        Me.lblScoreMax.Text = "le score..."
        '
        'btnDown
        '
        Me.btnDown.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDown.Location = New System.Drawing.Point(256, 5)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(54, 30)
        Me.btnDown.TabIndex = 3
        Me.btnDown.Text = "Down"
        Me.btnDown.UseVisualStyleBackColor = True
        Me.btnDown.Visible = False
        '
        'btnRight
        '
        Me.btnRight.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRight.Location = New System.Drawing.Point(316, 5)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(54, 30)
        Me.btnRight.TabIndex = 1
        Me.btnRight.Text = "Right"
        Me.btnRight.UseVisualStyleBackColor = True
        Me.btnRight.Visible = False
        '
        'btnLeft
        '
        Me.btnLeft.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLeft.Location = New System.Drawing.Point(137, 5)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(54, 30)
        Me.btnLeft.TabIndex = 0
        Me.btnLeft.Text = "Left"
        Me.btnLeft.UseVisualStyleBackColor = True
        Me.btnLeft.Visible = False
        '
        'btnUp
        '
        Me.btnUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnUp.Location = New System.Drawing.Point(197, 5)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(54, 30)
        Me.btnUp.TabIndex = 2
        Me.btnUp.Text = "Up"
        Me.btnUp.UseVisualStyleBackColor = True
        Me.btnUp.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(32, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 25)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(57, 126)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 25)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(85, 126)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 25)
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'Form2048
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(508, 695)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblScoreMax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.lbl16)
        Me.Controls.Add(Me.lbl15)
        Me.Controls.Add(Me.lbl14)
        Me.Controls.Add(Me.lbl13)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.lbl8)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(524, 734)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(524, 734)
        Me.Name = "Form2048"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeu du 2048"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lbl13 As System.Windows.Forms.Label
    Friend WithEvents lbl14 As System.Windows.Forms.Label
    Friend WithEvents lbl15 As System.Windows.Forms.Label
    Friend WithEvents lbl16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblScoreMax As System.Windows.Forms.Label
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class
