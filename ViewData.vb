Public Class ViewData
    Dim id As Integer
    Dim action As String
    Dim table As DataGridView
    Private Sub ViewData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (action.Equals("view")) Then
            BtnUpdate.Visible = False
            BtnDelete.Visible = False
        End If

    End Sub

    Public Sub New(table As DataGridView, action As String, id As Integer, clientName As String, email As String, contact As String, vehicleNo As String, category As String, vehicleName As String, parkingNo As String, status As String, timeIn As String, timeOut As String, charge As String)

        InitializeComponent()

        Me.action = action
        Me.id = id
        TxtInvoice.Text = id
        TxtClient.Text = clientName
        TxtEmail.Text = email
        TxtContact.Text = contact
        TxtRegNo.Text = vehicleNo
        TxtCatagory.Text = category
        TxtVehicleName.Text = vehicleName
        TxtParkingNo.Text = parkingNo
        TxtStatus.Text = status
        TxtTimeIn.Text = timeIn
        TxtTimeOut.Text = timeOut

        Me.table = table
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim query As String = "DELETE FROM vehicle_info WHERE VinfoID = @VinfoID"
        Dim parameters As New Dictionary(Of String, Object) From {{"@VinfoID", id}}
        DeleteData(query, parameters)

        Dim ParkingTableQuery As String = "SELECT * FROM vehicle_info"
        GetData(ParkingTableQuery, table)

        Me.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim newStatus As String = TxtStatus.Text
        Dim registeredNumber As String = TxtRegNo.Text
        Dim category As String = TxtCatagory.Text
        Dim vehicleName As String = TxtVehicleName.Text
        Dim parkingNo As String = TxtParkingNo.Text

        Dim query As String = $"UPDATE vehicle_info SET Status = @status, RegisteredNumber = @RegisteredNumber, VehicleCategory = @VehicleCategory, VehicleCompanyName = @VehicleCompanyName, ParkingNumber = @ParkingNumber WHERE VinfoID = @VinfoID"
        Dim parameters As New Dictionary(Of String, Object) From {{"@VinfoID", id}, {"@status", newStatus}, {"@RegisteredNumber", registeredNumber}, {"@VehicleCategory", category}, {"@VehicleCompanyName", vehicleName}, {"@ParkingNumber", parkingNo}}
        UpdateData(query, parameters)

        Dim ParkingTableQuery As String = "SELECT * FROM vehicle_info "
        GetData(ParkingTableQuery, table)

        Me.Close()
    End Sub
End Class