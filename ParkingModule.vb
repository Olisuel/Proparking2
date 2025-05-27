Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto

Module ParkingModule

    Public Sub GetData(query As String, table As DataGridView)
        Using connection As MySqlConnection = GetConnection()
            Try
                connection.Open()
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                table.DataSource = dataTable

                CustomizeHeaders(table)
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Function GetSpecificColumn(query As String, columnName As String) As String
        Dim result As String = String.Empty

        Using connection As MySqlConnection = GetConnection()
            Try
                connection.Open()

                Dim command As New MySqlCommand(query, connection)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            result = reader(columnName).ToString()
                        End While
                    End If
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return result
    End Function

    Private Sub CustomizeHeaders(table As DataGridView)
        For Each column As DataGridViewColumn In table.Columns
            Select Case column.Name
                Case "VinfoID"
                    column.HeaderText = "INFO ID"
                Case "ParkingNumber"
                    column.HeaderText = "Parking Number"
                Case "VehicleCategory"
                    column.HeaderText = "Vehicle Category"
                Case "VehicleCompanyName"
                    column.HeaderText = "Vehicle Company Name"
                Case "RegisteredNumber"
                    column.HeaderText = "Registered Number"
                Case "OwnerName"
                    column.HeaderText = "Owner Name"
                Case "OwnerContactNumber"
                    column.HeaderText = "Owner Contact Number"
                Case "InTime"
                    column.HeaderText = "Time In"
                Case "OutTime"
                    column.HeaderText = "Time Out"
                Case "ParkingCharge"
                    column.HeaderText = "Parking Charge"
                Case "Remark"
                    column.HeaderText = "Time Out"
                Case "Status"
                    column.HeaderText = "Status"

            End Select
        Next
    End Sub

    Public Sub DeleteData(query As String, parameters As Dictionary(Of String, Object))
        Using connection As MySqlConnection = GetConnection()
            Try
                Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If confirmation = DialogResult.Yes Then
                    connection.Open()

                    Dim command As New MySqlCommand(query, connection)
                    For Each param In parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No record was deleted. Please check the query.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Public Sub UpdateData(query As String, parameters As Dictionary(Of String, Object))
        Using connection As MySqlConnection = GetConnection()
            Try
                connection.Open()

                Dim command As New MySqlCommand(query, connection)
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then

                    For Each param In parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No record was updated. Please check your query.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Update canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Module
