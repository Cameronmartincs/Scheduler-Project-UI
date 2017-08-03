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
    public partial class MenuForm : Form
    {
       // int formControl = 0;
        ClientForm clientForm = new ClientForm();
        AdminForm adminForm = new AdminForm();

        List<Form> _forms = new List<Form>();

        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            foreach (Form f in _forms)
            {
                f.Hide();
            }


            if (!_forms[0].IsDisposed)
                _forms[0].Show();
            else
            {
                _forms[0] = new ClientForm();
                _forms[0].Show();
            }

        }

      /*  private void btnDean_Click(object sender, EventArgs e)
        {
            foreach (Form f in _forms)
            {
                f.Hide();
            }

            if (!_forms[1].IsDisposed)
                _forms[1].Show();
            else
            {
                _forms[1] = new ClientForm();
                _forms[1].Show();
            }
        }*/

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            foreach (Form f in _forms)
            {
                f.Hide();
            }

            if (!_forms[1].IsDisposed)
                _forms[1].Show();
            else
            {
                _forms[1] = new AdminForm();
                _forms[1].Show();
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            _forms.Add(clientForm);
            _forms.Add(adminForm);

        }
    }
}
