namespace View.UserControls
{
    partial class UCGetTakmicenje
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCGetTakmicenje));
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvTakmicenje = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvStatistika = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNivo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatumOdrzavanja = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicenje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistika)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdaberi.BackColor = System.Drawing.Color.DarkGreen;
            this.btnOdaberi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOdaberi.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnOdaberi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdaberi.Location = new System.Drawing.Point(440, 204);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(133, 23);
            this.btnOdaberi.TabIndex = 75;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = false;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPretrazi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPretrazi.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPretrazi.Location = new System.Drawing.Point(440, 34);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(132, 23);
            this.btnPretrazi.TabIndex = 74;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvTakmicenje
            // 
            this.dgvTakmicenje.AllowUserToAddRows = false;
            this.dgvTakmicenje.AllowUserToDeleteRows = false;
            this.dgvTakmicenje.AllowUserToResizeColumns = false;
            this.dgvTakmicenje.AllowUserToResizeRows = false;
            this.dgvTakmicenje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTakmicenje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTakmicenje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakmicenje.Location = new System.Drawing.Point(52, 63);
            this.dgvTakmicenje.Name = "dgvTakmicenje";
            this.dgvTakmicenje.ReadOnly = true;
            this.dgvTakmicenje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTakmicenje.Size = new System.Drawing.Size(521, 131);
            this.dgvTakmicenje.TabIndex = 73;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilter.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtFilter.Location = new System.Drawing.Point(228, 34);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(206, 21);
            this.txtFilter.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label8.Location = new System.Drawing.Point(49, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 16);
            this.label8.TabIndex = 71;
            this.label8.Text = "Pretraži takmičenja (po nivou):";
            // 
            // dgvStatistika
            // 
            this.dgvStatistika.AllowUserToAddRows = false;
            this.dgvStatistika.AllowUserToDeleteRows = false;
            this.dgvStatistika.AllowUserToResizeColumns = false;
            this.dgvStatistika.AllowUserToResizeRows = false;
            this.dgvStatistika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistika.Location = new System.Drawing.Point(24, 120);
            this.dgvStatistika.Name = "dgvStatistika";
            this.dgvStatistika.ReadOnly = true;
            this.dgvStatistika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatistika.Size = new System.Drawing.Size(507, 139);
            this.dgvStatistika.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.Location = new System.Drawing.Point(67, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Nivo:";
            // 
            // txtNivo
            // 
            this.txtNivo.Enabled = false;
            this.txtNivo.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtNivo.Location = new System.Drawing.Point(198, 38);
            this.txtNivo.Name = "txtNivo";
            this.txtNivo.ReadOnly = true;
            this.txtNivo.Size = new System.Drawing.Size(224, 21);
            this.txtNivo.TabIndex = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDatumOdrzavanja);
            this.groupBox1.Controls.Add(this.txtNivo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvStatistika);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(42, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 283);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statisitka";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.Location = new System.Drawing.Point(69, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Datum održavanja:";
            // 
            // txtDatumOdrzavanja
            // 
            this.txtDatumOdrzavanja.Enabled = false;
            this.txtDatumOdrzavanja.Location = new System.Drawing.Point(198, 77);
            this.txtDatumOdrzavanja.Name = "txtDatumOdrzavanja";
            this.txtDatumOdrzavanja.ReadOnly = true;
            this.txtDatumOdrzavanja.Size = new System.Drawing.Size(224, 21);
            this.txtDatumOdrzavanja.TabIndex = 79;
            // 
            // UCGetTakmicenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvTakmicenje);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label8);
            this.DoubleBuffered = true;
            this.Name = "UCGetTakmicenje";
            this.Size = new System.Drawing.Size(1119, 582);
            this.Load += new System.EventHandler(this.UCGetTakmicenje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakmicenje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistika)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvTakmicenje;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvStatistika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatumOdrzavanja;
    }
}
