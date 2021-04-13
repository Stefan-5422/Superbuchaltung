using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Superbuchhaltungv3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly KontenManager _manager = new KontenManager("./test.json");
        public MainWindow()
        {
            InitializeComponent();
            RefreshKontenListe();
        }

        private void AddkontoSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string kontoNummer = addkontokonteNummer.Text;
            string kontoName = addkontokontenName.Text;
            bool aktiv = addkontoaktiv.IsChecked != null && (bool)addkontoaktiv.IsChecked; //nullcheck

            if (string.IsNullOrWhiteSpace(kontoName) || string.IsNullOrWhiteSpace(kontoNummer))
            {
                return;
            }

            _manager.Add(kontoNummer, kontoName, aktiv);

            RefreshKontenListe();
        }

        private void RefreshKontenListe()
        {
            FKontenListe.Items.Clear();
            foreach (var konto in _manager.GetKonten())
            {
                FKontenListe.Items.Add(konto);
            }
        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MainWindow_OnClosing(object sender, CancelEventArgs e)
        {
            _manager.Save();
        }

        private void ModifykontoSaveButton_Click(object sender, RoutedEventArgs e)
        {
            string konto = modifykontoLoad.Text;
            string kontoNummer = modifykontoNummer.Text;
            string kontoName = modifykontoName.Text;
            bool kontoAktiv = modifykontoAktiv.IsChecked != null && (bool)modifykontoAktiv.IsChecked; //Nullcheck
            if (_manager.ExistsName(konto) || _manager.ExistsNummer(konto))
            {
                _manager.Modify(konto, kontoNummer, kontoName, kontoAktiv);
            }
            else
            {
                MessageBox.Show("Konto existiert nicht!", "Fehler!", MessageBoxButton.OK);
            }
            RefreshKontenListe();
        }

        private void ModifykontoLoad_Click(object sender, RoutedEventArgs e)
        {
            var konto = modifykontoLoad.Text;
            BindingKonto fkonto;
            if (_manager.ExistsName(konto))
            {
                fkonto = _manager.GetKonten().First(a => a.KontenName == konto);

            }
            else if (_manager.ExistsNummer(konto))
            {
                fkonto = _manager.GetKonten().First(a => a.KontenNummer == konto);
            }
            else
            {
                MessageBox.Show("Konto existiert nicht!", "Fehler!", MessageBoxButton.OK);
                return;
            }

            modifykontoName.Text = fkonto.KontenName;
            modifykontoNummer.Text = fkonto.KontenNummer;
            modifykontoAktiv.IsChecked = fkonto.Aktiv;
        }

        private void Buchungensollplus_Click(object sender, RoutedEventArgs e)
        {
            buchungensoll.ItemsSource ??= new List<BuchungenKonto>();

            List<BuchungenKonto> source = buchungensoll.ItemsSource.Cast<BuchungenKonto>().ToList();
            source.Add(new BuchungenKonto());

            buchungensoll.ItemsSource = source;
        }

        private void Buchungensollminus_Click(object sender, RoutedEventArgs e)
        {
            List<BuchungenKonto> source = buchungensoll.ItemsSource.Cast<BuchungenKonto>().ToList();

            if (buchungensoll.SelectedIndex >= 0)
            {
                source.RemoveAt(buchungensoll.SelectedIndex);
            }

            buchungensoll.ItemsSource = source;
        }

        private void BuchungenhabenPlus_Click(object sender, RoutedEventArgs e)
        {
            buchungenhaben.ItemsSource ??= new List<BuchungenKonto>();

            List<BuchungenKonto> source = buchungenhaben.ItemsSource.Cast<BuchungenKonto>().ToList();
            source.Add(new BuchungenKonto());

            buchungenhaben.ItemsSource = source;
        }

        private void BuchungenhabenMinus_Click(object sender, RoutedEventArgs e)
        {
            List<BuchungenKonto> source = buchungenhaben.ItemsSource.Cast<BuchungenKonto>().ToList();


            if (buchungenhaben.SelectedIndex >= 0)
            {
                source.RemoveAt(buchungenhaben.SelectedIndex);
            }

            buchungenhaben.ItemsSource = source;
        }

        private void Buchungensave_Click(object sender, RoutedEventArgs e)
        {
            List<BuchungenKonto> sourcessoll = buchungensoll.ItemsSource.Cast<BuchungenKonto>().ToList();
            List<BuchungenKonto> sourceshaben = buchungenhaben.ItemsSource.Cast<BuchungenKonto>().ToList();

            _manager.Buchung(sourcessoll,sourceshaben);

        }

        private void FKontenListe_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var index = FKontenListe.SelectedIndex;

            BindingKonto konto = (BindingKonto) FKontenListe.Items[index];

            FKontenBuchungListe.ItemsSource = _manager.GetBuchungen(konto.KontenNummer);

        }
    }

    public class BuchungenKonto
    {
        public string KontoNummer { get; set; }
        public float Wert { get; set; }
    }
}
