namespace Superbuchhaltung
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Kat0btn = new System.Windows.Forms.Button();
            this.Homebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PH = new System.Windows.Forms.Panel();
            this.PHdataview = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Databtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Addentriemenuueitem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BWert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PHdataview)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.Kat0btn);
            this.panel1.Controls.Add(this.Homebtn);
            this.panel1.Location = new System.Drawing.Point(1, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 532);
            this.panel1.TabIndex = 0;
            // 
            // Kat0btn
            // 
            this.Kat0btn.FlatAppearance.BorderSize = 0;
            this.Kat0btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kat0btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kat0btn.ForeColor = System.Drawing.Color.White;
            this.Kat0btn.Location = new System.Drawing.Point(0, 147);
            this.Kat0btn.Name = "Kat0btn";
            this.Kat0btn.Size = new System.Drawing.Size(194, 54);
            this.Kat0btn.TabIndex = 3;
            this.Kat0btn.Text = "0. Kategorie";
            this.Kat0btn.UseVisualStyleBackColor = true;
            this.Kat0btn.Click += new System.EventHandler(this.Kat0btn_Click);
            // 
            // Homebtn
            // 
            this.Homebtn.FlatAppearance.BorderSize = 0;
            this.Homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homebtn.ForeColor = System.Drawing.Color.White;
            this.Homebtn.Location = new System.Drawing.Point(0, 87);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(194, 54);
            this.Homebtn.TabIndex = 2;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 109);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ohno Buchhaltung";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PH
            // 
            this.PH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PH.Controls.Add(this.PHdataview);
            this.PH.Location = new System.Drawing.Point(200, 0);
            this.PH.Name = "PH";
            this.PH.Size = new System.Drawing.Size(919, 556);
            this.PH.TabIndex = 2;
            // 
            // PHdataview
            // 
            this.PHdataview.AllowUserToAddRows = false;
            this.PHdataview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PHdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PHdataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BNummer,
            this.BName,
            this.BWert});
            this.PHdataview.Location = new System.Drawing.Point(0, 28);
            this.PHdataview.Name = "PHdataview";
            this.PHdataview.RowHeadersWidth = 10;
            this.PHdataview.RowTemplate.Height = 24;
            this.PHdataview.Size = new System.Drawing.Size(916, 531);
            this.PHdataview.TabIndex = 0;
            this.PHdataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Databtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1120, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // Databtn
            // 
            this.Databtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Databtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.Addentriemenuueitem,
            this.refreshToolStripMenuItem});
            this.Databtn.Image = ((System.Drawing.Image)(resources.GetObject("Databtn.Image")));
            this.Databtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Databtn.Name = "Databtn";
            this.Databtn.Size = new System.Drawing.Size(55, 24);
            this.Databtn.Text = "Data";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.ModifyToolStripMenuItem_Click);
            // 
            // Addentriemenuueitem
            // 
            this.Addentriemenuueitem.Name = "Addentriemenuueitem";
            this.Addentriemenuueitem.Size = new System.Drawing.Size(158, 26);
            this.Addentriemenuueitem.Text = "Addentrie";
            this.Addentriemenuueitem.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BNummer
            // 
            this.BNummer.HeaderText = "Kontennummer";
            this.BNummer.MinimumWidth = 6;
            this.BNummer.Name = "BNummer";
            this.BNummer.ReadOnly = true;
            this.BNummer.Width = 125;
            // 
            // BName
            // 
            this.BName.HeaderText = "Kontenname";
            this.BName.MinimumWidth = 6;
            this.BName.Name = "BName";
            this.BName.ReadOnly = true;
            this.BName.Width = 512;
            // 
            // BWert
            // 
            this.BWert.HeaderText = "Kontensumme";
            this.BWert.MinimumWidth = 6;
            this.BWert.Name = "BWert";
            this.BWert.ReadOnly = true;
            this.BWert.Width = 125;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1120, 562);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PH);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(200, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Ohno Buchaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PHdataview)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Kat0btn;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Panel PH;
        private System.Windows.Forms.DataGridView PHdataview;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton Databtn;
        private System.Windows.Forms.ToolStripMenuItem Addentriemenuueitem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn BNummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn BName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BWert;
    }
}

