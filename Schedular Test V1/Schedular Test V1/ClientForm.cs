using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedular_Test_V1
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            inputGrid.Leave += new EventHandler(this.AddObject);
            

        }


        private void AddObject(object sender, System.EventArgs e)
        {
            // string[] headers = {  "Session", "Course ID", "Course Section", "Course Name", "Days", "Start Time", "End Time", "Instructor", "Credits", "Max Enrollment", "Room" };
            listEditor1.Tempo = new Course(inputGrid[1, 0].ToString(), inputGrid[1, 1].ToString(), inputGrid[1, 2].ToString(), inputGrid[1, 3].ToString(), inputGrid[1, 4].ToString(), inputGrid[1, 5].ToString()
                                            , inputGrid[1, 6].ToString(), inputGrid[1, 7].ToString(), Convert.ToInt32(inputGrid[1,8].Value), Convert.ToInt32(inputGrid[1, 9].Value), inputGrid[1, 10].ToString());

            toAddCourse.Add(listEditor1.Tempo);


            //listEditor1.Tempo = new Course();


        }





        ArrayList toAddCourse = new ArrayList();
        ArrayList course = new ArrayList();
       // Course c = new Course("asldkjnasd", "dfsdf", "asda");

        
       // Course d = new Course("asldkjnasd", "dfsdf", "asda");
       // Course lala = new Course("asldkjnasd", "dfsdf", "asda");

        
        private void ClientForm_Load(object sender, EventArgs e)
        {
         

            String constr = "Data Source = .\\SQLEXPRESS; Initial Catalog = Scheduling; Uid=DeptChair; Pwd=Stmartins01;";

          //  Provider = SQLNCLI11; Server = myServerAddress; Database = myDataBase; Uid = myUsername;
           // Pwd = myPassword;

            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand com = new SqlCommand(@"SELECT Session, [Course ID_],  [Course Section_], [Course Title_], [Start Time], [End Time], y.[Days_Offered], Instructor, Credits, [Max Enrollment], [RoomNumber] From Courses x, Days y where ((x.[Days_Index] = y.[Days_Index]) AND (x.username='DeptChair'));", con);
            com.Parameters.AddWithValue("@uid", "DeptChair");
            
           
            SqlDataReader reader = com.ExecuteReader();
         

            while (reader.Read())
            {


                course.Add(new Course(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(6), reader.GetString(4).ToString(), reader.GetString(5).ToString(), SafeGetString(reader, 7).ToString(), Convert.ToInt32(reader.GetString(8)), Convert.ToInt32(reader.GetString(9)), reader.GetString(10)));
                                   
            }
        
            reader.Close();
            con.Close();

                
            listEditor1.EnableAdd = true;
            listEditor1.ItemType = typeof(Course);
            listEditor1.List = new ArrayList(course);
            listEditor1.LoadList();
            MessageBox.Show(course.Count.ToString());
    
            inputGrid_Paint();

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



        private void inputGrid_Paint() //object sender, PaintEventArgs e
        {
            string[] headers = {  "Session", "Course ID", "Course Section", "Course Name", "Days", "Start Time", "End Time", "Instructor", "Credits", "Max Enrollment", "Room" };

           // string[] headers = { "ID" , "Combination" };

           

            //Border
            DevAge.Drawing.BorderLine border = new DevAge.Drawing.BorderLine(Color.Black, 2);
            DevAge.Drawing.RectangleBorder cellBorder = new DevAge.Drawing.RectangleBorder(border, border);

           /* CellBackColorAlternate viewNormal = new CellBackColorAlternate(Color.Khaki, Color.DarkKhaki);
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
           
            
            viewColumnHeader.Font = new Font("Comic Sans MS", 14, FontStyle.Bold | FontStyle.Underline);

            //Editors
            SourceGrid.Cells.Editors.TextBox editorString = new SourceGrid.Cells.Editors.TextBox(typeof(string));
            SourceGrid.Cells.Editors.TextBoxUITypeEditor editorDateTime = new SourceGrid.Cells.Editors.TextBoxUITypeEditor(typeof(DateTime));


            //Create the grid
            inputGrid.BorderStyle = BorderStyle.FixedSingle;

            inputGrid.ColumnsCount = headers.Length;
            inputGrid.FixedRows = 1;
            inputGrid.FixedColumns = headers.Length;
            inputGrid.Rows.Insert(0);
            inputGrid.Rows.Insert(1);
            inputGrid.Rows.SetHeight(1, Font.Height);



            SourceGrid.Cells.ColumnHeader columnHeader;
            
            for(int i = 0; i< headers.Length; i++)
            {
                columnHeader = new SourceGrid.Cells.ColumnHeader(headers[i]);
                columnHeader.ResizeEnabled = false;
                columnHeader.View = viewColumnHeader;
                inputGrid[0, i] = columnHeader;


                inputGrid[1, i] = new SourceGrid.Cells.Cell("");
                inputGrid[1, i].Editor = editorString;


            }
            

          

            inputGrid.AutoSizeCells();
            inputGrid.Rows.SetHeight(1, Font.Height * 2);
            inputGrid.Height = inputGrid.Rows.GetHeight(0) + inputGrid.Rows.GetHeight(1) + ((int)border.Width);

            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string uid = "DeptChair";

            String constr = "Data Source = .\\SQLEXPRESS; Initial Catalog = Scheduling; Uid=" + uid + "; Pwd=Stmartins01;";

            //  Provider = SQLNCLI11; Server = myServerAddress; Database = myDataBase; Uid = myUsername;
            // Pwd = myPassword;

            SqlConnection con = new SqlConnection(constr);
            con.Open();

            foreach (Course c in toAddCourse)
            {
                MessageBox.Show("here");

               // SqlCommand com = new SqlCommand(@"SELECT Session, [Course ID_],  [Course Section_], [Course Title_], [Start Time],[End Time], y.[Days_Offered], Instructor, Credits, [Max Enrollment], [RoomNumber] From Courses x, Days y where (x.[Days_Index] = y.[Days_Index]) AND x.username=" + "'" + uid + "';", con);
              /*  SqlCommand b = new SqlCommand(@"IF NOT EXISTS(select * FROM Courses where username=@uid)
                                            BEGIN
                                                Insert into courses VALUES (@Session, @CourseID, @ CSection, @ CTitle, @STime, @ETime, @DaysOffered, @Instructor, @Cred, @MEnroll, @RNumber, @username);
                                            END
                                            ELSE
                                                BEGIN
                                                    Update Courses as x
                                                    Set (@Session, @CourseID, @ CSection, @ CTitle, @STime, @ETime, @DaysOffered, @Instructor, @Cred, @MEnroll, @RNumber) 
                                                    Where @Session = x.Session AND @CourseID = x.[Course ID_] AND @CSection = x.[Course Section_] AND username = @uid");*/

                SqlCommand a = new SqlCommand(@"BEGIN Tran Insert into Courses VALUES (@Session, @CourseID, @CSection, @CTitle, @DaysOffered, @STime, @ETime, @Instructor, @Cred, @MEnroll, @RNumber, @username); commit;", con);             
                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new SqlParameter("@uid", "DeptChair"));
                list.Add(new SqlParameter("@Session", c.Session));
                list.Add(new SqlParameter("@CourseID", c.Course_ID));
                list.Add(new SqlParameter("@CSection", c.Course_Section));
                list.Add(new SqlParameter("@CTitle", c.Course_Name));
                list.Add(new SqlParameter("@STime", c.Start_Time));
                list.Add(new SqlParameter("@ETime",c.End_Time));
                list.Add(new SqlParameter("@DaysOffered", c.Days));
                list.Add(new SqlParameter("@Instructor", c.Instructor));
                list.Add(new SqlParameter("@Cred", c.Credits));
                list.Add(new SqlParameter("@MEnroll", c.Max_Enrollment));
                list.Add(new SqlParameter("@RNumber", c.Room_Number));
                list.Add(new SqlParameter("@username", uid));
                a.Parameters.AddRange(list.ToArray<SqlParameter>());
                a.ExecuteNonQuery();
            }
            MessageBox.Show("here2");
            con.Close();
            MessageBox.Show("here3");

        }
    }

}
