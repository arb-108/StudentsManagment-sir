namespace StudentsManagment.Screens
{
    partial class branches
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBraanchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchesdataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLoseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewBraanchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cLoseToolStripMenuItem
            // 
            this.cLoseToolStripMenuItem.Name = "cLoseToolStripMenuItem";
            this.cLoseToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.cLoseToolStripMenuItem.Text = "&Close";
            this.cLoseToolStripMenuItem.Click += new System.EventHandler(this.cLoseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(27, 24);
            this.toolStripMenuItem1.Text = "|";
            // 
            // addNewBraanchToolStripMenuItem
            // 
            this.addNewBraanchToolStripMenuItem.Name = "addNewBraanchToolStripMenuItem";
            this.addNewBraanchToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.addNewBraanchToolStripMenuItem.Text = "Add New Braanch";
            this.addNewBraanchToolStripMenuItem.Click += new System.EventHandler(this.addNewBraanchToolStripMenuItem_Click);
            // 
            // branchesdataGridView
            // 
            this.branchesdataGridView.AllowUserToAddRows = false;
            this.branchesdataGridView.AllowUserToDeleteRows = false;
            this.branchesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchesdataGridView.Location = new System.Drawing.Point(12, 42);
            this.branchesdataGridView.Name = "branchesdataGridView";
            this.branchesdataGridView.ReadOnly = true;
            this.branchesdataGridView.RowHeadersWidth = 51;
            this.branchesdataGridView.RowTemplate.Height = 24;
            this.branchesdataGridView.Size = new System.Drawing.Size(863, 404);
            this.branchesdataGridView.TabIndex = 1;
            this.branchesdataGridView.DoubleClick += new System.EventHandler(this.branchesdataGridView_DoubleClick);
            // 
            // branches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 458);
            this.Controls.Add(this.branchesdataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "branches";
            this.Text = "Branches";
            this.Load += new System.EventHandler(this.branches1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLoseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewBraanchToolStripMenuItem;
        private System.Windows.Forms.DataGridView branchesdataGridView;
    }
}