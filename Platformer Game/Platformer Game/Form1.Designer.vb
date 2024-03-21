<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2DPlatFormer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2DPlatFormer))
        Me.PicPlayer = New System.Windows.Forms.PictureBox()
        Me.PicAir = New System.Windows.Forms.PictureBox()
        Me.PicGround = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PurpleFlowerPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PinkFlowerPictureBox = New System.Windows.Forms.PictureBox()
        Me.SunFlowerPictureBox = New System.Windows.Forms.PictureBox()
        Me.BlueFlowerPictureBox = New System.Windows.Forms.PictureBox()
        Me.Mover1 = New Platformer_Game.Mover()
        Me.Mover2 = New Platformer_Game.Mover()
        Me.Mover3 = New Platformer_Game.Mover()
        Me.Mover4 = New Platformer_Game.Mover()
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurpleFlowerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinkFlowerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SunFlowerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueFlowerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicPlayer
        '
        Me.PicPlayer.BackColor = System.Drawing.Color.Transparent
        Me.PicPlayer.Image = CType(resources.GetObject("PicPlayer.Image"), System.Drawing.Image)
        Me.PicPlayer.Location = New System.Drawing.Point(23, 381)
        Me.PicPlayer.Name = "PicPlayer"
        Me.PicPlayer.Size = New System.Drawing.Size(72, 56)
        Me.PicPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPlayer.TabIndex = 0
        Me.PicPlayer.TabStop = False
        '
        'PicAir
        '
        Me.PicAir.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PicAir.Location = New System.Drawing.Point(12, 12)
        Me.PicAir.Name = "PicAir"
        Me.PicAir.Size = New System.Drawing.Size(797, 394)
        Me.PicAir.TabIndex = 1
        Me.PicAir.TabStop = False
        '
        'PicGround
        '
        Me.PicGround.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PicGround.Location = New System.Drawing.Point(12, 429)
        Me.PicGround.Name = "PicGround"
        Me.PicGround.Size = New System.Drawing.Size(799, 32)
        Me.PicGround.TabIndex = 2
        Me.PicGround.TabStop = False
        '
        'tmrRight
        '
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 10
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 20
        '
        'tmrGameLogic
        '
        '
        'tmrGravity
        '
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Green
        Me.PictureBox4.Location = New System.Drawing.Point(64, 108)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(210, 30)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Green
        Me.PictureBox2.Location = New System.Drawing.Point(534, 193)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(205, 32)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(29487, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 27)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'PurpleFlowerPictureBox
        '
        Me.PurpleFlowerPictureBox.Image = CType(resources.GetObject("PurpleFlowerPictureBox.Image"), System.Drawing.Image)
        Me.PurpleFlowerPictureBox.Location = New System.Drawing.Point(416, 75)
        Me.PurpleFlowerPictureBox.Name = "PurpleFlowerPictureBox"
        Me.PurpleFlowerPictureBox.Size = New System.Drawing.Size(82, 63)
        Me.PurpleFlowerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PurpleFlowerPictureBox.TabIndex = 10
        Me.PurpleFlowerPictureBox.TabStop = False
        Me.PurpleFlowerPictureBox.Tag = "win"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Green
        Me.PictureBox3.Location = New System.Drawing.Point(261, 279)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(268, 29)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(23, 193)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(48, 22)
        Me.TextBox1.TabIndex = 14
        '
        'PinkFlowerPictureBox
        '
        Me.PinkFlowerPictureBox.Image = CType(resources.GetObject("PinkFlowerPictureBox.Image"), System.Drawing.Image)
        Me.PinkFlowerPictureBox.Location = New System.Drawing.Point(371, 153)
        Me.PinkFlowerPictureBox.Name = "PinkFlowerPictureBox"
        Me.PinkFlowerPictureBox.Size = New System.Drawing.Size(73, 67)
        Me.PinkFlowerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PinkFlowerPictureBox.TabIndex = 15
        Me.PinkFlowerPictureBox.TabStop = False
        Me.PinkFlowerPictureBox.Tag = "win"
        Me.PinkFlowerPictureBox.UseWaitCursor = True
        '
        'SunFlowerPictureBox
        '
        Me.SunFlowerPictureBox.Image = CType(resources.GetObject("SunFlowerPictureBox.Image"), System.Drawing.Image)
        Me.SunFlowerPictureBox.Location = New System.Drawing.Point(677, 88)
        Me.SunFlowerPictureBox.Name = "SunFlowerPictureBox"
        Me.SunFlowerPictureBox.Size = New System.Drawing.Size(71, 60)
        Me.SunFlowerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SunFlowerPictureBox.TabIndex = 16
        Me.SunFlowerPictureBox.TabStop = False
        Me.SunFlowerPictureBox.Tag = "win"
        '
        'BlueFlowerPictureBox
        '
        Me.BlueFlowerPictureBox.Image = CType(resources.GetObject("BlueFlowerPictureBox.Image"), System.Drawing.Image)
        Me.BlueFlowerPictureBox.Location = New System.Drawing.Point(146, 274)
        Me.BlueFlowerPictureBox.Name = "BlueFlowerPictureBox"
        Me.BlueFlowerPictureBox.Size = New System.Drawing.Size(71, 62)
        Me.BlueFlowerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BlueFlowerPictureBox.TabIndex = 17
        Me.BlueFlowerPictureBox.TabStop = False
        Me.BlueFlowerPictureBox.Tag = "win"
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 500
        Me.Mover1.Location = New System.Drawing.Point(316, 65)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(98, 23)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.PurpleFlowerPictureBox
        Me.Mover1.TabIndex = 13
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Transparent
        Me.Mover2.interval = 500
        Me.Mover2.Location = New System.Drawing.Point(261, 158)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(128, 34)
        Me.Mover2.speed = 5
        Me.Mover2.sprite = Me.PinkFlowerPictureBox
        Me.Mover2.TabIndex = 18
        Me.Mover2.Tag = "win"
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.Transparent
        Me.Mover3.interval = 500
        Me.Mover3.Location = New System.Drawing.Point(121, 244)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(110, 29)
        Me.Mover3.speed = 5
        Me.Mover3.sprite = Me.BlueFlowerPictureBox
        Me.Mover3.TabIndex = 19
        Me.Mover3.Tag = "win"
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.Transparent
        Me.Mover4.interval = 500
        Me.Mover4.Location = New System.Drawing.Point(562, 88)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(112, 30)
        Me.Mover4.speed = 5
        Me.Mover4.sprite = Me.SunFlowerPictureBox
        Me.Mover4.TabIndex = 20
        Me.Mover4.Tag = "win"
        '
        'Form2DPlatFormer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(821, 467)
        Me.Controls.Add(Me.BlueFlowerPictureBox)
        Me.Controls.Add(Me.SunFlowerPictureBox)
        Me.Controls.Add(Me.PinkFlowerPictureBox)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PurpleFlowerPictureBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PicPlayer)
        Me.Controls.Add(Me.PicAir)
        Me.Controls.Add(Me.PicGround)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form2DPlatFormer"
        Me.Text = "Form1"
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurpleFlowerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinkFlowerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SunFlowerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueFlowerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicPlayer As PictureBox
    Friend WithEvents PicAir As PictureBox
    Friend WithEvents PicGround As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PurpleFlowerPictureBox As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Mover1 As Mover
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PinkFlowerPictureBox As PictureBox
    Friend WithEvents SunFlowerPictureBox As PictureBox
    Friend WithEvents BlueFlowerPictureBox As PictureBox
    Friend WithEvents Mover2 As Mover
    Friend WithEvents Mover3 As Mover
    Friend WithEvents Mover4 As Mover
End Class
