Dim tax, subTotal, total As Decimal

    Dim taxRate As Decimal = 0.08
    Dim priceSteak As Decimal = 29.99
    Dim priceRibs As Decimal = 21.99
    Dim pricePorkChops As Decimal = 14.99
    Dim priceBakedPotato As Decimal = 4.99
    Dim priceMac As Decimal = 3.49
    Dim priceSalad As Decimal = 4.49
    Dim priceExtraSeasoning As Decimal = 2.49
    Dim priceExtraSauce As Decimal = 2.49
    Dim priceRedInside As Decimal = 3.49
    Dim priceAged As Decimal = 3.49
    Dim priceSoda As Decimal = 2.99
    Dim priceIcedTea As Decimal = 1.99
    Dim priceWater As Decimal = 1.0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        initializeVariables()
        clearTheCustomerSelections()
        clearRecipt()

    End Sub

    Private Sub initializeVariables()

        subTotal = 0
        tax = 0
        total = 0

    End Sub

    Private Sub clearTheCustomerSelections()

        btnRibs.Checked = False
        btnSteak.Checked = False
        btnPorkChops.Checked = False
        btnPotato.Checked = False
        btnMac.Checked = False
        btnSalad.Checked = False
        btnExtraSeason.Checked = False
        btnExtraSauce.Checked = False
        btnRed.Checked = False
        btnAged.Checked = False
        btnSoda.Checked = False
        btnIcedTea.Checked = False
        btnWater.Checked = False
    End Sub

    Private Sub clearRecipt()

        listBoxDisplay.Items.Clear()
        listBoxTotal.Items.Clear()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        initializeVariables()
        clearTheCustomerSelections()
        clearRecipt()

    End Sub

    Private Sub btnCart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCart.Click

        computeCurrentSelection()
        updateTotal()
        clearTheCustomerSelections()

    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        Me.Close()

    End Sub

    Private Sub computeCurrentSelection()

        If btnRibs.Checked Then
            subTotal += priceRibs

            Dim ribsItem As String = priceRibs.ToString("C") & " Smoke House Prime Ribs"
            ListBoxDisplay.Items.Add(ribsItem)
        End If

        If btnSteak.Checked Then
            subTotal += priceSteak

            Dim steakItem As String = priceSteak.ToString("C") & " Dan's Signature Steak"
            ListBoxDisplay.Items.Add(steakItem)
        End If

        If btnPorkChops.Checked Then
            subTotal += pricePorkChops

            Dim porkchopsItem As String = pricePorkChops.ToString("C") & " Hearty Pork Chops"
            ListBoxDisplay.Items.Add(porkchopsItem)
        End If

        If btnExtraSeason.Checked Then
            subTotal += priceExtraSeasoning

            Dim extraseasoningItem As String = priceExtraSeasoning.ToString("C") & " Extra Seasoning"
            ListBoxDisplay.Items.Add(extraseasoningItem)
        End If

        If btnExtraSauce.Checked Then
            subTotal += priceExtraSauce

            Dim extrasauceItem As String = priceExtraSauce.ToString("C") & " Extra Sauce"
            ListBoxDisplay.Items.Add(extrasauceItem)
        End If

        If btnRed.Checked Then
            subTotal += priceRedInside

            Dim redItem As String = priceRedInside.ToString("C") & " Some Red Inside"
            ListBoxDisplay.Items.Add(redItem)
        End If

        If btnAged.Checked Then
            subTotal += priceAged

            Dim agedItem As String = priceAged.ToString("C") & " Aged"
            ListBoxDisplay.Items.Add(agedItem)
        End If

        If btnRibs.Checked Then
            subTotal += priceRibs

            Dim ribsItem As String = priceRibs.ToString("C") & " Smoke House Prime Ribs"
            ListBoxDisplay.Items.Add(ribsItem)
        End If

        If btnPotato.Checked Then
            subTotal += priceBakedPotato

            Dim potatoItem As String = priceBakedPotato.ToString("C") & " Baked Potato"
            ListBoxDisplay.Items.Add(potatoItem)
        End If

        If btnMac.Checked Then
            subTotal += priceMac

            Dim macItem As String = priceMac.ToString("C") & " Chris's Mac N Cheese"
            ListBoxDisplay.Items.Add(macItem)
        End If

        If btnSalad.Checked Then
            subTotal += priceSalad

            Dim saladItem As String = priceSalad.ToString("C") & " Side Salad"
            ListBoxDisplay.Items.Add(saladItem)
        End If

        If btnSoda.Checked Then
            subTotal += priceSoda

            Dim sodaItem As String = priceSoda.ToString("C") & " Soda"
            ListBoxDisplay.Items.Add(sodaItem)
        End If

        If btnIcedTea.Checked Then
            subTotal += priceIcedTea

            Dim teaItem As String = priceIcedTea.ToString("C") & " Iced Tea"
            ListBoxDisplay.Items.Add(teaItem)
        End If

        If btnWater.Checked Then
            subTotal += priceWater

            Dim waterItem As String = priceWater.ToString("C") & " Water"
            ListBoxDisplay.Items.Add(waterItem)
        End If

    End Sub

    Private Sub updateTotal()

        ListBoxTotal.Items.Clear()

        ListBoxTotal.Items.Add("SUB TOTAL = " & subTotal.ToString("C"))

        tax = subTotal * taxRate
        ListBoxTotal.Items.Add("TAX = " & tax.ToString("C"))

        total = subTotal + tax
        ListBoxTotal.Items.Add("TOTAL = " & total.ToString("C"))

        ListBoxDisplay.Items.Add("-------------------")

    End Sub
