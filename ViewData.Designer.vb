<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewData
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
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        BtnDelete = New Button()
        BtnUpdate = New Button()
        TxtStatus = New TextBox()
        Label11 = New Label()
        TxtParkingNo = New TextBox()
        Label10 = New Label()
        TxtVehicleName = New TextBox()
        Label7 = New Label()
        TxtCatagory = New TextBox()
        Label8 = New Label()
        TxtRegNo = New TextBox()
        Label9 = New Label()
        TxtEmail = New TextBox()
        Label4 = New Label()
        TxtContact = New TextBox()
        Label5 = New Label()
        TxtClient = New TextBox()
        Label6 = New Label()
        TxtTimeOut = New TextBox()
        Label3 = New Label()
        TxtTimeIn = New TextBox()
        Label2 = New Label()
        TxtInvoice = New TextBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(TxtEmail)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TxtContact)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TxtClient)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TxtTimeOut)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TxtTimeIn)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TxtInvoice)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1050, 474)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "DETAILS"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(BtnDelete)
        GroupBox2.Controls.Add(BtnUpdate)
        GroupBox2.Controls.Add(TxtStatus)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(TxtParkingNo)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(TxtVehicleName)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(TxtCatagory)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(TxtRegNo)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Location = New Point(19, 143)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1016, 310)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "VEHICLE INFO"
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(805, 245)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(191, 49)
        BtnDelete.TabIndex = 23
        BtnDelete.Text = "DELETE"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(608, 245)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(191, 49)
        BtnUpdate.TabIndex = 22
        BtnUpdate.Text = "UPDATE"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' TxtStatus
        ' 
        TxtStatus.Location = New Point(819, 43)
        TxtStatus.Name = "TxtStatus"
        TxtStatus.Size = New Size(161, 27)
        TxtStatus.TabIndex = 21
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(655, 46)
        Label11.Name = "Label11"
        Label11.Size = New Size(49, 20)
        Label11.TabIndex = 20
        Label11.Text = "Status"
        ' 
        ' TxtParkingNo
        ' 
        TxtParkingNo.Location = New Point(187, 142)
        TxtParkingNo.Name = "TxtParkingNo"
        TxtParkingNo.Size = New Size(161, 27)
        TxtParkingNo.TabIndex = 19
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(23, 145)
        Label10.Name = "Label10"
        Label10.Size = New Size(84, 20)
        Label10.TabIndex = 18
        Label10.Text = "Parking No."
        ' 
        ' TxtVehicleName
        ' 
        TxtVehicleName.Location = New Point(187, 109)
        TxtVehicleName.Name = "TxtVehicleName"
        TxtVehicleName.Size = New Size(161, 27)
        TxtVehicleName.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(23, 112)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 20)
        Label7.TabIndex = 16
        Label7.Text = "Vehicle Name"
        ' 
        ' TxtCatagory
        ' 
        TxtCatagory.Location = New Point(187, 76)
        TxtCatagory.Name = "TxtCatagory"
        TxtCatagory.Size = New Size(161, 27)
        TxtCatagory.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(23, 79)
        Label8.Name = "Label8"
        Label8.Size = New Size(120, 20)
        Label8.TabIndex = 14
        Label8.Text = "Vehicle Category"
        ' 
        ' TxtRegNo
        ' 
        TxtRegNo.Location = New Point(187, 43)
        TxtRegNo.Name = "TxtRegNo"
        TxtRegNo.Size = New Size(161, 27)
        TxtRegNo.TabIndex = 13
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(23, 46)
        Label9.Name = "Label9"
        Label9.Size = New Size(158, 20)
        Label9.TabIndex = 12
        Label9.Text = "Vehicle Registered No."
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Enabled = False
        TxtEmail.Location = New Point(108, 95)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(259, 27)
        TxtEmail.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 98)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 20)
        Label4.TabIndex = 10
        Label4.Text = "EMAIL"
        ' 
        ' TxtContact
        ' 
        TxtContact.Enabled = False
        TxtContact.Location = New Point(108, 62)
        TxtContact.Name = "TxtContact"
        TxtContact.Size = New Size(259, 27)
        TxtContact.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(11, 65)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 20)
        Label5.TabIndex = 8
        Label5.Text = "CONTACT"
        ' 
        ' TxtClient
        ' 
        TxtClient.Enabled = False
        TxtClient.Location = New Point(119, 26)
        TxtClient.Name = "TxtClient"
        TxtClient.Size = New Size(248, 27)
        TxtClient.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(11, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 20)
        Label6.TabIndex = 6
        Label6.Text = "CLIENT NAME"
        ' 
        ' TxtTimeOut
        ' 
        TxtTimeOut.Enabled = False
        TxtTimeOut.Location = New Point(792, 91)
        TxtTimeOut.Name = "TxtTimeOut"
        TxtTimeOut.Size = New Size(243, 27)
        TxtTimeOut.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(695, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 20)
        Label3.TabIndex = 4
        Label3.Text = "TIME OUT"
        ' 
        ' TxtTimeIn
        ' 
        TxtTimeIn.Enabled = False
        TxtTimeIn.Location = New Point(792, 58)
        TxtTimeIn.Name = "TxtTimeIn"
        TxtTimeIn.Size = New Size(243, 27)
        TxtTimeIn.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(695, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 20)
        Label2.TabIndex = 2
        Label2.Text = "TIME IN"
        ' 
        ' TxtInvoice
        ' 
        TxtInvoice.Enabled = False
        TxtInvoice.Location = New Point(874, 26)
        TxtInvoice.Name = "TxtInvoice"
        TxtInvoice.Size = New Size(161, 27)
        TxtInvoice.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(777, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 0
        Label1.Text = "INVOICE NO"
        ' 
        ' ViewData
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1074, 500)
        Controls.Add(GroupBox1)
        Name = "ViewData"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Data"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtContact As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtClient As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTimeOut As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTimeIn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtInvoice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtVehicleName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCatagory As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtRegNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtParkingNo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents TxtStatus As TextBox
    Friend WithEvents Label11 As Label
End Class
