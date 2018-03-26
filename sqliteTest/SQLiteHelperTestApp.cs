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

namespace SQLiteHelperTestApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            HideAllMenu();
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
            f.Filter = "(*.sqlite)|*.sqlite";
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
        private void deleteSQLiteDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = config.DatabaseFile;
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                lbDB.Text = string.Empty;
                HideAllMenu();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Utilities.CreateTable f = new Forms.Utilities.CreateTable();
            f.Show();
        }

        void RevealAllMenu()//display all menu bar
        {
            for (int i = 0; i < menuStrip1.Items.Count; i++)
            {
                menuStrip1.Items[i].Visible = true;
            }
        } 
        void HideAllMenu()//hide all menu bar expect database
        {
            for (int i = 1; i < menuStrip1.Items.Count; i++)
            {
                menuStrip1.Items[i].Visible = false;
            }
        }
        bool TestConnection()//test database connection
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


    }
}
