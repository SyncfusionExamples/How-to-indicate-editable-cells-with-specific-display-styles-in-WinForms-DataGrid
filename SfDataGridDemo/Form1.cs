using SfDataGrid_Demo;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Events;

namespace SfDataGrid_Demo
{
    public partial class Form1 : Form
    {
        OrderInfoCollection orderInfo;
        public Form1()
        {
            InitializeComponent();
            orderInfo = new OrderInfoCollection();
            sfDataGrid1.AutoGenerateColumns = false;
            sfDataGrid1.DataSource = orderInfo.Orders;
            sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "OrderID", HeaderText = "Order ID", AllowEditing = false });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerID", HeaderText = "Customer ID" , AllowEditing = true});
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "CustomerName", HeaderText = "Name", AllowEditing = false });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Country", HeaderText = "Country" , AllowEditing = true });
            sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "ShipCity", HeaderText = "Ship City" , AllowEditing = false });          
            //Event subscription
            sfDataGrid1.QueryCellStyle += OnQueryCellStyle;
        }

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

            //if (e.Column != null)
            //{
            //    if (e.Column.AllowEditing is true)
            //        e.Column.HeaderStyle.BackColor = Color.LightBlue;
            //    else
            //        e.Column.HeaderStyle.BackColor = Color.Gray;
            //}
        }
    }
}
