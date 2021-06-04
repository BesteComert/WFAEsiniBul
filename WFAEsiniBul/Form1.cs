using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAEsiniBul
{
    public partial class Form1 : Form
    {
        int satirAdet = 4;
        int sutunAdet = 4;
        int kartBoyut = 75;
        int kartArasi = 5;
        int[] bayrakHavuzu;
        int[] bayraklar;
        public int KartAdet => satirAdet * sutunAdet;
        public Form1()
        {
            InitializeComponent();
            BayrakHavuzunuDoldur();
            KartlariDiz();

        }

        private void BayrakHavuzunuDoldur()
        {
            bayrakHavuzu = Enumerable.Range(1, 263).ToArray();
            Islemler.Karistir(bayrakHavuzu);
        }

        private void KartlariDiz()
        {
            BayraklariDoldur();
            pnlKartlar.Width = sutunAdet * (kartArasi + kartBoyut) - kartArasi;
            pnlKartlar.Height = satirAdet * (kartArasi + kartBoyut) - kartArasi;
            ClientSize = new Size(pnlKartlar.Width + 20, pnlKartlar.Height + 20);
            for (int i = 0; i < KartAdet; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Click += Pb_Click;
                pb.Tag = i;
               //pb.Image = Properties.Resources._154;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = Properties.Resources.yildiz;
                pb.Width = kartBoyut;
                pb.Height = kartBoyut;
                pb.BackColor = Color.Pink;
                pb.Left = (i % satirAdet) * (kartBoyut + kartArasi);
                pb.Top = (i / sutunAdet) * (kartBoyut + kartArasi);
                pnlKartlar.Controls.Add(pb);
            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            int indeks = (int)pb.Tag;
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("_" + bayraklar[indeks]);

        }

        private void BayraklariDoldur()
        {
            bayraklar = new int[KartAdet];
            Array.Copy(bayrakHavuzu, bayraklar, KartAdet / 2);
            Array.Copy(bayrakHavuzu, 0, bayraklar, KartAdet / 2, KartAdet / 2);
            Islemler.Karistir(bayraklar);
        }
    }
}
