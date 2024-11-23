<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKaraoke
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
        Panel1 = New Panel()
        lblDisplayCost = New Label()
        btnClear = New Button()
        btnCost = New Button()
        txtRental = New TextBox()
        lblRental = New Label()
        cboKaraoke = New ComboBox()
        lblHeading = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(lblDisplayCost)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnCost)
        Panel1.Controls.Add(txtRental)
        Panel1.Controls.Add(lblRental)
        Panel1.Controls.Add(cboKaraoke)
        Panel1.Controls.Add(lblHeading)
        Panel1.Dock = DockStyle.Right
        Panel1.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(380, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(420, 450)
        Panel1.TabIndex = 0
        ' 
        ' lblDisplayCost
        ' 
        lblDisplayCost.AutoSize = True
        lblDisplayCost.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDisplayCost.Location = New Point(67, 394)
        lblDisplayCost.Name = "lblDisplayCost"
        lblDisplayCost.Size = New Size(63, 19)
        lblDisplayCost.TabIndex = 6
        lblDisplayCost.Text = "Label1"
        lblDisplayCost.Visible = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.White
        btnClear.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        btnClear.ForeColor = Color.Black
        btnClear.Location = New Point(225, 303)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(128, 38)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear Form"
        btnClear.UseVisualStyleBackColor = False
        btnClear.Visible = False
        ' 
        ' btnCost
        ' 
        btnCost.BackColor = Color.White
        btnCost.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        btnCost.ForeColor = Color.Black
        btnCost.Location = New Point(67, 303)
        btnCost.Name = "btnCost"
        btnCost.Size = New Size(128, 38)
        btnCost.TabIndex = 4
        btnCost.Text = "Total Cost"
        btnCost.UseVisualStyleBackColor = False
        btnCost.Visible = False
        ' 
        ' txtRental
        ' 
        txtRental.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        txtRental.Location = New Point(188, 197)
        txtRental.Name = "txtRental"
        txtRental.Size = New Size(45, 27)
        txtRental.TabIndex = 3
        txtRental.TextAlign = HorizontalAlignment.Center
        txtRental.Visible = False
        ' 
        ' lblRental
        ' 
        lblRental.AutoSize = True
        lblRental.Font = New Font("Tahoma", 12F, FontStyle.Bold)
        lblRental.Location = New Point(106, 158)
        lblRental.Name = "lblRental"
        lblRental.Size = New Size(63, 19)
        lblRental.TabIndex = 2
        lblRental.Text = "Label2"
        lblRental.Visible = False
        ' 
        ' cboKaraoke
        ' 
        cboKaraoke.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboKaraoke.FormattingEnabled = True
        cboKaraoke.Items.AddRange(New Object() {"Hours in Open Microphone ($2.99 per song)", "Hours in Private Karaoke Booth ($8.99 per hour)"})
        cboKaraoke.Location = New Point(17, 70)
        cboKaraoke.Name = "cboKaraoke"
        cboKaraoke.Size = New Size(387, 26)
        cboKaraoke.TabIndex = 1
        cboKaraoke.Text = "Select an Option:"
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(63, 18)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(294, 33)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Karaoke Music Night"
        ' 
        ' frmKaraoke
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.karaoke
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "frmKaraoke"
        Text = "Karaoke Music Night"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblHeading As Label
    Friend WithEvents cboKaraoke As ComboBox
    Friend WithEvents lblRental As Label
    Friend WithEvents txtRental As TextBox
    Friend WithEvents lblDisplayCost As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCost As Button

End Class
