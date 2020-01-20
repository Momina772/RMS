using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_FYP
{
    public partial class adminHomeScreen : Sample
    {
        public adminHomeScreen()
        {
            InitializeComponent();
        }
        MainClass mc = new MainClass();
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roleBtn_Click(object sender, EventArgs e)
        {
            rolesWindow rolesS = new rolesWindow();
            MainClass.showWindow(rolesS, this, MDI.ActiveForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User();
            MainClass.showWindow(user, this, MDI.ActiveForm);
        }
    }
}
