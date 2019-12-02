namespace Superbuchhaltung
{
    partial class Addentrie
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
            this.Kontonamebox = new System.Windows.Forms.TextBox();
            this.Kontonummerbox = new System.Windows.Forms.TextBox();
            this.Bestätigungsbutton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.Kontolabel1 = new System.Windows.Forms.Label();
            this.Kontolabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kontonamebox
            // 
            this.Kontonamebox.Location = new System.Drawing.Point(168, 31);
            this.Kontonamebox.Name = "Kontonamebox";
            this.Kontonamebox.Size = new System.Drawing.Size(156, 22);
            this.Kontonamebox.TabIndex = 1;
            // 
            // Kontonummerbox
            // 
            this.Kontonummerbox.Location = new System.Drawing.Point(6, 31);
            this.Kontonummerbox.Name = "Kontonummerbox";
            this.Kontonummerbox.Size = new System.Drawing.Size(156, 22);
            this.Kontonummerbox.TabIndex = 2;
            // 
            // Bestätigungsbutton
            // 
            this.Bestätigungsbutton.Location = new System.Drawing.Point(341, 12);
            this.Bestätigungsbutton.Name = "Bestätigungsbutton";
            this.Bestätigungsbutton.Size = new System.Drawing.Size(108, 25);
            this.Bestätigungsbutton.TabIndex = 3;
            this.Bestätigungsbutton.Text = "Add";
            this.Bestätigungsbutton.UseVisualStyleBackColor = true;
            this.Bestätigungsbutton.Click += new System.EventHandler(this.Bestätigungsbutton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(341, 43);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(108, 25);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Kontolabel1
            // 
            this.Kontolabel1.Location = new System.Drawing.Point(12, 5);
            this.Kontolabel1.Name = "Kontolabel1";
            this.Kontolabel1.Size = new System.Drawing.Size(100, 23);
            this.Kontolabel1.TabIndex = 0;
            this.Kontolabel1.Text = "Kontonummer";
            // 
            // Kontolabel2
            // 
            this.Kontolabel2.Location = new System.Drawing.Point(195, 5);
            this.Kontolabel2.Name = "Kontolabel2";
            this.Kontolabel2.Size = new System.Drawing.Size(100, 23);
            this.Kontolabel2.TabIndex = 5;
            this.Kontolabel2.Text = "Kontoname";
            // 
            // Addentrie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 78);
            this.Controls.Add(this.Kontolabel2);
            this.Controls.Add(this.Kontolabel1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.Bestätigungsbutton);
            this.Controls.Add(this.Kontonummerbox);
            this.Controls.Add(this.Kontonamebox);
            this.Name = "Addentrie";
            this.Text = "Addentrie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Kontonamebox;
        private System.Windows.Forms.TextBox Kontonummerbox;
        private System.Windows.Forms.Button Bestätigungsbutton;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label Kontolabel1;
        private System.Windows.Forms.Label Kontolabel2;
    }
}