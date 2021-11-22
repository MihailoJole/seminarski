namespace View
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.učesnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUčesnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promeniUčesnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiUčesnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promeniTimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiTimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takmicenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTakmicenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiTakmicenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1119, 582);
            this.pnlMain.TabIndex = 1;
            // 
            // učesnikToolStripMenuItem
            // 
            this.učesnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUčesnikaToolStripMenuItem,
            this.promeniUčesnikaToolStripMenuItem,
            this.obrišiUčesnikaToolStripMenuItem});
            this.učesnikToolStripMenuItem.Name = "učesnikToolStripMenuItem";
            this.učesnikToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.učesnikToolStripMenuItem.Text = "Učesnik";
            // 
            // dodajUčesnikaToolStripMenuItem
            // 
            this.dodajUčesnikaToolStripMenuItem.Name = "dodajUčesnikaToolStripMenuItem";
            this.dodajUčesnikaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.dodajUčesnikaToolStripMenuItem.Text = "Dodaj učesnika";
            this.dodajUčesnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajUčesnikaToolStripMenuItem_Click);
            // 
            // promeniUčesnikaToolStripMenuItem
            // 
            this.promeniUčesnikaToolStripMenuItem.Name = "promeniUčesnikaToolStripMenuItem";
            this.promeniUčesnikaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.promeniUčesnikaToolStripMenuItem.Text = "Promeni učesnika";
            this.promeniUčesnikaToolStripMenuItem.Click += new System.EventHandler(this.promeniUčesnikaToolStripMenuItem_Click);
            // 
            // obrišiUčesnikaToolStripMenuItem
            // 
            this.obrišiUčesnikaToolStripMenuItem.Name = "obrišiUčesnikaToolStripMenuItem";
            this.obrišiUčesnikaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.obrišiUčesnikaToolStripMenuItem.Text = "Obriši učesnika";
            this.obrišiUčesnikaToolStripMenuItem.Click += new System.EventHandler(this.obrišiUčesnikaToolStripMenuItem_Click);
            // 
            // timToolStripMenuItem
            // 
            this.timToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajTimToolStripMenuItem,
            this.promeniTimToolStripMenuItem,
            this.obrišiTimToolStripMenuItem});
            this.timToolStripMenuItem.Name = "timToolStripMenuItem";
            this.timToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.timToolStripMenuItem.Text = "Tim";
            // 
            // dodajTimToolStripMenuItem
            // 
            this.dodajTimToolStripMenuItem.Name = "dodajTimToolStripMenuItem";
            this.dodajTimToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.dodajTimToolStripMenuItem.Text = "Dodaj tim";
            this.dodajTimToolStripMenuItem.Click += new System.EventHandler(this.dodajTimToolStripMenuItem_Click);
            // 
            // promeniTimToolStripMenuItem
            // 
            this.promeniTimToolStripMenuItem.Name = "promeniTimToolStripMenuItem";
            this.promeniTimToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.promeniTimToolStripMenuItem.Text = "Promeni tim";
            this.promeniTimToolStripMenuItem.Click += new System.EventHandler(this.promeniTimToolStripMenuItem_Click);
            // 
            // obrišiTimToolStripMenuItem
            // 
            this.obrišiTimToolStripMenuItem.Name = "obrišiTimToolStripMenuItem";
            this.obrišiTimToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.obrišiTimToolStripMenuItem.Text = "Obriši tim";
            this.obrišiTimToolStripMenuItem.Click += new System.EventHandler(this.obrišiTimToolStripMenuItem_Click);
            // 
            // takmicenjeToolStripMenuItem
            // 
            this.takmicenjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajTakmicenjeToolStripMenuItem,
            this.prikažiTakmicenjaToolStripMenuItem});
            this.takmicenjeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.takmicenjeToolStripMenuItem.Name = "takmicenjeToolStripMenuItem";
            this.takmicenjeToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.takmicenjeToolStripMenuItem.Text = "Takmičenje";
            // 
            // dodajTakmicenjeToolStripMenuItem
            // 
            this.dodajTakmicenjeToolStripMenuItem.Name = "dodajTakmicenjeToolStripMenuItem";
            this.dodajTakmicenjeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.dodajTakmicenjeToolStripMenuItem.Text = "Dodaj takmičenje";
            this.dodajTakmicenjeToolStripMenuItem.Click += new System.EventHandler(this.dodajTakmicenjeToolStripMenuItem_Click);
            // 
            // prikažiTakmicenjaToolStripMenuItem
            // 
            this.prikažiTakmicenjaToolStripMenuItem.Name = "prikažiTakmicenjaToolStripMenuItem";
            this.prikažiTakmicenjaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.prikažiTakmicenjaToolStripMenuItem.Text = "Prikaži takmičenja";
            this.prikažiTakmicenjaToolStripMenuItem.Click += new System.EventHandler(this.prikažiTakmicenjaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timToolStripMenuItem,
            this.učesnikToolStripMenuItem,
            this.takmicenjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1119, 606);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Glavna forma]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem učesnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUčesnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promeniUčesnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiUčesnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajTimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promeniTimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiTimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takmicenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajTakmicenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiTakmicenjaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}