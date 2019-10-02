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

namespace Hinh_Hoc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HN_Click(object sender, RoutedEventArgs e)
        {
            txbtext.Items.Clear();
            txbtext.Items.Add("STT   \t\t   Canh   \t\t   Chu Vi   \t\t   Dien Tich");
            txbtext.Items.Add("***********************************************************************************");

            HinhVuong[] hv = new HinhVuong[5];

            for (int i = 0; i < 5; i++)
            {

                hv[i] = new HinhVuong((double)rand.Next(2, 15));
                hv[i].ChuVi();
                hv[i].DienTich();

                txbtext.Items.Add((i + 1).ToString() +"\t\t     "
                                 + hv[i].Canh + "\t\t     "
                                 + hv[i].chuvi.ToString() + "\t\t\t       "
                                 + hv[i].dientich.ToString());
            }
        }

        private void HT_Click(object sender, RoutedEventArgs e)
        {
            txbtext.Items.Clear();
            txbtext.Items.Add("STT \t\t Ban Kinh \t\t Chu Vi \t\t Dien Tich");
            txbtext.Items.Add("***********************************************************************************");

            List<HinhTron> ht = new List<HinhTron>();
            int dem = 1;

            for (int i = 0; i < Int32.Parse(txbso.Text); i++)
                ht.Add(new HinhTron((double)rand.Next(2, 15)));

            foreach(HinhTron Ht in ht)
            { 
                Ht.ChuVi();
                Ht.DienTich();

                txbtext.Items.Add(dem.ToString() + "\t\t      "
                                + Ht.BanKinh + "\t\t\t "
                                + Ht.chuvi.ToString() + "\t\t"
                                + Ht.dientich.ToString());
                dem += 1;
            }
        }
    }
}
