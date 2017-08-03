using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedular_Test_V1
{
    public partial class GridForm : Form
    {
        public GridForm()
        {
            InitializeComponent();
        }

        ArrayList course = new ArrayList();
        private void GridForm_Load(object sender, EventArgs e)
        {
            string[] headers = { "Session", "Course ID", "Course Section", "Course Name", "Days", "Start Time", "End Time", "Instructor", "Credits", "Max Enrollment", "Room" };
            GetData(ref course);
            //Border
            DevAge.Drawing.BorderLine border = new DevAge.Drawing.BorderLine(Color.DarkKhaki, 1);
            DevAge.Drawing.RectangleBorder cellBorder = new DevAge.Drawing.RectangleBorder(border, border);

           /* //Views
            CellBackColorAlternate viewNormal = new CellBackColorAlternate(Color.Khaki, Color.DarkKhaki);
            viewNormal.Border = cellBorder;
            CheckBoxBackColorAlternate viewCheckBox = new CheckBoxBackColorAlternate(Color.Khaki, Color.DarkKhaki);
            viewCheckBox.Border = cellBorder;*/

            //ColumnHeader view
            SourceGrid.Cells.Views.ColumnHeader viewColumnHeader = new SourceGrid.Cells.Views.ColumnHeader();
            DevAge.Drawing.VisualElements.ColumnHeader backHeader = new DevAge.Drawing.VisualElements.ColumnHeader();
            backHeader.BackColor = Color.Maroon;
            backHeader.Border = DevAge.Drawing.RectangleBorder.NoBorder;
            viewColumnHeader.Background = backHeader;
            viewColumnHeader.ForeColor = Color.White;
            viewColumnHeader.Font = new Font("Comic Sans MS", 10, FontStyle.Underline);

            //Editors
            SourceGrid.Cells.Editors.TextBox editorString = new SourceGrid.Cells.Editors.TextBox(typeof(string));
            SourceGrid.Cells.Editors.TextBoxUITypeEditor editorDateTime = new SourceGrid.Cells.Editors.TextBoxUITypeEditor(typeof(DateTime));


            //Create the grid
            grid1.BorderStyle = BorderStyle.FixedSingle;

            
            grid1.ColumnsCount = headers.Length;
            //grid1.FixedRows = 1;
            grid1.Rows.Insert(0);

            /*   SourceGrid.Cells.ColumnHeader columnHeader;

               columnHeader = new SourceGrid.Cells.ColumnHeader("String");
               columnHeader.View = viewColumnHeader;
               grid1[0, 0] = columnHeader;

               columnHeader = new SourceGrid.Cells.ColumnHeader("DateTime");
               columnHeader.View = viewColumnHeader;
               grid1[0, 1] = columnHeader;

               columnHeader = new SourceGrid.Cells.ColumnHeader("CheckBox");
               columnHeader.View = viewColumnHeader;
               grid1[0, 2] = columnHeader;*/

            // columnHeader.ResizeEnabled = false;
            SourceGrid.Cells.ColumnHeader columnHeader;

            for (int i = 0; i < headers.Length; i++)
            {
                columnHeader = new SourceGrid.Cells.ColumnHeader(headers[i]);
                columnHeader.ResizeEnabled = false;
                columnHeader.View = viewColumnHeader;
                grid1[0, i] = columnHeader;


               /* inputGrid[1, i] = new SourceGrid.Cells.Cell("");
                inputGrid[1, i].Editor = editorString;*/


            }

            MessageBox.Show(course.Count.ToString());
            grid1.RowsCount = course.Count + 10;

            int row = 1;
            foreach (Course c in course)
            {
                grid1.Rows.Insert(row);
                Type f = course[row-1].GetType();
                int col = 0;
                foreach (PropertyInfo propertyInfo in f.GetProperties())
                {
                    
                    grid1[row, col] = new SourceGrid.Cells.Cell(propertyInfo.GetValue(c));
                    // Console.WriteLine(propertyInfo.GetValue(obj));
                    col++;

                }
                
                row++;
                if (row >= course.Count +1 ) { break; }

            }
           

                







            /*    grid1[r, 0] = new SourceGrid.Cells.Cell("Hello " + r.ToString());
                grid1[r, 0].Editor = editorString;

                grid1[r, 1] = new SourceGrid.Cells.Cell(DateTime.Today);
                grid1[r, 1].Editor = editorDateTime;

                grid1[r, 2] = new SourceGrid.Cells.CheckBox(null, true);

             /*   grid1[r, 0].View = viewNormal;
                grid1[r, 1].View = viewNormal;
                grid1[r, 2].View = viewCheckBox;*/
            

            grid1.AutoSizeCells();
          
           // grid1.Height = grid1.Rows.GetHeight(0) + grid1.Rows.GetHeight(1) + ((int)border.Width * 2);
        }
        public void GetData(ref ArrayList course)
        {

            String constr = "Data Source = .\\SQLEXPRESS; Initial Catalog = Scheduling; Uid=DeptChair; Pwd=Stmartins01;";

            //  Provider = SQLNCLI11; Server = myServerAddress; Database = myDataBase; Uid = myUsername;
            // Pwd = myPassword;

            SqlConnection con = new SqlConnection(constr);
            con.Open();

            //SqlCommand com = new SqlCommand(@"SELECT Session, [Course ID_], [Course Section_], [Days_Index], Instructor, Credits, [Max Enrollment] From Courses", con);
            SqlCommand com = new SqlCommand(@"SELECT Session, [Course ID_],  [Course Section_], [Course Title_], [Start Time],[End Time], y.[Days_Offered], Instructor, Credits, [Max Enrollment], [RoomNumber] From Courses x, Days y where (x.[Days_Index] = y.[Days_Index])", con);




            SqlDataReader reader = com.ExecuteReader();


            while (reader.Read())
            {

                // course.Add(new Course(reader.GetString(0), reader.GetString(1), reader.GetString(2), "cname placeholder", reader.GetInt32(3), " start time placeholder", "end time placeholder", SafeGetString(reader, 4), Convert.ToInt32(reader.GetString(5)), Convert.ToInt32(reader.GetString(6)), "room number placeholder"));
                course.Add(new Course(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(6).ToString(), reader.GetString(4), SafeGetString(reader, 5).ToString(), SafeGetString(reader, 7), Convert.ToInt32(reader.GetString(8)), Convert.ToInt32(reader.GetString(9)), reader.GetString(10)));
            }
            reader.Close();
            con.Close();
        }
        private string SafeGetString(SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return string.Empty;
        }
        private TimeSpan SafeGetTime(SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetTimeSpan(colIndex);
            return TimeSpan.Zero;
        }


    }


}
