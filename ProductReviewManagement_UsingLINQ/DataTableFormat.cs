using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement_UsingLINQ
{
    public class DataTableFormat
    {
        public void TableFormation()
        {
            //DataTable For Add Once
            //taTable productTable = new DataTable("Product Review");
            //////Vaiable
            ////DataColumn dtColumn;
            ////DataRow myDataRow;

            ////// Create Product id column
            ////dtColumn = new DataColumn();
            ////dtColumn.DataType = typeof(Int32);
            ////dtColumn.ColumnName = "ProductId";
            ////dtColumn.Caption = "ProductId";
            ////dtColumn.Unique = true;
            ////// Add column to the DataColumnCollection.
            ////productTable.Columns.Add(dtColumn);
        }
        /// <summary>
        /// Uc8 Create Table 
        /// </summary>
        public void CreatedDataTable()
        {
            // Define all the columns once.
            DataTable ProductDetailTable = new DataTable("OrderDetail");
            DataColumn[] col =
            {
                new DataColumn("ProductId",typeof(Int32)),
                new DataColumn("UserId", typeof(Int32)),
                new DataColumn("Rating", typeof(Int32)),
                new DataColumn("Review", typeof(String)),
                new DataColumn("IsLike", typeof(bool)),
            };
            ProductDetailTable.Columns.AddRange(col);
            //Insert data 
            InsertInformation(ProductDetailTable);
        }
        /// <summary>
        /// Uc8 Add data in the table
        /// </summary>
        /// <param name="productDetailTable"></param>
        public void InsertInformation(DataTable productDetailTable)
        {
            // Use an Object array to insert all the rows .
            // Values in the array are matched sequentially to the columns, based on the order in which they appear in the table.
            Object[] rowsData =
            {
                new Object[] { 1, 1, 3, "GOOD", true },
                new Object[] { 2, 2, 5, "BEST", true },
                new Object[] { 3, 3, 3, "NICE", true },
                new Object[] { 4, 4, 4, "GOOD", true },
                new Object[] { 5, 5, 2, "GOOD", true },
                new Object[] { 6, 6, 1, "NOTGOOD", false },
                new Object[] { 7, 7, 5, "BEST", true },
                new Object[] { 8, 8, 5, "BEST", true },
                new Object[] { 9, 9, 4, "NICE", true },
                new Object[] { 10, 10, 1, "NOTGOOD", false },
                new Object[] { 11, 11, 1, "NOTGOOD", false },
            };

            foreach (Object[] row in rowsData)
            {
                productDetailTable.Rows.Add(row);
            }
        }
    }
}
