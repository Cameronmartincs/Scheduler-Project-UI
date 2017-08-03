using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedular_Test_V1
{
    public partial class RulesForm : Form
    {
        bool confirmed = false;
        public RulesForm()
        {
            InitializeComponent();
            cbRuleType.SelectedIndexChanged += new EventHandler(this.cbRuleType_OnChanged);
        }

        private void RulesForm_Load(object sender, EventArgs e)
        {
            cbRuleType.Items.AddRange(new Object[] {"Teacher - Room", "Teacher - Time",
                                                    "Room - Course",  "Room - Time", 
                                                    "Course - Time",  "Course - Equipment", "Course - Days" });
        }

        private void cbRuleType_OnChanged(object sender, EventArgs e)
        {
            rulePanel.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            confirmed = false;

        }

        private void btnConfirmType_Click(object sender, EventArgs e)
        {
            confirmed = true;
         
            if ((string)cbRuleType.SelectedItem == "Teacher - Room")
            {
                lblField1.Text = "Teacher Name:";
                lblField2.Text = "Must";
                lblField4.Text = "Room:";
                textBox1.Location = new Point(lblField1.Location.X + lblField1.Width, textBox1.Location.Y);
                lblField2.Location = new Point(textBox1.Location.X + textBox1.Width, lblField2.Location.Y);
                lblField3.Location = new Point(lblField2.Location.X + lblField2.Width, lblField3.Location.Y);
                textBox2.Location = new Point(lblField4.Location.X + lblField4.Width, textBox2.Location.Y);
                rulePanel.Visible = true;
            }
            else if ((string)cbRuleType.SelectedItem == "Teacher - Time")
            {
                lblField1.Text = "Teacher Name:";
                lblField2.Text = "Must";
                lblField4.Text = "Time:";
                textBox1.Location = new Point(lblField1.Location.X + lblField1.Width, textBox1.Location.Y);
                lblField2.Location = new Point(textBox1.Location.X + textBox1.Width, lblField2.Location.Y);
                lblField3.Location = new Point(lblField2.Location.X + lblField2.Width, lblField3.Location.Y);
                textBox2.Location = new Point(lblField4.Location.X + lblField4.Width, textBox2.Location.Y);
                rulePanel.Visible = true;
            }
            else if ((string)cbRuleType.SelectedItem == "Room - Course")
            {
                lblField1.Text = "Room Number:";
                lblField2.Text = "Must";
                lblField4.Text = "Course:";
                textBox1.Location = new Point(lblField1.Location.X + lblField1.Width, textBox1.Location.Y);
                lblField2.Location = new Point(textBox1.Location.X + textBox1.Width, lblField2.Location.Y);
                lblField3.Location = new Point(lblField2.Location.X + lblField2.Width, lblField3.Location.Y);
                textBox2.Location = new Point(lblField4.Location.X + lblField4.Width, textBox2.Location.Y);
                rulePanel.Visible = true;
            }
            else if ((string)cbRuleType.SelectedItem == "Room - Time")
            {
                lblField1.Text = "Room Number:";
                lblField2.Text = "Can't";
                lblField4.Text = "Time:";
                textBox1.Location = new Point(lblField1.Location.X + lblField1.Width, textBox1.Location.Y);
                lblField2.Location = new Point(textBox1.Location.X + textBox1.Width, lblField2.Location.Y);
                lblField3.Location = new Point(lblField2.Location.X + lblField2.Width, lblField3.Location.Y);
                textBox2.Location = new Point(lblField4.Location.X + lblField4.Width, textBox2.Location.Y);
                rulePanel.Visible = true;
            }
            else if ((string)cbRuleType.SelectedItem == "Course - Time")
            {
                lblField1.Text = "Course Name:";
                lblField2.Text = "Must";
                lblField4.Text = "Time:";
                textBox1.Location = new Point(lblField1.Location.X + lblField1.Width, textBox1.Location.Y);
                lblField2.Location = new Point(textBox1.Location.X + textBox1.Width, lblField2.Location.Y);
                lblField3.Location = new Point(lblField2.Location.X + lblField2.Width, lblField3.Location.Y);
                textBox2.Location = new Point(lblField4.Location.X + lblField4.Width, textBox2.Location.Y);
                rulePanel.Visible = true;
            }
            else if ((string)cbRuleType.SelectedItem == "Course - Equipment")
            {


                lblField1.Text = "Course Name:";
                lblField2.Text = "Must";
                lblField4.Text = "Equipment:";
                textBox1.Location = new Point(lblField1.Location.X + lblField1.Width, textBox1.Location.Y);
                lblField2.Location = new Point(textBox1.Location.X + textBox1.Width, lblField2.Location.Y);
                lblField3.Location = new Point(lblField2.Location.X + lblField2.Width, lblField3.Location.Y);
                textBox2.Location = new Point(lblField4.Location.X + lblField4.Width, textBox2.Location.Y);
                rulePanel.Visible = true;
            }
            else if ((string)cbRuleType.SelectedItem == "Course - Days")
            {
                lblField1.Text = "Course Name:";
                lblField2.Text = "Must";
                lblField4.Text = "Days:";
                textBox1.Location = new Point(lblField1.Location.X + lblField1.Width, textBox1.Location.Y);
                lblField2.Location = new Point(textBox1.Location.X + textBox1.Width, lblField2.Location.Y);
                lblField3.Location = new Point(lblField2.Location.X + lblField2.Width, lblField3.Location.Y);
                textBox2.Location = new Point(lblField4.Location.X + lblField4.Width, textBox2.Location.Y);
                rulePanel.Visible = true;
            }
            else
            {
                lblField2.Text = "Must";
                rulePanel.Visible = false;
            }

            

           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Object o = (lblField1.Text + " " + textBox1.Text + " " + lblField2.Text + " " + lblField3.Text + " " + lblField4.Text + " " + textBox2.Text);
            if (confirmed == true && string.IsNullOrWhiteSpace(textBox1.Text) == false && string.IsNullOrWhiteSpace(textBox2.Text) == false && !lbRules.Items.Contains(o))
            {
                //lbRules.Items.Add((lblField1.Text + " " + textBox1.Text + " " + lblField2.Text + " " + lblField3.Text + " " + lblField4.Text + " " + textBox2.Text));
                lbRules.Items.Add(o);
                textBox1.Clear();
                textBox2.Clear();
                
            }
            else
            {
                
                MessageBox.Show("Error!\n" + "Attempted to add duplicate or empty item .");
            }
            
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            //TODO Iterate through strings and create rules based on them to add to Algorithm
        }
    }
}
