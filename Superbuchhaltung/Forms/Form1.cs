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
    public partial class Main : Form
    {
        private int Selection = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            P.Visible = true;
            Reloadview();

        }
        private void Changeview()
        {
            PH.Visible = false;
            P.Visible = false;
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Changeview();
            PH.Visible = true;
            Selection = 0;
            Reloadview();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(PHdataview.Rows[PHdataview.CurrentCell.RowIndex].Cells.ToString());
        }

        private void Kat0btn_Click(object sender, EventArgs e)
        {
            Changeview();
            P.Visible = true;
            Pdatagridview.Visible = true;
            Selection = 1;
            Reloadview();
        }
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }



        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reloadview();
        }
        public void Reloadview()
        {
            if (Selection == 0)
            {
                PHdataview.Rows.Clear();
                for (int i = 0; i < 10; i++)
                {
                    string[] file = File.ReadAllLines(@"C:\Users\Public\TestFolder\" + i + ".txt");
                    foreach (string f in file)
                    {
                        if (f.Length < 4) continue;
                        PHdataview.Rows.Add(f.Split(';'));
                    }
                }
            }
            else
            {
                string[] file = File.ReadAllLines(@"C:\Users\Public\TestFolder\" + Selection + ".txt");
                foreach (string f in file)
                {
                    PHdataview.Rows.Add(f.Split(';'));
                }
            }
        }

            private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddentrieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addentrie f = new Addentrie();
            f.Show();
        }

        private void ReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reloadview();
        }

        private void QueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Prompts.Query q = new Forms.Prompts.Query();
            q.Show();
        }
        public void Search(List<string> result)
        {
            Changeview();
            PH.Visible = true;
            PHdataview.Rows.Clear();
            Console.WriteLine(result.Count);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result.ElementAt(i));
                PHdataview.Rows.Add(result.ElementAt(i).Split(';'));
            }
        }

        private void ModifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Forms.Prompts.Modify M = new Forms.Prompts.Modify();
            //M.Show();
            PHdataview.Rows.Clear();
            PHdataview.Rows.Add("ERROR", "Modify not Implimented yet!");
        }
    }
}
