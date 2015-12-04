Private Sub calculateInventoryProfit()

        Dim totalCost, sellingPrice, totalValue, totalProfit, margin As Double

        margin = (TrackBarMargin.Value / 100)

        totalCost = listItems.Value * listUnitCost.Value
        sellingPrice = totalCost / (1 - margin)
        totalValue = sellingPrice * listItems.Value
        totalProfit = totalValue - totalCost

        lblTotalCost.Text = Format(totalCost, "currency")
        lblSellingPrice.Text = Format(sellingPrice, "currency")
        lblTotalValue.Text = Format(totalValue, "currency")
        lblTotalProfit.Text = Format(totalProfit, "currency")
        lblMarginPercentage.Text = TrackBarMargin.Value & "%"


    End Sub

    Private Sub listItems_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listItems.ValueChanged
        calculateInventoryProfit()
    End Sub

    Private Sub listUnitCost_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listUnitCost.ValueChanged
        calculateInventoryProfit()
    End Sub

    Private Sub TrackBarMargin_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        calculateInventoryProfit()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        calculateInventoryProfit()
    End Sub

    Private Sub TrackBarMargin_Scroll_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarMargin.Scroll
        calculateInventoryProfit()
    End Sub
