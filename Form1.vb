Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto
Public Class Form1
    Private receiptItems As New List(Of String)
    Private totalAmount As Decimal = 0
    Dim timeIn As String
    Dim timeOut As String
    Dim invoiceNo As String
    Dim clientName As String
    Dim vehicle As String
    Dim contact As String
    Dim email As String
    Dim vehicleNo As String
    Dim category As String
    Dim vehicleName As String
    Dim parkingNo As String
    Dim status As String
    Dim charge As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT * FROM vehicle_info"
        GetData(query, ParkingTable)
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If ParkingTable.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = ParkingTable.SelectedRows(0)
            invoiceNo = selectedRow.Cells("VinfoID").Value.ToString() ' Generate invoice number
            clientName = selectedRow.Cells("OwnerName").Value.ToString()
            contact = selectedRow.Cells("OwnerContactNumber").Value.ToString()
            vehicleNo = selectedRow.Cells("RegisteredNumber").Value.ToString()

            Dim query As String = $"SELECT email FROM client WHERE UserName = '{clientName}'"
            Dim columnName As String = "email"
            Dim getEmail As String = GetSpecificColumn(query, columnName)
            email = getEmail

            category = selectedRow.Cells("VehicleCategory").Value.ToString()
            vehicleName = selectedRow.Cells("VehicleCompanyName").Value.ToString()
            parkingNo = selectedRow.Cells("ParkingNumber").Value.ToString()
            status = selectedRow.Cells("Status").Value.ToString()
            timeIn = selectedRow.Cells("InTime").Value.ToString()
            timeOut = selectedRow.Cells("OutTime").Value.ToString()

            charge = selectedRow.Cells("ParkingCharge").Value.ToString()

            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Else
            MessageBox.Show("No row selected.")
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim paperSize As New PaperSize("Custom", 827, 1169)
        e.PageSettings.PaperSize = paperSize

        e.PageSettings.Margins = New Margins(50, 50, 50, 50)

        Dim fontRegular As New Font("Arial", 12, FontStyle.Regular)
        Dim fontBold As New Font("Arial", 14, FontStyle.Bold)
        Dim fontTitle As New Font("Arial", 16, FontStyle.Bold)
        Dim brush As Brush = Brushes.Black

        Dim logo As Image = My.Resources.receipt_logo

        Dim x As Integer = 50
        Dim y As Integer = 50
        Dim lineSpacing As Integer = 20

        Dim logoWidth As Integer = 50
        Dim logoHeight As Integer = 50
        e.Graphics.DrawImage(logo, (x + 10), y, logoWidth, logoHeight)

        y += (logoHeight / 4)
        x += logoWidth + 10
        e.Graphics.DrawString("Proparking", fontTitle, brush, (x + 10), y)

        x -= logoWidth
        y += (lineSpacing + (logoHeight - 10))
        e.Graphics.DrawString("Proparking", fontRegular, brush, x, y)
        y += lineSpacing
        e.Graphics.DrawString("proparking.com", fontRegular, brush, x, y)
        y += lineSpacing
        e.Graphics.DrawString("Kasiglahan Village Rodriguez, Rizal", fontRegular, brush, x, y)
        y += lineSpacing
        e.Graphics.DrawString("proparking@gmail.com", fontRegular, brush, x, y)

        ' Invoice number and Time details
        y += lineSpacing * 2
        e.Graphics.DrawString("INVOICE #" + invoiceNo, fontBold, brush, 530, 60)
        e.Graphics.DrawString("Time In: " + timeIn, fontRegular, brush, 530, 80)
        e.Graphics.DrawString("Time Out: " + timeOut, fontRegular, brush, 530, 100)

        ' Divider
        y += lineSpacing * 2
        e.Graphics.DrawLine(Pens.Black, x, y, 750, y)
        y += lineSpacing

        ' Customer Information Section
        e.Graphics.DrawString("Invoice To:", fontBold, brush, x, y)
        y += (lineSpacing + 5)
        e.Graphics.DrawString(clientName, fontRegular, brush, x, y)
        y += lineSpacing
        e.Graphics.DrawString("Small Heath, B10 0HF, UK", fontRegular, brush, x, y)
        y += lineSpacing
        e.Graphics.DrawString(contact, fontRegular, brush, x, y)
        y += lineSpacing
        e.Graphics.DrawString(email, fontRegular, brush, x, y)

        ' Item Table
        y += lineSpacing * 2
        e.Graphics.DrawString("ITEM", fontBold, brush, x, y)
        e.Graphics.DrawString("DESCRIPTION", fontBold, brush, 400, y)
        y += (lineSpacing + 5)
        e.Graphics.DrawLine(Pens.Black, x, y, 750, y)
        y += lineSpacing

        e.Graphics.DrawString("Vehicle Registered No.", fontRegular, brush, x, y)
        e.Graphics.DrawString(vehicleNo, fontRegular, brush, 400, y)
        y += lineSpacing
        e.Graphics.DrawString("Vehicle Category", fontRegular, brush, x, y)
        e.Graphics.DrawString(category, fontRegular, brush, 400, y)
        y += lineSpacing
        e.Graphics.DrawString("Vehicle Name", fontRegular, brush, x, y)
        e.Graphics.DrawString(vehicleName, fontRegular, brush, 400, y)
        y += lineSpacing
        e.Graphics.DrawString("Parking No.", fontRegular, brush, x, y)
        e.Graphics.DrawString(parkingNo, fontRegular, brush, 400, y)
        y += lineSpacing
        e.Graphics.DrawString("Status", fontRegular, brush, x, y)
        e.Graphics.DrawString(status, fontRegular, brush, 400, y)

        ' Salesperson Section
        y += lineSpacing * 2
        e.Graphics.DrawString("Salesperson: Mark Bernante", fontRegular, brush, x, y)
        y += lineSpacing
        e.Graphics.DrawString("Thanks for your business", fontRegular, brush, x, y)

        ' Footer Section
        y += lineSpacing * 2
        e.Graphics.DrawString("Remark: PAID", fontBold, brush, 400, y)
        e.Graphics.DrawString("Total: ₱" + charge, fontBold, brush, 600, y)
        y += lineSpacing * 2

        e.Graphics.DrawLine(Pens.Black, x, y, 750, y)
        y += lineSpacing
        e.Graphics.DrawString("Note: It was a pleasure working with you and your team. We hope you will keep us in mind" + Environment.NewLine + "for future freelance projects. Thank you", fontRegular, brush, x, y)
    End Sub

    Private Sub BtnViewData_Click(sender As Object, e As EventArgs) Handles BtnViewData.Click
        If ParkingTable.SelectedRows.Count > 0 Then
            ViewDataColumns("view")
        Else
            MessageBox.Show("No row selected.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ParkingTable.SelectedRows.Count > 0 Then
            ViewDataColumns("edit")
        Else
            MessageBox.Show("No row selected.")
        End If
    End Sub

    Public Sub ViewDataColumns(action As String)
        Dim selectedRow As DataGridViewRow = ParkingTable.SelectedRows(0)
        invoiceNo = selectedRow.Cells("VinfoID").Value.ToString() ' Generate invoice number
        clientName = selectedRow.Cells("OwnerName").Value.ToString()
        contact = selectedRow.Cells("OwnerContactNumber").Value.ToString()
        vehicleNo = selectedRow.Cells("RegisteredNumber").Value.ToString()

        Dim query As String = $"SELECT email FROM client WHERE UserName = '{clientName}'"
        Dim columnName As String = "email"
        Dim getEmail As String = GetSpecificColumn(query, columnName)
        email = getEmail

        category = selectedRow.Cells("VehicleCategory").Value.ToString()
        vehicleName = selectedRow.Cells("VehicleCompanyName").Value.ToString()
        parkingNo = selectedRow.Cells("ParkingNumber").Value.ToString()
        status = selectedRow.Cells("Status").Value.ToString()
        timeIn = selectedRow.Cells("InTime").Value.ToString()
        timeOut = selectedRow.Cells("OutTime").Value.ToString()

        charge = selectedRow.Cells("ParkingCharge").Value.ToString()


        Dim viewData As New ViewData(ParkingTable, action, invoiceNo, clientName, email, contact, vehicleNo, category, vehicleName, parkingNo, status, timeIn, timeOut, charge)
        viewData.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ParkingTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = ParkingTable.SelectedRows(0)
            invoiceNo = selectedRow.Cells("VinfoID").Value.ToString()

            Dim query As String = "DELETE FROM vehicle_info WHERE VinfoID = @VinfoID"
            Dim parameters As New Dictionary(Of String, Object) From {{"@VinfoID", invoiceNo}}

            DeleteData(query, parameters)
            Dim getDataQuery As String = "SELECT * FROM vehicle_info"
            GetData(getDataQuery, ParkingTable)
        Else
            MessageBox.Show("No row selected.")
        End If
    End Sub

    Public Sub GetDataDashboard()
        Dim query As String = "SELECT * FROM vehicle_info"
        GetData(query, ParkingTable)
    End Sub
End Class
