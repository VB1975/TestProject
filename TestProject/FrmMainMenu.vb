Public Class FrmMainMenu

    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim MainImage As Bitmap = My.Resources.ResourceManager.GetObject("Visual_Studio_Logo")
        PicMainImage.Image = MainImage

        PicMainImage.Image = My.Resources.Visual_Studio_Logo

        PicMainImage.Image = My.Resources.ResourceManager.GetObject("Visual_Studio_Logo")

        PicMainImage.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Images\Visual-Studio-Logo.png")

        PicMainImage.Load(AppDomain.CurrentDomain.BaseDirectory & "Images\Visual-Studio-Logo.png")

    End Sub

    Private Sub OpenForm(NewForm As Form)

        Dim frm As Form = NewForm
        frm.BringToFront()
        frm.Show()

    End Sub


    Private Sub BtnDatesAndTimes_Click(sender As Object, e As EventArgs) Handles BtnDatesAndTimes.Click

        Dim frm As New FrmDatesAndTimes
        OpenForm(frm)

    End Sub

    Private Sub BtnStrings_Click(sender As Object, e As EventArgs) Handles BtnStrings.Click

        Dim frm As New FrmStrings
        OpenForm(frm)

    End Sub

    Private Sub BtnLooping_Click(sender As Object, e As EventArgs) Handles BtnLooping.Click

        Dim frm As New FrmLooping
        OpenForm(frm)

    End Sub

    Private Sub BtnComboBoxesAndListBoxes_Click(sender As Object, e As EventArgs) Handles BtnComboBoxesAndListBoxes.Click

        Dim frm As New FrmComboBoxesAndListBoxes
        OpenForm(frm)

    End Sub

    Private Sub BtnWorkingWithColors_Click(sender As Object, e As EventArgs) Handles BtnWorkingWithColors.Click

        Dim frm As New FrmColors
        OpenForm(frm)

    End Sub

    Private Sub BtnWorkingWithGraphics_Click(sender As Object, e As EventArgs) Handles BtnWorkingWithGraphics.Click

        Dim frm As New FrmGraphics
        OpenForm(frm)

    End Sub
End Class
