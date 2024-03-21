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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BuyButton = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.TextBox()
        Me.ProductPictureBox = New System.Windows.Forms.PictureBox()
        Me.Dollars = New System.Windows.Forms.PictureBox()
        Me.Quarters = New System.Windows.Forms.PictureBox()
        Me.Dimes = New System.Windows.Forms.PictureBox()
        Me.Nickles = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.ProductControl115 = New Vending_Machine.ProductControl1()
        Me.ProductControl114 = New Vending_Machine.ProductControl1()
        Me.ProductControl113 = New Vending_Machine.ProductControl1()
        Me.ProductControl112 = New Vending_Machine.ProductControl1()
        Me.ProductControl111 = New Vending_Machine.ProductControl1()
        Me.ProductControl110 = New Vending_Machine.ProductControl1()
        Me.ProductControl19 = New Vending_Machine.ProductControl1()
        Me.ProductControl18 = New Vending_Machine.ProductControl1()
        Me.ProductControl17 = New Vending_Machine.ProductControl1()
        Me.ProductControl16 = New Vending_Machine.ProductControl1()
        Me.ProductControl15 = New Vending_Machine.ProductControl1()
        Me.ProductControl14 = New Vending_Machine.ProductControl1()
        Me.ProductControl13 = New Vending_Machine.ProductControl1()
        Me.ProductControl11 = New Vending_Machine.ProductControl1()
        Me.ProductControl12 = New Vending_Machine.ProductControl1()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dollars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quarters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dimes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nickles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuyButton
        '
        Me.BuyButton.Location = New System.Drawing.Point(263, 404)
        Me.BuyButton.Name = "BuyButton"
        Me.BuyButton.Size = New System.Drawing.Size(75, 23)
        Me.BuyButton.TabIndex = 1
        Me.BuyButton.Text = "Buy"
        Me.BuyButton.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(263, 433)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 22)
        Me.Button6.TabIndex = 2
        '
        'ProductPictureBox
        '
        Me.ProductPictureBox.Location = New System.Drawing.Point(42, 421)
        Me.ProductPictureBox.Name = "ProductPictureBox"
        Me.ProductPictureBox.Size = New System.Drawing.Size(111, 105)
        Me.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductPictureBox.TabIndex = 18
        Me.ProductPictureBox.TabStop = False
        '
        'Dollars
        '
        Me.Dollars.Image = CType(resources.GetObject("Dollars.Image"), System.Drawing.Image)
        Me.Dollars.Location = New System.Drawing.Point(532, 12)
        Me.Dollars.Name = "Dollars"
        Me.Dollars.Size = New System.Drawing.Size(61, 49)
        Me.Dollars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dollars.TabIndex = 23
        Me.Dollars.TabStop = False
        '
        'Quarters
        '
        Me.Quarters.Image = CType(resources.GetObject("Quarters.Image"), System.Drawing.Image)
        Me.Quarters.Location = New System.Drawing.Point(599, 12)
        Me.Quarters.Name = "Quarters"
        Me.Quarters.Size = New System.Drawing.Size(60, 50)
        Me.Quarters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Quarters.TabIndex = 24
        Me.Quarters.TabStop = False
        '
        'Dimes
        '
        Me.Dimes.Image = CType(resources.GetObject("Dimes.Image"), System.Drawing.Image)
        Me.Dimes.Location = New System.Drawing.Point(665, 11)
        Me.Dimes.Name = "Dimes"
        Me.Dimes.Size = New System.Drawing.Size(61, 50)
        Me.Dimes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dimes.TabIndex = 25
        Me.Dimes.TabStop = False
        '
        'Nickles
        '
        Me.Nickles.Image = CType(resources.GetObject("Nickles.Image"), System.Drawing.Image)
        Me.Nickles.Location = New System.Drawing.Point(732, 12)
        Me.Nickles.Name = "Nickles"
        Me.Nickles.Size = New System.Drawing.Size(60, 50)
        Me.Nickles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Nickles.TabIndex = 26
        Me.Nickles.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(732, 78)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(60, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 30
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(665, 77)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(61, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 29
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(599, 78)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(60, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 28
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(532, 78)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(61, 49)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 27
        Me.PictureBox8.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(525, 145)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 23)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Dollars"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(592, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Quarter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(665, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 23)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Nickle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(743, 145)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 23)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Dimes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.BackColor = System.Drawing.Color.White
        Me.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalLabel.Location = New System.Drawing.Point(272, 472)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(50, 18)
        Me.TotalLabel.TabIndex = 35
        Me.TotalLabel.Text = "Label1"
        '
        'ProductControl115
        '
        Me.ProductControl115.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl115.Count = 5
        Me.ProductControl115.Location = New System.Drawing.Point(317, 261)
        Me.ProductControl115.Name = "ProductControl115"
        Me.ProductControl115.Picture = CType(resources.GetObject("ProductControl115.Picture"), System.Drawing.Image)
        Me.ProductControl115.Price = New Decimal(New Integer() {250, 0, 0, 131072})
        Me.ProductControl115.ProductID = "A14"
        Me.ProductControl115.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl115.TabIndex = 17
        '
        'ProductControl114
        '
        Me.ProductControl114.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl114.Count = 5
        Me.ProductControl114.Location = New System.Drawing.Point(420, 261)
        Me.ProductControl114.Name = "ProductControl114"
        Me.ProductControl114.Picture = CType(resources.GetObject("ProductControl114.Picture"), System.Drawing.Image)
        Me.ProductControl114.Price = New Decimal(New Integer() {250, 0, 0, 131072})
        Me.ProductControl114.ProductID = "A15"
        Me.ProductControl114.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl114.TabIndex = 16
        '
        'ProductControl113
        '
        Me.ProductControl113.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl113.Count = 5
        Me.ProductControl113.Location = New System.Drawing.Point(111, 261)
        Me.ProductControl113.Name = "ProductControl113"
        Me.ProductControl113.Picture = CType(resources.GetObject("ProductControl113.Picture"), System.Drawing.Image)
        Me.ProductControl113.Price = New Decimal(New Integer() {250, 0, 0, 131072})
        Me.ProductControl113.ProductID = "A12"
        Me.ProductControl113.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl113.TabIndex = 15
        '
        'ProductControl112
        '
        Me.ProductControl112.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl112.Count = 5
        Me.ProductControl112.Location = New System.Drawing.Point(214, 261)
        Me.ProductControl112.Name = "ProductControl112"
        Me.ProductControl112.Picture = CType(resources.GetObject("ProductControl112.Picture"), System.Drawing.Image)
        Me.ProductControl112.Price = New Decimal(New Integer() {250, 0, 0, 131072})
        Me.ProductControl112.ProductID = "A13"
        Me.ProductControl112.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl112.TabIndex = 14
        '
        'ProductControl111
        '
        Me.ProductControl111.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl111.Count = 5
        Me.ProductControl111.Location = New System.Drawing.Point(214, 135)
        Me.ProductControl111.Name = "ProductControl111"
        Me.ProductControl111.Picture = CType(resources.GetObject("ProductControl111.Picture"), System.Drawing.Image)
        Me.ProductControl111.Price = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl111.ProductID = "A8"
        Me.ProductControl111.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl111.TabIndex = 13
        '
        'ProductControl110
        '
        Me.ProductControl110.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl110.Count = 5
        Me.ProductControl110.Location = New System.Drawing.Point(317, 135)
        Me.ProductControl110.Name = "ProductControl110"
        Me.ProductControl110.Picture = CType(resources.GetObject("ProductControl110.Picture"), System.Drawing.Image)
        Me.ProductControl110.Price = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl110.ProductID = "A9"
        Me.ProductControl110.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl110.TabIndex = 12
        '
        'ProductControl19
        '
        Me.ProductControl19.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl19.Count = 0
        Me.ProductControl19.Location = New System.Drawing.Point(8, 261)
        Me.ProductControl19.Name = "ProductControl19"
        Me.ProductControl19.Picture = CType(resources.GetObject("ProductControl19.Picture"), System.Drawing.Image)
        Me.ProductControl19.Price = New Decimal(New Integer() {250, 0, 0, 131072})
        Me.ProductControl19.ProductID = "A11"
        Me.ProductControl19.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl19.TabIndex = 11
        '
        'ProductControl18
        '
        Me.ProductControl18.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl18.Count = 5
        Me.ProductControl18.Location = New System.Drawing.Point(420, 135)
        Me.ProductControl18.Name = "ProductControl18"
        Me.ProductControl18.Picture = CType(resources.GetObject("ProductControl18.Picture"), System.Drawing.Image)
        Me.ProductControl18.Price = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl18.ProductID = "A10"
        Me.ProductControl18.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl18.TabIndex = 10
        '
        'ProductControl17
        '
        Me.ProductControl17.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl17.Count = 5
        Me.ProductControl17.Location = New System.Drawing.Point(111, 9)
        Me.ProductControl17.Name = "ProductControl17"
        Me.ProductControl17.Picture = CType(resources.GetObject("ProductControl17.Picture"), System.Drawing.Image)
        Me.ProductControl17.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl17.ProductID = "A2"
        Me.ProductControl17.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl17.TabIndex = 9
        '
        'ProductControl16
        '
        Me.ProductControl16.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl16.Count = 5
        Me.ProductControl16.Location = New System.Drawing.Point(214, 9)
        Me.ProductControl16.Name = "ProductControl16"
        Me.ProductControl16.Picture = CType(resources.GetObject("ProductControl16.Picture"), System.Drawing.Image)
        Me.ProductControl16.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl16.ProductID = "A3"
        Me.ProductControl16.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl16.TabIndex = 8
        '
        'ProductControl15
        '
        Me.ProductControl15.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl15.Count = 5
        Me.ProductControl15.Location = New System.Drawing.Point(317, 9)
        Me.ProductControl15.Name = "ProductControl15"
        Me.ProductControl15.Picture = CType(resources.GetObject("ProductControl15.Picture"), System.Drawing.Image)
        Me.ProductControl15.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl15.ProductID = "A4"
        Me.ProductControl15.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl15.TabIndex = 7
        '
        'ProductControl14
        '
        Me.ProductControl14.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl14.Count = 5
        Me.ProductControl14.Location = New System.Drawing.Point(420, 9)
        Me.ProductControl14.Name = "ProductControl14"
        Me.ProductControl14.Picture = CType(resources.GetObject("ProductControl14.Picture"), System.Drawing.Image)
        Me.ProductControl14.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl14.ProductID = "A5"
        Me.ProductControl14.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl14.TabIndex = 6
        '
        'ProductControl13
        '
        Me.ProductControl13.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl13.Count = 5
        Me.ProductControl13.Location = New System.Drawing.Point(8, 135)
        Me.ProductControl13.Name = "ProductControl13"
        Me.ProductControl13.Picture = CType(resources.GetObject("ProductControl13.Picture"), System.Drawing.Image)
        Me.ProductControl13.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl13.ProductID = "A6"
        Me.ProductControl13.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl13.TabIndex = 5
        '
        'ProductControl11
        '
        Me.ProductControl11.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl11.Count = 5
        Me.ProductControl11.Location = New System.Drawing.Point(111, 135)
        Me.ProductControl11.Name = "ProductControl11"
        Me.ProductControl11.Picture = CType(resources.GetObject("ProductControl11.Picture"), System.Drawing.Image)
        Me.ProductControl11.Price = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl11.ProductID = "B2"
        Me.ProductControl11.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl11.TabIndex = 4
        '
        'ProductControl12
        '
        Me.ProductControl12.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductControl12.Count = 0
        Me.ProductControl12.Location = New System.Drawing.Point(8, 9)
        Me.ProductControl12.Name = "ProductControl12"
        Me.ProductControl12.Picture = CType(resources.GetObject("ProductControl12.Picture"), System.Drawing.Image)
        Me.ProductControl12.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl12.ProductID = "A1"
        Me.ProductControl12.Size = New System.Drawing.Size(88, 127)
        Me.ProductControl12.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(811, 568)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Nickles)
        Me.Controls.Add(Me.Dimes)
        Me.Controls.Add(Me.Quarters)
        Me.Controls.Add(Me.Dollars)
        Me.Controls.Add(Me.ProductPictureBox)
        Me.Controls.Add(Me.ProductControl115)
        Me.Controls.Add(Me.ProductControl114)
        Me.Controls.Add(Me.ProductControl113)
        Me.Controls.Add(Me.ProductControl112)
        Me.Controls.Add(Me.ProductControl111)
        Me.Controls.Add(Me.ProductControl110)
        Me.Controls.Add(Me.ProductControl19)
        Me.Controls.Add(Me.ProductControl18)
        Me.Controls.Add(Me.ProductControl17)
        Me.Controls.Add(Me.ProductControl16)
        Me.Controls.Add(Me.ProductControl15)
        Me.Controls.Add(Me.ProductControl14)
        Me.Controls.Add(Me.ProductControl13)
        Me.Controls.Add(Me.ProductControl11)
        Me.Controls.Add(Me.ProductControl12)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.BuyButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dollars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quarters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dimes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nickles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BuyButton As Button
    Friend WithEvents Button6 As TextBox
    Friend WithEvents ProductControl12 As ProductControl1
    Friend WithEvents ProductControl11 As ProductControl1
    Friend WithEvents ProductControl13 As ProductControl1
    Friend WithEvents ProductControl14 As ProductControl1
    Friend WithEvents ProductControl15 As ProductControl1
    Friend WithEvents ProductControl16 As ProductControl1
    Friend WithEvents ProductControl17 As ProductControl1
    Friend WithEvents ProductControl18 As ProductControl1
    Friend WithEvents ProductControl19 As ProductControl1
    Friend WithEvents ProductControl110 As ProductControl1
    Friend WithEvents ProductControl111 As ProductControl1
    Friend WithEvents ProductControl112 As ProductControl1
    Friend WithEvents ProductControl113 As ProductControl1
    Friend WithEvents ProductControl114 As ProductControl1
    Friend WithEvents ProductControl115 As ProductControl1
    Friend WithEvents ProductPictureBox As PictureBox
    Friend WithEvents Dollars As PictureBox
    Friend WithEvents Quarters As PictureBox
    Friend WithEvents Dimes As PictureBox
    Friend WithEvents Nickles As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TotalLabel As Label
End Class
