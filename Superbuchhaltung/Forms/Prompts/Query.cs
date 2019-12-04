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

namespace Superbuchhaltung.Forms.Prompts
{
    public partial class Query : Form
    {
        public List<string> result = new List<string>();
        public Query()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Suchebtn_Click(object sender, EventArgs e)
        {
            result.Clear();
            KUHL.Rows.Clear();
            if (Suchen.Text.Length != 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    string[] file = File.ReadAllLines(@"C:\Users\Public\TestFolder\" + i + ".txt");
                    foreach (string s in file)
                    {
                        if (s.Contains(Suchen.Text))
                        {
                            result.Add(s);
                            KUHL.Rows.Add(s.Split(';'));
                        }
                    }
                }
                Console.WriteLine(result.Count());
                if (result.Count != 0)
                {
                    Main m = new Main();
                    //m.Search(result);
                }
            }
            else
            {
                return;
            }
        }

        private void Query_Load(object sender, EventArgs e)
        {

        }
    }
}
