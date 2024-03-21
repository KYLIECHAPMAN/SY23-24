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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Nickles = New System.Windows.Forms.PictureBox()
        Me.Dimes = New System.Windows.Forms.PictureBox()
        Me.Quarters = New System.Windows.Forms.PictureBox()
        Me.Dollars = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.ReelControl3 = New Slot_Machine.ReelControl()
        Me.ReelControl2 = New Slot_Machine.ReelControl()
        Me.ReelControl1 = New Slot_Machine.ReelControl()
        CType(Me.Nickles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dimes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quarters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dollars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(59, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Nickles
        '
        Me.Nickles.Image = CType(resources.GetObject("Nickles.Image"), System.Drawing.Image)
        Me.Nickles.Location = New System.Drawing.Point(208, 13)
        Me.Nickles.Name = "Nickles"
        Me.Nickles.Size = New System.Drawing.Size(60, 50)
        Me.Nickles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Nickles.TabIndex = 30
        Me.Nickles.TabStop = False
        '
        'Dimes
        '
        Me.Dimes.Image = CType(resources.GetObject("Dimes.Image"), System.Drawing.Image)
        Me.Dimes.Location = New System.Drawing.Point(141, 12)
        Me.Dimes.Name = "Dimes"
        Me.Dimes.Size = New System.Drawing.Size(61, 50)
        Me.Dimes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dimes.TabIndex = 29
        Me.Dimes.TabStop = False
        '
        'Quarters
        '
        Me.Quarters.Image = CType(resources.GetObject("Quarters.Image"), System.Drawing.Image)
        Me.Quarters.Location = New System.Drawing.Point(75, 13)
        Me.Quarters.Name = "Quarters"
        Me.Quarters.Size = New System.Drawing.Size(60, 50)
        Me.Quarters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Quarters.TabIndex = 28
        Me.Quarters.TabStop = False
        '
        'Dollars
        '
        Me.Dollars.Image = CType(resources.GetObject("Dollars.Image"), System.Drawing.Image)
        Me.Dollars.Location = New System.Drawing.Point(8, 13)
        Me.Dollars.Name = "Dollars"
        Me.Dollars.Size = New System.Drawing.Size(61, 49)
        Me.Dollars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Dollars.TabIndex = 27
        Me.Dollars.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(407, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(593, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Label3"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(303, 36)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(48, 16)
        Me.TotalLabel.TabIndex = 34
        Me.TotalLabel.Text = "Label4"
        '
        'ReelControl3
        '
        Me.ReelControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReelControl3.itemvalue = 0
        Me.ReelControl3.Location = New System.Drawing.Point(544, 150)
        Me.ReelControl3.Name = "ReelControl3"
        Me.ReelControl3.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl3.spintime = 2000
        Me.ReelControl3.TabIndex = 3
        '
        'ReelControl2
        '
        Me.ReelControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReelControl2.itemvalue = 0
        Me.ReelControl2.Location = New System.Drawing.Point(359, 150)
        Me.ReelControl2.Name = "ReelControl2"
        Me.ReelControl2.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl2.spintime = 2000
        Me.ReelControl2.TabIndex = 2
        '
        'ReelControl1
        '
        Me.ReelControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReelControl1.itemvalue = 0
        Me.ReelControl1.Location = New System.Drawing.Point(176, 150)
        Me.ReelControl1.Name = "ReelControl1"
        Me.ReelControl1.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl1.spintime = 2000
        Me.ReelControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nickles)
        Me.Controls.Add(Me.Dimes)
        Me.Controls.Add(Me.Quarters)
        Me.Controls.Add(Me.Dollars)
        Me.Controls.Add(Me.ReelControl3)
        Me.Controls.Add(Me.ReelControl2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReelControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Nickles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dimes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quarters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dollars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReelControl1 As ReelControl
    Friend WithEvents Button1 As Button
    Friend WithEvents ReelControl2 As ReelControl
    Friend WithEvents ReelControl3 As ReelControl
    Friend WithEvents Nickles As PictureBox
    Friend WithEvents Dimes As PictureBox
    Friend WithEvents Quarters As PictureBox
    Friend WithEvents Dollars As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalLabel As Label
End Class
