namespace sqliteTest
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.attachDetachDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTablesStructureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllDataBetweenTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastInsertRowIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeScalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryExecutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getColumnStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getTableListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getTableStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.createNewSQLiteDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExistingSQLiteDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDB
            // 
            this.lbDB.Name = "lbDB";
            this.lbDB.Size = new System.Drawing.Size(0, 17);
            // 
            // attachDetachDatabaseToolStripMenuItem
            // 
            this.attachDetachDatabaseToolStripMenuItem.Name = "attachDetachDatabaseToolStripMenuItem";
            this.attachDetachDatabaseToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.attachDetachDatabaseToolStripMenuItem.Text = "Attach Database";
            // 
            // updateTablesStructureToolStripMenuItem
            // 
            this.updateTablesStructureToolStripMenuItem.Name = "updateTablesStructureToolStripMenuItem";
            this.updateTablesStructureToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.updateTablesStructureToolStripMenuItem.Text = "Update Table\'s Structure";
            // 
            // dropTableToolStripMenuItem
            // 
            this.dropTableToolStripMenuItem.Name = "dropTableToolStripMenuItem";
            this.dropTableToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.dropTableToolStripMenuItem.Text = "Drop Table";
            // 
            // copyAllDataBetweenTablesToolStripMenuItem
            // 
            this.copyAllDataBetweenTablesToolStripMenuItem.Name = "copyAllDataBetweenTablesToolStripMenuItem";
            this.copyAllDataBetweenTablesToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.copyAllDataBetweenTablesToolStripMenuItem.Text = "Copy All Data Between Tables";
            // 
            // renameTableToolStripMenuItem
            // 
            this.renameTableToolStripMenuItem.Name = "renameTableToolStripMenuItem";
            this.renameTableToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.renameTableToolStripMenuItem.Text = "Rename Table";
            // 
            // createTableToolStripMenuItem
            // 
            this.createTableToolStripMenuItem.Name = "createTableToolStripMenuItem";
            this.createTableToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.createTableToolStripMenuItem.Text = "Create Table";
            this.createTableToolStripMenuItem.Click += new System.EventHandler(this.createTableToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTableToolStripMenuItem,
            this.renameTableToolStripMenuItem,
            this.copyAllDataBetweenTablesToolStripMenuItem,
            this.dropTableToolStripMenuItem,
            this.updateTablesStructureToolStripMenuItem,
            this.attachDetachDatabaseToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // lastInsertRowIdToolStripMenuItem
            // 
            this.lastInsertRowIdToolStripMenuItem.Name = "lastInsertRowIdToolStripMenuItem";
            this.lastInsertRowIdToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.lastInsertRowIdToolStripMenuItem.Text = "Last Insert RowId";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // executeScalarToolStripMenuItem
            // 
            this.executeScalarToolStripMenuItem.Name = "executeScalarToolStripMenuItem";
            this.executeScalarToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.executeScalarToolStripMenuItem.Text = "ExecuteScalar";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbDB});
            this.statusStrip1.Location = new System.Drawing.Point(0, 233);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(876, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.executeToolStripMenuItem.Text = "Execute";
            // 
            // queryExecutionToolStripMenuItem
            // 
            this.queryExecutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.executeScalarToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.lastInsertRowIdToolStripMenuItem});
            this.queryExecutionToolStripMenuItem.Name = "queryExecutionToolStripMenuItem";
            this.queryExecutionToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.queryExecutionToolStripMenuItem.Text = "Query";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // showDatabaseToolStripMenuItem
            // 
            this.showDatabaseToolStripMenuItem.Name = "showDatabaseToolStripMenuItem";
            this.showDatabaseToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.showDatabaseToolStripMenuItem.Text = "Show Database";
            this.showDatabaseToolStripMenuItem.Click += new System.EventHandler(this.showDatabaseToolStripMenuItem_Click);
            // 
            // getColumnStatusToolStripMenuItem
            // 
            this.getColumnStatusToolStripMenuItem.Name = "getColumnStatusToolStripMenuItem";
            this.getColumnStatusToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.getColumnStatusToolStripMenuItem.Text = "GetColumnStatus";
            this.getColumnStatusToolStripMenuItem.Click += new System.EventHandler(this.getColumnStatusToolStripMenuItem_Click);
            // 
            // getTableListToolStripMenuItem
            // 
            this.getTableListToolStripMenuItem.Name = "getTableListToolStripMenuItem";
            this.getTableListToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.getTableListToolStripMenuItem.Text = "GetTableList";
            this.getTableListToolStripMenuItem.Click += new System.EventHandler(this.getTableListToolStripMenuItem_Click);
            // 
            // getTableStatusToolStripMenuItem
            // 
            this.getTableStatusToolStripMenuItem.Name = "getTableStatusToolStripMenuItem";
            this.getTableStatusToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.getTableStatusToolStripMenuItem.Text = "GetTableStatus";
            this.getTableStatusToolStripMenuItem.Click += new System.EventHandler(this.getTableStatusToolStripMenuItem_Click);
            // 
            // dBInfoToolStripMenuItem
            // 
            this.dBInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getTableStatusToolStripMenuItem,
            this.getTableListToolStripMenuItem,
            this.getColumnStatusToolStripMenuItem,
            this.showDatabaseToolStripMenuItem});
            this.dBInfoToolStripMenuItem.Name = "dBInfoToolStripMenuItem";
            this.dBInfoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.dBInfoToolStripMenuItem.Text = "DB Info";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(474, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(471, 6);
            // 
            // createNewSQLiteDatabaseToolStripMenuItem
            // 
            this.createNewSQLiteDatabaseToolStripMenuItem.Name = "createNewSQLiteDatabaseToolStripMenuItem";
            this.createNewSQLiteDatabaseToolStripMenuItem.Size = new System.Drawing.Size(474, 26);
            this.createNewSQLiteDatabaseToolStripMenuItem.Text = "Create New SQLite Database";
            this.createNewSQLiteDatabaseToolStripMenuItem.Click += new System.EventHandler(this.createNewSQLiteDatabaseToolStripMenuItem_Click);
            // 
            // openExistingSQLiteDatabaseToolStripMenuItem
            // 
            this.openExistingSQLiteDatabaseToolStripMenuItem.Name = "openExistingSQLiteDatabaseToolStripMenuItem";
            this.openExistingSQLiteDatabaseToolStripMenuItem.Size = new System.Drawing.Size(474, 26);
            this.openExistingSQLiteDatabaseToolStripMenuItem.Text = "Open Existing SQLite Database (For Testing Purpose ONLY)";
            this.openExistingSQLiteDatabaseToolStripMenuItem.Click += new System.EventHandler(this.openExistingSQLiteDatabaseToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExistingSQLiteDatabaseToolStripMenuItem,
            this.createNewSQLiteDatabaseToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.dBInfoToolStripMenuItem,
            this.queryExecutionToolStripMenuItem,
            this.utilitiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(876, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 255);
            this.panel1.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 255);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "SQLite Helper Test App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel lbDB;
        private System.Windows.Forms.ToolStripMenuItem attachDetachDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTablesStructureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllDataBetweenTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastInsertRowIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeScalarToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryExecutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getColumnStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getTableListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getTableStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem createNewSQLiteDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExistingSQLiteDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}

