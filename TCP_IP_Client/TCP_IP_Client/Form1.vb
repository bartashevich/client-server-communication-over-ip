Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Dim ip_address As IPAddress = IPAddress.Parse("127.0.0.1")

    Dim client As New Sockets.TcpClient

    Private Sub LigarBtn_Click(sender As Object, e As EventArgs) Handles LigarBtn.Click
        client.Connect(ip_address, 81)
    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        estado_connecao_box.Text = client.Connected

        If client.Connected Then
            Dim message_size As Integer = client.Available

            If message_size > 0 Then
                Dim message_in_stream As NetworkStream = client.GetStream()
                Dim buffer(5000) As Byte
                message_in_stream.Read(buffer, 0, message_size)

                Dim message_in As String = ""
                Dim i As Integer
                For i = 0 To message_size - 1
                    message_in = message_in + Chr(buffer(i))
                Next i

                X0_Chk.Checked = Mid(message_in, 1, 1)
                X1_Chk.Checked = Mid(message_in, 2, 1)
                X2_Chk.Checked = Mid(message_in, 3, 1)
                X3_Chk.Checked = Mid(message_in, 4, 1)
                velocidade_lida_box.Text = Asc(Mid(message_in, 5, 1))
            End If
        End If
    End Sub

    Private Sub DesligarBtn_Click(sender As Object, e As EventArgs) Handles DesligarBtn.Click
        client.Close()
        client = New Sockets.TcpClient
    End Sub

    Private Sub enviar_checkboxes_Btn_Click(sender As Object, e As EventArgs) Handles enviar_checkboxes_Btn.Click
        If client.Connected = True Then
            Dim buffer(5) As Byte
            buffer(0) = Y0_Chk.CheckState + 48
            buffer(1) = Y1_Chk.CheckState + 48
            buffer(2) = Y2_Chk.CheckState + 48
            buffer(3) = CInt(velocidade_box.Text)

            Dim message_out_stream As NetworkStream
            message_out_stream = client.GetStream()
            Try
                message_out_stream.Write(buffer, 0, 4)
            Catch ex As Exception
                client.Close()
                client = New Sockets.TcpClient
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerReceive.Interval = 100
        TimerReceive.Enabled = True
    End Sub
End Class
