using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RMS_FYP
{
    public partial class Setting : Sample
    {
        public Setting()
        {
            InitializeComponent();
        }

        MainClass mc = new MainClass();
        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (isCB.Checked)
            {
                if (datasourceTxt.Text == "") { datasourceLable.Visible = true; } else { datasourceLable.Visible = false; }
                if (dbTxt.Text == "") { dbLable.Visible = true; } else { dbLable.Visible = false; }
                if(datasourceLable.Visible || dbLable.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory");
                }
                else
                {
                    sb.Append("Data Source =" + datasourceTxt.Text + ";Intial Catalog=" +dbTxt.Text + ";Integrated Security = true; MultipleActiveResultSets= true");
                    File.WriteAllText(MainClass.path, sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved successfully.", "Success", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {   
                        LoginScreen ls = new LoginScreen();
                        MainClass.showWindow(ls, this, MDI.ActiveForm);
                    }
                }
            }
            else
            {
                if (datasourceTxt.Text == "") { datasourceLable.Visible = true; } else { datasourceLable.Visible = false; }
                if (dbTxt.Text == "") { dbLable.Visible = true; } else { dbLable.Visible = false; }
                if (usernameTxt.Text == "") { usernameLable.Visible = true; } else { usernameLable.Visible = false; }
                if (passwordTxt.Text == "") { pasLable.Visible = true; } else { pasLable.Visible = false; }
                if (datasourceLable.Visible || dbLable.Visible || usernameLable.Visible || pasLable.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory");
                }
                else
                {
                    sb.Append("Data Source =" + datasourceTxt.Text + ";Intial Catalog=" +dbTxt.Text + ";User ID=" +usernameTxt.Text + "; Password=" +passwordTxt.Text +";MultipleActiveResultSets=true");
                    File.WriteAllText(MainClass.path, sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings saved successfully.", "Success", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        LoginScreen ls = new LoginScreen();
                        MainClass.showWindow(ls, this, MDI.ActiveForm);
                    }
                }
            }
        }

        private void datasourceTxt_TextChanged(object sender, EventArgs e)
        {
            if(datasourceTxt.Text == "") { datasourceLable.Visible = true; } else { datasourceLable.Visible = false; }
        }

        private void dbTxt_TextChanged(object sender, EventArgs e)
        {
            if (dbTxt.Text == "") { dbLable.Visible = true; } else { dbLable.Visible = false; }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { usernameLable.Visible = true; } else { usernameLable.Visible = false; }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "") { pasLable.Visible = true; } else { pasLable.Visible = false; }
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                usernameTxt.Text = "";
                usernameTxt.Enabled = false;

                passwordTxt.Text = "";
                passwordTxt.Enabled = false;

                usernameLable.Visible = false;
                pasLable.Visible = false;

            }
            else
            {
                usernameTxt.Enabled = true;
                passwordTxt.Enabled = true;
            }
        }
    }
}
