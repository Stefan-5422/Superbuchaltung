using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace Superbuchhaltungv3
{
    [Serializable()]
    public class Kontenliste
    {

        public List<Konto> Konten { get; set; }  = new List<Konto>();

        public Konto this[string s]
        {
            get => ExistName(s) ? Konten.Find(a => a.KontoName == s) :
                ExistsNummer(s) ? Konten.Find(a => a.KontoNummer == s) : null;
            set
            {
                int index = Konten.FindIndex(a => a.KontoName == s);
                if (index >= 0)
                {
                    Konten[index] = value;
                }
                else
                {
                    Konten.Add(value);
                }
            }
        }
        public bool ExistName(string s) => Konten.FindIndex(a => a.KontoName == s) >= 0;
        public bool ExistsNummer(string i) => Konten.FindIndex(a => a.KontoNummer == i) >= 0;
    }
}