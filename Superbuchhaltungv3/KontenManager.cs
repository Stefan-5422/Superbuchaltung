using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows;

namespace Superbuchhaltungv3
{
    public class KontenManager
    {
        private readonly Kontenliste _kontenliste = new Kontenliste();
        private readonly string _filelocation;
        private static bool _instanciated = false;

        public KontenManager(string filelocation)
        {
            if (_instanciated)
            {
                throw new Exception("Kontenmanager already instanciated");
            }
            _filelocation = filelocation;

            if (File.Exists(_filelocation))
            {
                string json = File.ReadAllText(_filelocation);
                _kontenliste = JsonSerializer.Deserialize<Kontenliste>(json);
            }

            _instanciated = true;
        }

        public void Add(string kontenNummer, string kontenName, bool aktiv)
        {
            int num = 0;
            if (int.TryParse(kontenNummer, out _))
            {
                if (_kontenliste.ExistName(kontenName))
                {
                    MessageBox.Show("Name existiert bereits!", "Fehler", MessageBoxButton.OK);
                    return;
                }

                if (_kontenliste.ExistsNummer(kontenNummer))
                {
                    MessageBox.Show("Nummer existiert bereits!", "Fehler", MessageBoxButton.OK);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Nummer ist keine Zahl!", "Fehler", MessageBoxButton.OK);
                return;
            }

            Konto konto = new Konto(aktiv, kontenName, kontenNummer);

            _kontenliste[kontenName] = konto;
        }

        public List<BindingKonto> GetKonten()
        {
            var list = _kontenliste.Konten;
            return list.Select(konto => new BindingKonto(konto.KontoName, konto.KontoNummer.ToString(), konto.Aktiv)).ToList();
        }

        public bool ExistsName(string s) => _kontenliste.ExistName(s);
        public bool ExistsNummer(string i) => _kontenliste.ExistsNummer(i);

        public void Save()
        {
            File.WriteAllText(_filelocation, JsonSerializer.Serialize(_kontenliste));
        }  //(:

        public void Modify(string orginalWert, string kontenNummer, string kontenName, bool aktiv)
        {
            var konto = _kontenliste[orginalWert];
            konto.KontoNummer = kontenNummer;
            konto.KontoName = kontenName;
            konto.Aktiv = aktiv;
        }

        public void Buchung(List<BuchungenKonto> sourcessoll, List<BuchungenKonto> sourceshaben)
        {
            foreach (var buchungenKonto in sourceshaben.Concat(sourcessoll).ToList())
            {
                if (!_kontenliste.ExistsNummer(buchungenKonto.KontoNummer))
                {
                    MessageBox.Show("Konto Existiert nicht: " + buchungenKonto.KontoNummer, "Fehler",MessageBoxButton.OK);
                    return;
                }
            }

            foreach (var buchungenKontohaben in sourceshaben)
            {
                foreach (var buchungenKontosoll in sourcessoll)
                {
                    _kontenliste[buchungenKontosoll.KontoNummer].AddBuchung(buchungenKontohaben.Wert,_kontenliste[buchungenKontohaben.KontoNummer].Id);
                    _kontenliste[buchungenKontohaben.KontoNummer].AddBuchung(-buchungenKontosoll.Wert,_kontenliste[buchungenKontosoll.KontoNummer].Id);
                }
            }
        }

        public List<BindingBuchung> GetBuchungen(string kontoKontenNummer)
        {
            List<BindingBuchung> ret =  new List<BindingBuchung>();
            foreach (var buchung in _kontenliste[kontoKontenNummer].Buchungen)
            {
                if (_kontenliste[kontoKontenNummer].Aktiv)
                {
                    ret.Add(new BindingBuchung("0.0", buchung.GegenKonto, (buchung.Wert >= 0)? buchung.Wert.ToString() : "",
                        (buchung.Wert >= 0) ? "" : (-buchung.Wert).ToString()));
                }
                else
                {
                    ret.Add(new BindingBuchung("0.0", buchung.GegenKonto, (buchung.Wert >= 0) ? "" : (-buchung.Wert).ToString(),
                        (buchung.Wert >= 0) ? buchung.Wert.ToString() : ""));
                }
            }

            return ret;
        }
    }

    public class BindingKonto
    {
        public BindingKonto(string kontenName, string kontenNummer, bool aktiv)
        {
            KontenName = kontenName;
            KontenNummer = kontenNummer;
            Aktiv = aktiv;
        }

        public string KontenName { get; set; }
        public string KontenNummer { get; set; }
        public bool Aktiv { get; set; }
    }
    public class BindingBuchung
    {
        public BindingBuchung(string datum, string gegenKonto, string soll, string haben)
        {
            Datum = datum;
            GegenKonto = gegenKonto;
            Soll = soll;
            Haben = haben;
        }

        public string Datum { get; set; }
        public string GegenKonto { get; set; }
        public string Soll { get; set; }
        public string Haben { get; set; }

    }
}