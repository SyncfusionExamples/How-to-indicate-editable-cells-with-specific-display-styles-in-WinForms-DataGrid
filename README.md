# How to Indicate editable cells with specific display styles in WinForms DataGrid (SfDataGrid)

In [WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) (SfDataGrid), editing at the column level is controlled by setting the [AllowEditing](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.GridColumnBase.html#Syncfusion_WinForms_DataGrid_GridColumnBase_AllowEditing) property to true or false for each column. Editable columns can be visually indicated by applying a [BackColor](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.Styles.CellStyleInfo.html#Syncfusion_WinForms_DataGrid_Styles_CellStyleInfo_BackColor) to the header or cells through the [QueryCellStyle](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.SfDataGrid.html#Syncfusion_WinForms_DataGrid_SfDataGrid_QueryCellStyle) event.
 
 ```csharp
//Event subscription
sfDataGrid1.QueryCellStyle += OnQueryCellStyle;

//Event customization
private void OnQueryCellStyle(object sender, QueryCellStyleEventArgs e)
{
    // To apply cell back color for editable columns
    if (e.Column != null)
    {
        if (e.Column.AllowEditing is true)
            e.Style.BackColor = Color.LightBlue;
        else
            e.Style.BackColor = Color.LightGray;
    }

    // To apply header back color for editable column
    if (e.Column != null)
    {
        if (e.Column.AllowEditing is true)
            e.Column.HeaderStyle.BackColor = Color.LightBlue;
        else
            e.Column.HeaderStyle.BackColor = Color.Gray;
    }
} 
 ```
 
 ![Styles for editable cells](StylesForEditableCells.png)

Take a moment to peruse the [WinForms DataGrid - Styles](https://help.syncfusion.com/windowsforms/datagrid/conditionalstyling) documentation, to learn more about DataGrid conditional styling with examples.