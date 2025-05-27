<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        BtnPrint = New Button()
        Button3 = New Button()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        BtnViewData = New Button()
        GroupBox2 = New GroupBox()
        ParkingTable = New DataGridView()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(ParkingTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(BtnPrint)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(BtnViewData)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(361, 679)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "ACTIONS"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(41, 248)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 41)
        Label1.TabIndex = 2
        Label1.Text = "Pro Parking Vehicle"
        ' 
        ' BtnPrint
        ' 
        BtnPrint.Location = New Point(4, 517)
        BtnPrint.Name = "BtnPrint"
        BtnPrint.Size = New Size(347, 50)
        BtnPrint.TabIndex = 3
        BtnPrint.Text = "Print Receipt"
        BtnPrint.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(5, 461)
        Button3.Name = "Button3"
        Button3.Size = New Size(347, 50)
        Button3.TabIndex = 2
        Button3.Text = "Edit Data"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(5, 405)
        Button2.Name = "Button2"
        Button2.Size = New Size(347, 50)
        Button2.TabIndex = 1
        Button2.Text = "Delete Data"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(41, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(270, 194)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' BtnViewData
        ' 
        BtnViewData.Location = New Point(6, 344)
        BtnViewData.Name = "BtnViewData"
        BtnViewData.Size = New Size(347, 50)
        BtnViewData.TabIndex = 0
        BtnViewData.Text = "View Data"
        BtnViewData.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ParkingTable)
        GroupBox2.Location = New Point(379, 21)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(878, 670)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "VEHICLE INFO"
        ' 
        ' ParkingTable
        ' 
        ParkingTable.AllowUserToAddRows = False
        ParkingTable.AllowUserToDeleteRows = False
        ParkingTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ParkingTable.Location = New Point(24, 35)
        ParkingTable.Name = "ParkingTable"
        ParkingTable.ReadOnly = True
        ParkingTable.RowHeadersWidth = 51
        ParkingTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ParkingTable.Size = New Size(827, 612)
        ParkingTable.TabIndex = 0
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1269, 703)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pro Vehicle Parking"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(ParkingTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnViewData As Button
    Friend WithEvents ParkingTable As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog

End Class
