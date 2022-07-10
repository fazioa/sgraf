Public Class FPreferenze


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        '    ErrorProvider1.Container.Add(TextBox9)
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub TextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox9.Validating, TextBox17.Validating, TextBox16.Validating, TextBox15.Validating, TextBox11.Validating, TextBox14.Validating, TextBox13.Validating
        Dim tb As TextBox = sender
        If Not IsNumeric(tb.Text) Then
            ErrorProvider1.SetError(sender, "Inserire un numero")
        Else
            ErrorProvider1.SetError(sender, "")
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxTipoFascicolo.SelectedIndexChanged
        ' My.Settings.tipoFascicolo = DirectCast(ComboBoxTipoFascicolo.SelectedItem, String)
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox15.KeyPress, TextBox11.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class