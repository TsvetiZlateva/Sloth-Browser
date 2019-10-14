Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlothBrowser.ScriptErrorsSuppressed = True
    End Sub

    Sub checkAdress() Handles SlothBrowser.DocumentCompleted
        txbAdress.Text = SlothBrowser.Url.ToString
    End Sub

    Private Sub tmrStatus_Tick(sender As Object, e As EventArgs) Handles tmrStatus.Tick
        Label1.Text = SlothBrowser.StatusText.ToString
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        If SlothBrowser.CanGoBack Then
            SlothBrowser.GoBack()
        End If
    End Sub

    Private Sub Forward_Click(sender As Object, e As EventArgs) Handles Forward.Click
        If SlothBrowser.CanGoForward Then
            SlothBrowser.GoForward()
        End If
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        SlothBrowser.Refresh()
    End Sub

    Private Sub GO_Click(sender As Object, e As EventArgs) Handles GO.Click
        SlothBrowser.Navigate(txbAdress.Text)
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        If My.Settings.SE = "Google" Then
            SlothBrowser.Navigate(My.Settings.Google + txbSearch.Text)

        ElseIf My.Settings.SE = "Bing" Then
            SlothBrowser.Navigate(My.Settings.Bing + txbSearch.Text)

        ElseIf My.Settings.SE = "Yahoo" Then
            SlothBrowser.Navigate(My.Settings.Yahoo + txbSearch.Text)
        End If
    End Sub

    Private Sub txbSearch_TextChanged(sender As Object, e As EventArgs) Handles txbSearch.Click
        If txbSearch.Text = "Search..." Then
            txbSearch.Text = ""
        End If
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        Form2.Show()
    End Sub
End Class
