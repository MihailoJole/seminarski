namespace View.UserControls
{
    partial class UCAddTim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddTim));
            this.label1 = new System.Windows.Forms.Label();
            this.txtImeTima = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.Location = new System.Drawing.Point(65, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime tima:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtImeTima
            // 
            this.txtImeTima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImeTima.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtImeTima.Location = new System.Drawing.Point(154, 65);
            this.txtImeTima.Name = "txtImeTima";
            this.txtImeTima.Size = new System.Drawing.Size(166, 21);
            this.txtImeTima.TabIndex = 1;
            this.txtImeTima.TextChanged += new System.EventHandler(this.txtImeTima_TextChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDodaj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDodaj.Location = new System.Drawing.Point(379, 75);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(252, 58);
            this.btnDodaj.TabIndex = 48;
            this.btnDodaj.Text = "Dodaj tim";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.Location = new System.Drawing.Point(65, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Selo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbSelo
            // 
            this.cmbSelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSelo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic);
            this.cmbSelo.FormattingEnabled = true;
            this.cmbSelo.Location = new System.Drawing.Point(154, 117);
            this.cmbSelo.Name = "cmbSelo";
            this.cmbSelo.Size = new System.Drawing.Size(166, 23);
            this.cmbSelo.TabIndex = 50;
            this.cmbSelo.SelectedIndexChanged += new System.EventHandler(this.cmbFakultet_SelectedIndexChanged);
            // 
            // UCAddTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.cmbSelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtImeTima);
            this.Controls.Add(this.label1);
            this.Name = "UCAddTim";
            this.Size = new System.Drawing.Size(1119, 582);
            this.Load += new System.EventHandler(this.UCAddTim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImeTima;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSelo;
    }
}
