Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Dim local_address As IPAddress = IPAddress.Parse("127.0.0.1")
    Dim server As New TcpListener(local_address, 81)

    Dim connection As New TcpClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerReceive.Interval = 100
        TimerReceive.Enabled = True
        TimerSend.Interval = 100
        TimerSend.Enabled = True
        TimerVerifyConnection.Interval = 100
        TimerVerifyConnection.Enabled = True

        server.Start()
    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        If server.Pending() = True Then
            connection = server.AcceptTcpClient()
        End If

        If connection.Connected Then
            Dim message_size As Integer = connection.Available

            If message_size > 0 Then
                Dim message_in_stream As NetworkStream = connection.GetStream()
                Dim buffer(5000) As Byte
                message_in_stream.Read(buffer, 0, message_size)

                Dim message_in As String = ""
                Dim i As Integer
                For i = 0 To message_size - 1
                    message_in = message_in + Chr(buffer(i))
                Next i

                TextBoxReceber.Text = message_in + vbCrLf + TextBoxReceber.Text

                Y0_Chk.Checked = Mid(message_in, 1, 1)
                Y1_Chk.Checked = Mid(message_in, 2, 1)
                Y2_Chk.Checked = Mid(message_in, 3, 1)
                velocidade_box.Text = Asc(Mid(message_in, 4, 1))
            End If
        End If
    End Sub

    Private Sub TimerVerifyConnection_Tick(sender As Object, e As EventArgs) Handles TimerVerifyConnection.Tick
        estado_ligacao_box.Text = connection.Connected


    End Sub

    Private Sub TimerSend_Tick(sender As Object, e As EventArgs) Handles TimerSend.Tick
        If connection.Connected = True Then
            Dim buffer(5) As Byte
            buffer(0) = X0_Chk.CheckState + 48
            buffer(1) = X1_Chk.CheckState + 48
            buffer(2) = X2_Chk.CheckState + 48
            buffer(3) = X3_Chk.CheckState + 48
            buffer(4) = CInt(velocidade_lida_box.Text)

            Dim message_out_stream As NetworkStream
            message_out_stream = connection.GetStream()
            Try
                message_out_stream.Write(buffer, 0, 5)
            Catch ex As Exception
                connection.Close()
                connection = New Sockets.TcpClient
            End Try
        End If
    End Sub

    Private Sub Desligar_Btn_Click(sender As Object, e As EventArgs) Handles Desligar_Btn.Click
        connection.Close()
        connection = New Sockets.TcpClient
    End Sub
End Class
