namespace Superbuchhaltungv3
{
    public class Buchung
    {
        public float Wert { get; set; }
        public string GegenKonto { get; set; }
        public Buchung(float wert, string gegenKonto)
        {
            Wert = wert;
            GegenKonto = gegenKonto;
        }
    }
}