using IngatlanClassLibrary;
using System;
using System.Collections.Generic;
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

namespace Ingatlan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<IngatlanClass> ingatlanok = new List<IngatlanClass>();
        private List<Resztvevo> resztvevok = new List<Resztvevo>();
        private List<Szerzodes> szerzodesek = new List<Szerzodes>();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void TesztAdatok()
        {
            Resztvevo tesztResztvevo = new Resztvevo();

            tesztResztvevo.VEZETEKNEV = "Madarász";
            tesztResztvevo.KERESZTNEV = "Tibor";
            tesztResztvevo.SZUL_HELY = "Budapest";
            tesztResztvevo.SZUL_IDO = "1982.03.15";
            tesztResztvevo.ANYJA_VEZ = "Bedőcs";
            tesztResztvevo.ANYJA_KER = "Katalin";
            tesztResztvevo.SZIG_SZAM = "031848RA";
            tesztResztvevo.ADO_SZAM = 845123456;
            tesztResztvevo.TIPUS = true;

            resztvevok.Add(tesztResztvevo);

            tesztResztvevo.VEZETEKNEV = "Rudnóy";
            tesztResztvevo.KERESZTNEV = "Róbert";
            tesztResztvevo.SZUL_HELY = "Piliscsaba";
            tesztResztvevo.SZUL_IDO = "2000.01.01";
            tesztResztvevo.ANYJA_VEZ = "Kiss";
            tesztResztvevo.ANYJA_KER = "Ibolya";
            tesztResztvevo.SZIG_SZAM = "123456AB";
            tesztResztvevo.ADO_SZAM = 1234567890;
            tesztResztvevo.TIPUS = false;

            resztvevok.Add(tesztResztvevo);

        }
    }
}
