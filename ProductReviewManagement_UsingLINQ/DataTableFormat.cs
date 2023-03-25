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
        DataTable productDetailTable = new DataTable("OrderDetail");
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
            
            DataColumn[] col =
            {
                new DataColumn("ProductId",typeof(Int32)),
                new DataColumn("UserId", typeof(Int32)),
                new DataColumn("Rating", typeof(Int32)),
                new DataColumn("Review", typeof(String)),
                new DataColumn("IsLike", typeof(bool)),
            };
            productDetailTable.Columns.AddRange(col);
        }
        /// <summary>
        /// Uc8 Add data in the table
        /// </summary>
        public void InsertInformation()
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
        /// <summary>
        /// Uc9 Retrive data
        /// </summary>
        public void ShowTable()
        {
            foreach (DataColumn col in productDetailTable.Columns)
            {
                Console.Write(col.ColumnName+" ");
            }
            Console.WriteLine();

            foreach (DataRow row in productDetailTable.Rows)
            {
                Console.WriteLine("ProductId "+row[0]+" UserId "+row[1]+" Rating "+row[2]+" Review "+row[3]+" IsLike "+row[4]);
            }
        }
        /// <summary>
        /// Uc12 Add Data in Table
        /// </summary>
        public void AddData()
        {
            CreatedDataTable();
            // Add one row once.
            DataRow row1 = productDetailTable.NewRow();
            row1[0] = 12;
            row1[1] = 12;
            row1[2] = 4;
            row1[3] = "Nice";
            row1[4] = true;
            productDetailTable.Rows.Add(row1);
        }
    }
}
