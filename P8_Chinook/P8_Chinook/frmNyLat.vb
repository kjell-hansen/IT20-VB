Public Class frmNyLat
    Private Sub frmNyLat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Töm textboxar
        txtNamn.Text = ""
        txtKompositor.Text = ""
        txtLangd.Text = ""
        txtPris.Text = ""
        txtStorlek.Text = ""

        ' Fyll comboboxar
        cboGenre.DataSource = hamtaData("select * from genres order by name")
        cboGenre.DisplayMember = "name"
        cboGenre.ValueMember = "genreid"

        cboMediatyp.DataSource = hamtaData("select * from media_types order by name")
        cboMediatyp.DisplayMember = "name"
        cboMediatyp.ValueMember = "mediatypeid"

        ' Släck spara-knappen
        btnSpara.Enabled = False
    End Sub

    Private Sub txtLangd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLangd.KeyPress, txtStorlek.KeyPress
        ' Tillåt bara siffror
        If (e.KeyChar < "0"c OrElse e.KeyChar > "9"c) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPris_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPris.KeyPress
        ' Tillåt bara en punkt
        If e.KeyChar = "."c AndAlso InStr(sender.text, ".") > 0 Then
            e.Handled = True
        End If

        ' Tillåt bara siffror och punkt
        If (e.KeyChar < "0"c OrElse e.KeyChar > "9"c) AndAlso e.KeyChar <> vbBack AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtNamn_TextChanged(sender As Object, e As EventArgs) Handles txtNamn.TextChanged, txtKompositor.TextChanged, txtLangd.TextChanged, txtPris.TextChanged, txtStorlek.TextChanged
        If txtNamn.Text = "" OrElse txtLangd.Text = "" OrElse txtPris.Text = "" OrElse txtStorlek.Text = "" OrElse txtKompositor.Text = "" Then
            btnSpara.Enabled = False
        Else
            btnSpara.Enabled = True
        End If
    End Sub

    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnAvbryt_Click(sender As Object, e As EventArgs) Handles btnAvbryt.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class