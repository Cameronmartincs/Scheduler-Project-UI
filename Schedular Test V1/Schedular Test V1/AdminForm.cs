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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        ArrayList course = new ArrayList();
  
       // Course l = new Course("asldkjnasd", "dfsdf", "asda", "asldkjnasd", 5, "asda", "asldkjnasd", "dfsdf",5, 5, "sdsfsdf");
        GridForm frm1 = new GridForm();
        RulesForm frm3 = new RulesForm();
        VisualizeForm frm2 = new VisualizeForm();

        private void AdminForm_Load(object sender, EventArgs e)
        {

           
            frm1.TopLevel = false;
            frm1.Visible = true;
            //frm1.Dock = DockStyle.Top;
            frm1.FormBorderStyle = FormBorderStyle.None;
            frm1.Dock = DockStyle.Fill;

            frm2.TopLevel = false;
            frm2.Visible = true;
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;



            frm3.TopLevel = false;
            frm3.Visible = true;
            frm3.FormBorderStyle = FormBorderStyle.None;
            frm3.Dock = DockStyle.Fill;




            

            //adding a panel in second form and placing the Form1 inside panel.
        
           // panel1.Controls.Add(frm1);
            tabPage1.Controls.Add(frm1);
            tabPage1.AutoScroll = true;

            tabPage2.Controls.Add(frm2);
            tabPage2.AutoScroll = true;

            tabPage3.Controls.Add(frm3);
            tabPage3.AutoScroll = true;



           // course.Add(l);

            tabPage1.Text = "View Courses";
            tabPage2.Text = "Visualize Schedule";
            tabPage3.Text = "Rules List";
    

        }

       
    }
}
