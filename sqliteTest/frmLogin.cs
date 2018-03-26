using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace sqliteTest
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (txtID.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("密码不能为空！");
                return;
            }

            try
            {
                OpenFileDialog f = new OpenFileDialog();
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    config.DatabaseFile = f.FileName;
                }

                using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
                {
                    conn.Open();
                    string Query = "select * from employee where username='" + this.txtID.Text + "' and password='" + this.txtPwd.Text + "'";
                    SQLiteCommand createCommand = new SQLiteCommand(Query, conn);

                    createCommand.ExecuteNonQuery();
                    SQLiteDataReader dr = createCommand.ExecuteReader();

                    int count = 0;
                    while(dr.Read())
                    {
                        count++;
                    }
                    if(count==1)
                    {
                        frmMain frm = new frmMain(txtID.Text);
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username and Password is not correct");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
