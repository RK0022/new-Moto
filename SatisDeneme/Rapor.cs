using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisDeneme
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void bGöster_Click(object sender, EventArgs e)
        {
            Cursor.Current= Cursors.WaitCursor;
            DateTime baslangic = DateTime.Parse(dtBaslangic.Value.ToShortDateString());
            DateTime bitis= DateTime.Parse(dtBitis.Value.ToShortDateString());
            bitis=bitis.AddDays(1);
            using (var db=new MarketDBEntities())
            {
                if (listFiltrelemeTürü.SelectedIndex==0)
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).Load();
                    var islemozet=db.IslemOzet.Local.ToBindingList();
                    gridListe.DataSource= islemozet;

                    tSatisNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Nakit)).ToString("C2");
                    tSatisKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Kart)).ToString("C2");

                    tIadeNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true ).Sum(x => x.Nakit)).ToString("C2");
                    tIadeKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Kart)).ToString("C2");

                    tGelirNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Nakit)).ToString("C2");
                    tGelirKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Nakit)).ToString("C2");

                    tGiderNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Nakit)).ToString("C2");
                    tGiderKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gider== true).Sum(x => x.Nakit)).ToString("C2");
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
