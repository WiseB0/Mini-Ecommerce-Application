


Public Class frmWiseWorks

    Dim pl1 As Integer = 37
    Dim pl2 As Integer = 37






    Private Sub frmWiseWorks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

               
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If pl1 > 240 Then

            Timer1.Stop()
        Else

            Me.PanelDDMen.Size = New Size(Me.PanelDDMen.Size.Width, pl1)
            pl1 += 10
        End If






    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If pl2 > 240 Then

            Timer2.Stop()
        Else

            Me.PanelDDWomen.Size = New Size(Me.PanelDDWomen.Size.Width, pl2)
            pl2 += 10

        End If


    End Sub

    Private Sub BtnMen_MouseHover(sender As Object, e As EventArgs) Handles BtnMen.MouseHover


        Me.PanelDDWomen.Size = New Size(Me.PanelDDWomen.Size.Width, pl1)
        Me.PanelDDMen.Size = New Size(Me.PanelDDMen.Size.Width, pl2)
        Timer1.Start()

    End Sub
    Private Sub BtnWomen_MouseHover(sender As Object, e As EventArgs) Handles BtnWomen.MouseHover
        Me.PanelDDMen.Size = New Size(Me.PanelDDMen.Size.Width, pl2)
        Me.PanelDDWomen.Size = New Size(Me.PanelDDWomen.Size.Width, pl1)
        Timer2.Start()

    End Sub


    Private Sub BtnMen_MouseLeave(sender As Object, e As EventArgs) Handles BtnMen.MouseLeave
        Timer1.Stop()
        pl1 = 37
    End Sub
    Private Sub BtnWomen_MouseLeave(sender As Object, e As EventArgs) Handles BtnWomen.MouseLeave
        Timer2.Stop()
        pl2 = 37

    End Sub




    '--------------------------------------------------------------------------------------------------------------'

    ' Mens category buttons Shoes and Clothing
    Private Sub BtnShoes_Click(sender As Object, e As EventArgs) Handles BtnShoes.Click
        PicBoxNike1.Visible = True
        PicBoxNike2.Visible = True

        PicBoxJordan1.Visible = True
        PicBoxJordan2.Visible = True

        PicBoxAdidas1.Visible = True
        PicBoxAdidas2.Visible = True

        btnMenAdidas1.Visible = True
        btnMenJordan1.Visible = True
        btnMenNike1.Visible = True

        lblMenAdidas.Visible = True
        lblMenJordan.Visible = True
        lblMenNike.Visible = True

        PicBoxCart.Visible = True

        lblTotalAmount.Visible = True

        btnCheckout.Visible = True
        btnRemove.Visible = True
        btnClearAll.Visible = True
        ListBox1.Visible = True

        PictureBox1.Visible = False
        lblCopyright.Visible = False

        PicBoxNikeBackPack1.Visible = False
        PicBoxNikeBackPack2.Visible = False
        PicBoxFannyPack1.Visible = False
        PicBoxFannyPack2.Visible = False
        PicBoxNikeSocks1.Visible = False
        PicBoxNikeSocks2.Visible = False

        btnNikeFannyPack.Visible = False
        btnNikeBackPack.Visible = False
        btnNikeSocks.Visible = False

        lblNikeFannyPack.Visible = False
        lblNikeBackPack.Visible = False
        lblNikeSocks.Visible = False










        PicBoxWomenJordanShoes1.Visible = False
        PicBoxFannyPack2.Visible = False
        PicBoxWomenAdidasShoes1.Visible = False
        PicBoxWomenAdidasShoes2.Visible = False
        PicBoxWomenNikeShoes1.Visible = False
        PicBoxWomenNikeShoes2.Visible = False

        lblWomenAdidasShoes.Visible = False
        lblWomenJordanShoes.Visible = False
        lblWomenNikeShoes.Visible = False

        btnWomenShoesNike.Visible = False
        btnWomenShoesAdidas.Visible = False
        btnWomenJordanShoes.Visible = False



        PicBoxNikeCloth1.Visible = False
        PicBoxNikeCloth2.Visible = False
        lblMenNikeCloth.Visible = False

        PicBoxAdidasCloth1.Visible = False
        PicBoxAdidasCloth2.Visible = False
        lblMenAdidasCloth.Visible = False

        PicBoxJordanCloth.Visible = False
        PicBoxJordanCloth2.Visible = False
        lblMenJordanCloth.Visible = False


        PicBoxAdidasWomenCloth1.Visible = False
        PicBoxAdidasWomenCloth2.Visible = False

        PicBoxWomenNikeCloth1.Visible = False
        PicBoxWomenNikeCloth2.Visible = False

        PicBoxWomenPumaCloth1.Visible = False
        PicBoxWomenPumaCloth2.Visible = False

        btnWomenAdidas.Visible = False
        btnWomenPuma.Visible = False
        btnWomenNike.Visible = False

        lblWomenAdidasCloth.Visible = False
        lblWomenNikeCloth.Visible = False
        lblWomenPumaCloth.Visible = False


    End Sub
    Private Sub BtnClothing_Click(sender As Object, e As EventArgs) Handles BtnClothing.Click

        PicBoxCart.Visible = True
        lblTotalAmount.Visible = True
        btnCheckout.Visible = True
        btnRemove.Visible = True
        btnClearAll.Visible = True
        ListBox1.Visible = True

        PictureBox1.Visible = False

        PicBoxNikeCloth1.Visible = True
        PicBoxNikeCloth2.Visible = True
        lblMenNikeCloth.Visible = True


        PicBoxAdidasCloth1.Visible = True
        PicBoxAdidasCloth2.Visible = True
        lblMenAdidasCloth.Visible = True


        PicBoxJordanCloth.Visible = True
        PicBoxJordanCloth2.Visible = True
        lblMenJordanCloth.Visible = True

        lblCopyright.Visible = False

        PicBoxNikeBackPack1.Visible = False
        PicBoxNikeBackPack2.Visible = False
        PicBoxFannyPack1.Visible = False
        PicBoxFannyPack2.Visible = False
        PicBoxNikeSocks1.Visible = False
        PicBoxNikeSocks2.Visible = False

        btnNikeFannyPack.Visible = False
        btnNikeBackPack.Visible = False
        btnNikeSocks.Visible = False

        lblNikeFannyPack.Visible = False
        lblNikeBackPack.Visible = False
        lblNikeSocks.Visible = False








        PicBoxWomenJordanShoes1.Visible = False
        PicBoxFannyPack2.Visible = False
        PicBoxWomenAdidasShoes1.Visible = False
        PicBoxWomenAdidasShoes2.Visible = False
        PicBoxWomenNikeShoes1.Visible = False
        PicBoxWomenNikeShoes2.Visible = False

        lblWomenAdidasShoes.Visible = False
        lblWomenJordanShoes.Visible = False
        lblWomenNikeShoes.Visible = False

        btnWomenShoesNike.Visible = False
        btnWomenShoesAdidas.Visible = False
        btnWomenJordanShoes.Visible = False



        PicBoxNike1.Visible = False
        PicBoxNike2.Visible = False

        PicBoxJordan1.Visible = False
        PicBoxJordan2.Visible = False

        PicBoxAdidas1.Visible = False
        PicBoxAdidas2.Visible = False

        btnMenAdidas1.Visible = False
        btnMenJordan1.Visible = False
        btnMenNike1.Visible = False

        lblMenAdidas.Visible = False
        lblMenJordan.Visible = False
        lblMenNike.Visible = False

        btnNikeCloth.Visible = True
        btnAdidasCloth.Visible = True
        btnJordanCloth.Visible = True

        PicBoxAdidasWomenCloth1.Visible = False
        PicBoxAdidasWomenCloth2.Visible = False

        PicBoxWomenNikeCloth1.Visible = False
        PicBoxWomenNikeCloth2.Visible = False

        PicBoxWomenPumaCloth1.Visible = False
        PicBoxWomenPumaCloth2.Visible = False

        btnWomenAdidas.Visible = False
        btnWomenPuma.Visible = False
        btnWomenNike.Visible = False

        lblWomenAdidasCloth.Visible = False
        lblWomenNikeCloth.Visible = False
        lblWomenPumaCloth.Visible = False


    End Sub

    ' Mens Shoes Add to cart buttons
    Private Sub BtnMenNike1_Click(sender As Object, e As EventArgs) Handles btnMenNike1.Click




        Dim btnMenNike1 As Double = 190.0

        ListBox1.Items.Add(lblMenNike.Text)

        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")






    End Sub
    Private Sub BtnMenAdidas1_Click(sender As Object, e As EventArgs) Handles btnMenAdidas1.Click




        Dim btnMenNike1 As Double = 55.0

        ListBox1.Items.Add(lblMenAdidas.Text)

        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")





    End Sub
    Private Sub BtnMenJordan1_Click(sender As Object, e As EventArgs) Handles btnMenJordan1.Click

        Dim btnMenNike1 As Double = 200.0

        ListBox1.Items.Add(lblMenJordan.Text)

        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")

    End Sub

    ' Mens Clothes Add to cart buttons
    Private Sub btnNikeCloth_Click(sender As Object, e As EventArgs) Handles btnNikeCloth.Click




        Dim btnMenNike1 As Double = 55.0

        ListBox1.Items.Add(lblMenNikeCloth.Text)

        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")




    End Sub
    Private Sub btnAdidasCloth_Click(sender As Object, e As EventArgs) Handles btnAdidasCloth.Click


        Dim btnMenNike1 As Double = 77.0

        ListBox1.Items.Add(lblMenAdidasCloth.Text)


        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")



    End Sub
    Private Sub btnJordanCloth_Click(sender As Object, e As EventArgs) Handles btnJordanCloth.Click


        Dim btnMenNike1 As Double = 88.0

        ListBox1.Items.Add(lblMenJordanCloth.Text)


        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")







    End Sub



    '---------------------------------------------------------------------------------------------------------------'


    'Women Clothes Add to cart buttons
    Private Sub btnWomenNike_Click(sender As Object, e As EventArgs) Handles btnWomenNike.Click



        Dim btnMenNike1 As Double = 120.0

        ListBox1.Items.Add(lblWomenNikeCloth.Text)


        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")


    End Sub
    Private Sub btnWomenAdidas_Click(sender As Object, e As EventArgs) Handles btnWomenAdidas.Click

        Dim btnMenNike1 As Double = 65.0

        ListBox1.Items.Add(lblWomenAdidasCloth.Text)

        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")







    End Sub
    Private Sub btnWomenPuma_Click(sender As Object, e As EventArgs) Handles btnWomenPuma.Click



        Dim btnMenNike1 As Double = 25.0

        ListBox1.Items.Add(lblWomenPumaCloth.Text)

        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")


    End Sub


    'Women Shoes Add to cart Buttons
    Private Sub btnWomenShoesNike_Click(sender As Object, e As EventArgs) Handles btnWomenShoesNike.Click



        Dim btnMenNike1 As Double = 190.0

        ListBox1.Items.Add(lblWomenNikeShoes.Text)

        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")


    End Sub
    Private Sub btnWomenShoesAdidas_Click(sender As Object, e As EventArgs) Handles btnWomenShoesAdidas.Click


        Dim btnMenNike1 As Double = 130.0


        ListBox1.Items.Add(lblWomenAdidasShoes.Text)

        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")

    End Sub
    Private Sub btnWomenJordanShoes_Click(sender As Object, e As EventArgs) Handles btnWomenJordanShoes.Click






        Dim btnMenNike1 As Double = 100.0


        ListBox1.Items.Add(lblWomenJordanShoes.Text)

        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")









    End Sub


    ' Womens category buttons Shoes and Clothing
    Private Sub BtnWomenClothes_Click(sender As Object, e As EventArgs) Handles BtnWomenClothes.Click

        PicBoxCart.Visible = True
        lblTotalAmount.Visible = True
        btnCheckout.Visible = True
        btnRemove.Visible = True
        btnClearAll.Visible = True
        ListBox1.Visible = True
        PictureBox1.Visible = False

        PicBoxAdidasWomenCloth1.Visible = True
        PicBoxAdidasWomenCloth2.Visible = True

        PicBoxWomenNikeCloth1.Visible = True
        PicBoxWomenNikeCloth2.Visible = True

        PicBoxWomenPumaCloth1.Visible = True
        PicBoxWomenPumaCloth2.Visible = True

        btnWomenAdidas.Visible = True
        btnWomenPuma.Visible = True
        btnWomenNike.Visible = True

        lblWomenAdidasCloth.Visible = True
        lblWomenNikeCloth.Visible = True
        lblWomenPumaCloth.Visible = True


        lblCopyright.Visible = False

        PicBoxNikeBackPack1.Visible = False
        PicBoxNikeBackPack2.Visible = False
        PicBoxFannyPack1.Visible = False
        PicBoxFannyPack2.Visible = False
        PicBoxNikeSocks1.Visible = False
        PicBoxNikeSocks2.Visible = False

        btnNikeFannyPack.Visible = False
        btnNikeBackPack.Visible = False
        btnNikeSocks.Visible = False

        lblNikeFannyPack.Visible = False
        lblNikeBackPack.Visible = False
        lblNikeSocks.Visible = False













        PicBoxWomenJordanShoes1.Visible = False
        PicBoxFannyPack2.Visible = False
        PicBoxWomenAdidasShoes1.Visible = False
        PicBoxWomenAdidasShoes2.Visible = False
        PicBoxWomenNikeShoes1.Visible = False
        PicBoxWomenNikeShoes2.Visible = False

        lblWomenAdidasShoes.Visible = False
        lblWomenJordanShoes.Visible = False
        lblWomenNikeShoes.Visible = False

        btnWomenShoesNike.Visible = False
        btnWomenShoesAdidas.Visible = False
        btnWomenJordanShoes.Visible = False




        PicBoxNikeCloth1.Visible = False
        PicBoxNikeCloth2.Visible = False
        lblMenNikeCloth.Visible = False



        PicBoxAdidasCloth1.Visible = False
        PicBoxAdidasCloth2.Visible = False
        lblMenAdidasCloth.Visible = False


        PicBoxJordanCloth.Visible = False
        PicBoxJordanCloth2.Visible = False
        lblMenJordanCloth.Visible = False




        PicBoxNike1.Visible = False
        PicBoxNike2.Visible = False

        PicBoxJordan1.Visible = False
        PicBoxJordan2.Visible = False

        PicBoxAdidas1.Visible = False
        PicBoxAdidas2.Visible = False

        btnMenAdidas1.Visible = False
        btnMenJordan1.Visible = False
        btnMenNike1.Visible = False

        lblMenAdidas.Visible = False
        lblMenJordan.Visible = False
        lblMenNike.Visible = False

        btnNikeCloth.Visible = False
        btnAdidasCloth.Visible = False
        btnJordanCloth.Visible = False






    End Sub
    Private Sub BtnWomenShoes_Click(sender As Object, e As EventArgs) Handles BtnWomenShoes.Click
        PicBoxCart.Visible = True
        lblTotalAmount.Visible = True
        btnCheckout.Visible = True
        btnRemove.Visible = True
        btnClearAll.Visible = True
        ListBox1.Visible = True

        PictureBox1.Visible = False

        PicBoxWomenJordanShoes1.Visible = True
        PicBoxFannyPack2.Visible = True
        PicBoxWomenAdidasShoes1.Visible = True
        PicBoxWomenAdidasShoes2.Visible = True
        PicBoxWomenNikeShoes1.Visible = True
        PicBoxWomenNikeShoes2.Visible = True

        btnWomenShoesNike.Visible = True
        btnWomenShoesAdidas.Visible = True
        btnWomenJordanShoes.Visible = True

        lblWomenAdidasShoes.Visible = True
        lblWomenJordanShoes.Visible = True
        lblWomenNikeShoes.Visible = True

        lblCopyright.Visible = False


        PicBoxNikeBackPack1.Visible = False
        PicBoxNikeBackPack2.Visible = False
        PicBoxFannyPack1.Visible = False
        PicBoxFannyPack2.Visible = False
        PicBoxNikeSocks1.Visible = False
        PicBoxNikeSocks2.Visible = False

        btnNikeFannyPack.Visible = False
        btnNikeBackPack.Visible = False
        btnNikeSocks.Visible = False

        lblNikeFannyPack.Visible = False
        lblNikeBackPack.Visible = False
        lblNikeSocks.Visible = False











        PicBoxNikeCloth1.Visible = False
        PicBoxNikeCloth2.Visible = False
        lblMenNikeCloth.Visible = False

        PicBoxAdidasCloth1.Visible = False
        PicBoxAdidasCloth2.Visible = False
        lblMenAdidasCloth.Visible = False

        PicBoxJordanCloth.Visible = False
        PicBoxJordanCloth2.Visible = False
        lblMenJordanCloth.Visible = False


        PicBoxAdidasWomenCloth1.Visible = False
        PicBoxAdidasWomenCloth2.Visible = False

        PicBoxWomenNikeCloth1.Visible = False
        PicBoxWomenNikeCloth2.Visible = False

        PicBoxWomenPumaCloth1.Visible = False
        PicBoxWomenPumaCloth2.Visible = False

        btnWomenAdidas.Visible = False
        btnWomenPuma.Visible = False
        btnWomenNike.Visible = False

        lblWomenAdidasCloth.Visible = False
        lblWomenNikeCloth.Visible = False
        lblWomenPumaCloth.Visible = False

        PicBoxNike1.Visible = False
        PicBoxNike2.Visible = False

        PicBoxJordan1.Visible = False
        PicBoxJordan2.Visible = False

        PicBoxAdidas1.Visible = False
        PicBoxAdidas2.Visible = False

        btnMenAdidas1.Visible = False
        btnMenJordan1.Visible = False
        btnMenNike1.Visible = False

        lblMenAdidas.Visible = False
        lblMenJordan.Visible = False
        lblMenNike.Visible = False

        btnJordanCloth.Visible = False
        btnAdidasCloth.Visible = False
        btnNikeCloth.Visible = False


    End Sub


    '---------------------------------------------------------------------------------------------------------------'


    ' Accessories Category
    Private Sub btnAccessories_Click(sender As Object, e As EventArgs) Handles btnAccessories.Click

        PictureBox1.Visible = False
        lblCopyright.Visible = False
        PicBoxCart.Visible = True
        lblTotalAmount.Visible = True
        btnCheckout.Visible = True
        btnRemove.Visible = True
        btnClearAll.Visible = True
        ListBox1.Visible = True


        PicBoxNikeBackPack1.Visible = True
        PicBoxNikeBackPack2.Visible = True
        PicBoxFannyPack1.Visible = True
        PicBoxFannyPack2.Visible = True
        PicBoxNikeSocks1.Visible = True
        PicBoxNikeSocks2.Visible = True

        btnNikeFannyPack.Visible = True
        btnNikeBackPack.Visible = True
        btnNikeSocks.Visible = True

        lblNikeFannyPack.Visible = True
        lblNikeBackPack.Visible = True
        lblNikeSocks.Visible = True




























        PicBoxWomenJordanShoes1.Visible = False
        PicBoxFannyPack2.Visible = False
        PicBoxWomenAdidasShoes1.Visible = False
        PicBoxWomenAdidasShoes2.Visible = False
        PicBoxWomenNikeShoes1.Visible = False
        PicBoxWomenNikeShoes2.Visible = False

        btnWomenShoesNike.Visible = False
        btnWomenShoesAdidas.Visible = False
        btnWomenJordanShoes.Visible = False

        lblWomenAdidasShoes.Visible = False
        lblWomenJordanShoes.Visible = False
        lblWomenNikeShoes.Visible = False















        PicBoxNikeCloth1.Visible = False
        PicBoxNikeCloth2.Visible = False
        lblMenNikeCloth.Visible = False

        PicBoxAdidasCloth1.Visible = False
        PicBoxAdidasCloth2.Visible = False
        lblMenAdidasCloth.Visible = False

        PicBoxJordanCloth.Visible = False
        PicBoxJordanCloth2.Visible = False
        lblMenJordanCloth.Visible = False


        PicBoxAdidasWomenCloth1.Visible = False
        PicBoxAdidasWomenCloth2.Visible = False

        PicBoxWomenNikeCloth1.Visible = False
        PicBoxWomenNikeCloth2.Visible = False

        PicBoxWomenPumaCloth1.Visible = False
        PicBoxWomenPumaCloth2.Visible = False

        btnWomenAdidas.Visible = False
        btnWomenPuma.Visible = False
        btnWomenNike.Visible = False

        lblWomenAdidasCloth.Visible = False
        lblWomenNikeCloth.Visible = False
        lblWomenPumaCloth.Visible = False

        PicBoxNike1.Visible = False
        PicBoxNike2.Visible = False

        PicBoxJordan1.Visible = False
        PicBoxJordan2.Visible = False

        PicBoxAdidas1.Visible = False
        PicBoxAdidas2.Visible = False

        btnMenAdidas1.Visible = False
        btnMenJordan1.Visible = False
        btnMenNike1.Visible = False

        lblMenAdidas.Visible = False
        lblMenJordan.Visible = False
        lblMenNike.Visible = False

        btnJordanCloth.Visible = False
        btnAdidasCloth.Visible = False
        btnNikeCloth.Visible = False


    End Sub

    'Accessories Add to Cart Button
    Private Sub btnNikeBackPack_Click(sender As Object, e As EventArgs) Handles btnNikeBackPack.Click


        Dim btnMenNike1 As Double = 35.0

        ListBox1.Items.Add(lblNikeBackPack.Text)

        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")

    End Sub
    Private Sub btnNikeSocks_Click(sender As Object, e As EventArgs) Handles btnNikeSocks.Click

        Dim btnMenNike1 As Double = 22.0

        ListBox1.Items.Add(lblNikeSocks.Text)


        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")

    End Sub
    Private Sub btnNikeFannyPack_Click_1(sender As Object, e As EventArgs) Handles btnNikeFannyPack.Click

        Dim btnMenNike1 As Double = 50.0

        ListBox1.Items.Add(lblNikeFannyPack.Text)


        lblTotalDollars.Text = Val(lblTotalDollars.Text) + Val(btnMenNike1).ToString("C")

    End Sub


    '---------------------------------------------------------------------------------------------------------------'

    ' Remove button from list
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex())



    End Sub

    ' Clear All Data in List Box
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click

        ListBox1.Items.Clear()
        lblTotalDollars.Text = " "





    End Sub

    'Checkout button
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click


        Dim ans As Integer

        ans = MsgBox("Thank you for shopping with us , Please check your E-mail for your order confirmation 

                                    Select cancel to exit program ", MsgBoxStyle.OkCancel, "WiseWorks")

        If ans = DialogResult.OK Then

        Else
            Application.Exit()
        End If



    End Sub


End Class









