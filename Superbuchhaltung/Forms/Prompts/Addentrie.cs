using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Superbuchhaltung
{
    public partial class Addentrie : Form
    {
        public Addentrie()
        {
            InitializeComponent();
        }

        private void Bestätigungsbutton_Click(object sender, EventArgs e)
        {
            string[] write = { Kontonummerbox.Text + ";" +Kontonamebox.Text};
            if (!Directory.Exists(@"C:\Users\Public\TestFolder\")) {
                Directory.CreateDirectory(@"C:\Users\Public\TestFolder");
            }
            string fi = File.ReadAllText(@"C:\Users\Public\TestFolder\" + Kontonummerbox.Text.Substring(0, 1) + @".txt");
            if (fi.IndexOf(Kontonummerbox.Text) != 0) {

                if (MessageBox.Show("Der Kontonummer Existiert bereits!\nWollen sie diese überschreiben?", "Konto existiert bereits",MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No) goto goback;
                int index = fi.IndexOf(Kontonummerbox.Text);
                string sfi = fi.Substring(index,fi.Length-index);
                sfi = sfi.Substring(0,sfi.IndexOf("\n"));
                Console.WriteLine(sfi);
                fi = fi.Replace(sfi, Kontonummerbox.Text + ";"+Kontonamebox.Text);
                Console.WriteLine(fi);
                File.WriteAllText(@"C:\Users\Public\TestFolder\" + Kontonummerbox.Text.Substring(0, 1) + @".txt", fi);
                goto goback;
            }
            if (fi.Contains(Kontonamebox.Text)) {
                if (MessageBox.Show("Der Kontoname Existiert bereits!\nWollen sie eine zweite Instanz erstellen?", "Konto existiert bereits", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No) goto goback;
            }
            File.AppendAllLines(@"C:\Users\Public\TestFolder\" + Kontonummerbox.Text.Substring(0,1) + @".txt", write);
            goback:
            FormCollection fc = Application.OpenForms;
            foreach(Form frm in fc)
            {
                if(frm.Name == "Ohno Buchaltung")
                {
                    frm.Refresh();
                }
            }
            return;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
