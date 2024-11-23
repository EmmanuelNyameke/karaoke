' Program Name: Karaoke Music Night
' Date: November 19, 2024
' Author: K Bola
' Purpose: This application computes either the customized evening cost of an open microphone costing $2.99 per hour or renting a private karaoke room for $8.99 per hour.
Public Class frmKaraoke
    Const _cdecCostPerSong As Decimal = 2.99D
    Const _cdecHourPerRoom As Decimal = 8.99D
    Private Sub cboKaraoke_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKaraoke.SelectedIndexChanged
        Dim intKaraokeSelection As Integer = cboKaraoke.SelectedIndex
        Select Case intKaraokeSelection
            Case 0
                ' Making items visible
                lblRental.Visible = True
                lblRental.Text = "Number of Karaoke Song(s): "
                txtRental.Visible = True
                btnCost.Visible = True
                btnClear.Visible = True
                lblDisplayCost.Visible = True
                lblDisplayCost.Text = ""
            Case 1
                ' Making items visible
                lblRental.Visible = True
                lblRental.Text = "Number of Rental Hour(s): "
                txtRental.Visible = True
                btnCost.Visible = True
                btnClear.Visible = True
                lblDisplayCost.Visible = True
                lblDisplayCost.Text = ""
        End Select
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim intNumberInput As Integer
        Dim intKaraokeSelected As Integer
        ValidateNumber(intNumberInput)
        ValidateKaraoke(intKaraokeSelected)
    End Sub
    Private Sub ValidateNumber(ByVal intNumberEntered As Integer)
        Dim blnValidityCheck As Boolean
        Dim strNumberEntered As String = txtRental.Text
        Try
            If (IsNumeric(strNumberEntered)) Then
                intNumberEntered = Convert.ToInt32(strNumberEntered)
                If (intNumberEntered < 0) Then
                    MsgBox("Enter a positive number", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Negative Value")
                    lblDisplayCost.Text = ""
                    txtRental.Clear()
                    txtRental.Focus()
                End If
            Else
                MsgBox("Enter a Value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Input")
                txtRental.Clear()
                txtRental.Focus()
            End If
            blnValidityCheck = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "")
        End Try
    End Sub
    Private Function ValidateKaraoke(ByVal intKaraokeSelected As Integer) As Decimal
        intKaraokeSelected = cboKaraoke.SelectedIndex
        Try
            If (intKaraokeSelected = 0) Then
                OpenMicSongCost()
            Else
                PrivateRoomCost()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error")
        End Try
        Return intKaraokeSelected
    End Function
    Private Function OpenMicSongCost() As Decimal
        Dim intNumberInput As Integer = Convert.ToInt32(txtRental.Text)
        Dim intKaraokeSelected As Integer
        Dim decTotalCost As Decimal
        intKaraokeSelected = cboKaraoke.SelectedIndex
        Try
            If (intKaraokeSelected = 0) Then
                decTotalCost = intNumberInput * _cdecCostPerSong
                lblDisplayCost.Text = "Total Cost per Song - " & decTotalCost.ToString("C")
            Else
                MsgBox("Select an Option", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Option")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error")
        End Try
        Return decTotalCost
    End Function
    Private Function PrivateRoomCost() As Decimal
        Dim intNumberInput As Integer = Convert.ToInt32(txtRental.Text)
        Dim intKaraokeSelected As Integer
        Dim decTotalCost As Decimal
        intKaraokeSelected = cboKaraoke.SelectedIndex
        Try
            If (intKaraokeSelected = 1) Then
                decTotalCost = intNumberInput * _cdecHourPerRoom
                lblDisplayCost.Text = "Total Night Cost - " & decTotalCost.ToString("C")
            Else
                MsgBox("Select an Option", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Option")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error")
        End Try
        Return decTotalCost
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Making items invisible
        cboKaraoke.Text = "Select an Option"
        lblRental.Visible = False
        lblRental.Text = ""
        txtRental.Visible = False
        btnCost.Visible = False
        btnClear.Visible = False
        lblDisplayCost.Visible = False
        lblDisplayCost.Text = ""
    End Sub

    Private Sub frmKaraoke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(3000)
    End Sub
End Class
