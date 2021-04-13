using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Windows.Documents;


namespace Superbuchhaltungv3
{
    public class Konto
    {
        public bool Aktiv { get; set; }
        public string KontoNummer { get; set; }
        public string KontoName { get; set; }
        public float Wert { get; set; }

        [JsonInclude]
        public string Id { get; private set; }
        [JsonInclude]
        public List<Buchung> Buchungen { get; private set; } = new List<Buchung>();

        public Konto(bool aktiv, string kontoName, string kontoNummer)
        {
            Aktiv = aktiv;
            KontoName = kontoName;
            KontoNummer = kontoNummer;
            Id = DateTime.Now.Ticks.ToString() + "-" + Guid.NewGuid().ToString();
        }

        public void AddBuchung(float wert, string gegenKonto)
        {
            Buchungen.Add(new Buchung(wert, gegenKonto));
            NewMethod(wert);

            void NewMethod(float wert)
            {
                Wert += wert;
            }
        }

        public void RemoveBuchung(int index)
        {
            Wert -= Buchungen[index].Wert;
            Buchungen.RemoveAt(index);
        }
        public void ClearBuchungen()
        {
            Wert = 0.0f;
            Buchungen.Clear();
        }
    }
}