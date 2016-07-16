Public Class FPreferenze


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ErrorProvider1.Container.Add(TextBox1)
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
End Class