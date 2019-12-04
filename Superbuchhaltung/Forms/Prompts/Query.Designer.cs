namespace Superbuchhaltung.Forms.Prompts
{
    partial class Query
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
            this.Suchebtn = new System.Windows.Forms.Button();
            this.Suchen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KUHL = new System.Windows.Forms.DataGridView();
            this.Kontoname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontoNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.KUHL)).BeginInit();
            this.SuspendLayout();
            // 
            // Suchebtn
            // 
            this.Suchebtn.Location = new System.Drawing.Point(132, 30);
            this.Suchebtn.Name = "Suchebtn";
            this.Suchebtn.Size = new System.Drawing.Size(75, 23);
            this.Suchebtn.TabIndex = 0;
            this.Suchebtn.Text = "button1";
            this.Suchebtn.UseVisualStyleBackColor = true;
            this.Suchebtn.Click += new System.EventHandler(this.Suchebtn_Click);
            // 
            // Suchen
            // 
            this.Suchen.Location = new System.Drawing.Point(11, 31);
            this.Suchen.Name = "Suchen";
            this.Suchen.Size = new System.Drawing.Size(100, 22);
            this.Suchen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suchen";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // KUHL
            // 
            this.KUHL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KUHL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kontoname,
            this.KontoNummer});
            this.KUHL.Location = new System.Drawing.Point(12, 59);
            this.KUHL.Name = "KUHL";
            this.KUHL.RowHeadersWidth = 51;
            this.KUHL.RowTemplate.Height = 24;
            this.KUHL.Size = new System.Drawing.Size(1220, 456);
            this.KUHL.TabIndex = 3;
            // 
            // Kontoname
            // 
            this.Kontoname.HeaderText = "Kname";
            this.Kontoname.MinimumWidth = 6;
            this.Kontoname.Name = "Kontoname";
            this.Kontoname.Width = 125;
            // 
            // KontoNummer
            // 
            this.KontoNummer.HeaderText = "Kontonummer";
            this.KontoNummer.MinimumWidth = 6;
            this.KontoNummer.Name = "KontoNummer";
            this.KontoNummer.Width = 125;
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 516);
            this.Controls.Add(this.KUHL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Suchen);
            this.Controls.Add(this.Suchebtn);
            this.Name = "Query";
            this.Text = "Query";
            this.Load += new System.EventHandler(this.Query_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KUHL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Suchebtn;
        private System.Windows.Forms.TextBox Suchen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView KUHL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontoname;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontoNummer;
    }
}