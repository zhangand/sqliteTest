using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace sqliteTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            HideAllMenu();
        }

        public frmMain(string strName)
        {
            InitializeComponent();
            HideAllMenu();
            SendNameValue = strName;
        }
        public string SendNameValue;

        //Commom
        void RevealAllMenu()
        {
            for (int i = 0; i < menuStrip1.Items.Count; i++)
            {
                menuStrip1.Items[i].Visible = true;
            }
        }
        void HideAllMenu()
        {
            for (int i = 1; i < menuStrip1.Items.Count; i++)
            {
                menuStrip1.Items[i].Visible = false;
            }
        }
        bool TestConnection()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
                {
                    conn.Open();
                    conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Database
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void openExistingSQLiteDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                config.DatabaseFile = f.FileName;
                lbDB.Text = config.DataSource;
                if (TestConnection())
                    RevealAllMenu();
                else
                    HideAllMenu();
            }
        }
        private void createNewSQLiteDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                config.DatabaseFile = f.FileName;
                lbDB.Text = config.DataSource;
                if (TestConnection())
                    RevealAllMenu();
                else
                    HideAllMenu();
            }
        }

        //DB info
        private void getTableStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DBInfo.GetTableStatus f = new Forms.DBInfo.GetTableStatus();
            f.Show();
        }
        private void getTableListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DBInfo.GetTableList f = new Forms.DBInfo.GetTableList();
            f.Show();
        }
        private void getColumnStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DBInfo.GetColumnStatus f = new Forms.DBInfo.GetColumnStatus();
            f.Show();
        }
        private void showDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DBInfo.ShowDatabase f = new Forms.DBInfo.ShowDatabase();
            f.Show();
        }


        //Query
        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Query.Select f = new Forms.Query.Select();
            f.Show();
        }

        //Utilities
        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Utilities.CreateTable f = new Forms.Utilities.CreateTable();
            f.Show();
        }

       
    }

}
