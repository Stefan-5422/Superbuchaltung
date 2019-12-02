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
            //PH.Visible = false;
            Reloadview();

        }
        private void Changeview()
        {
            PH.Visible = false;
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Changeview();
            PH.Visible = true;
            Selection = 0;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Kat0btn_Click(object sender, EventArgs e)
        {
            Changeview();
            Selection = 1;
        }
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Addentrie f = new Addentrie();
            f.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
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
                        PHdataview.Rows.Add(f.Split(';'));

                    }
                }
            }
        }

            private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
