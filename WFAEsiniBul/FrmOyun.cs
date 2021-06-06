using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAEsiniBul
{
    public partial class FrmOyun : Form
    {
        int satirAdet = 4;
        int sutunAdet = 4;
        int kartBoyut = 75;
        int kartArasi = 5;
        int tiklamaSay=0;
        int acilanKartlar=0;
        int[] bayrakHavuzu;
        int[] bayraklar;
        private readonly ZorlukSeviye _zs;
        FrmYeniOyun _anaform;
        List<PictureBox> acilanlar;
        List<PictureBox> kartlar;

        public int KartAdet => satirAdet * sutunAdet;

        public FrmOyun(FrmYeniOyun anaform, ZorlukSeviye zs)
        {
            _anaform = anaform;
            _zs = zs;
            SeviyeAyarla();
            InitializeComponent();
            acilanlar = new List<PictureBox>();
            BayrakHavuzunuDoldur();
            KartlariDiz();
        }
        private void KartiKapat(PictureBox pb)
        {
            pb.Image = Properties.Resources.yildiz;
        }
        private void KartlariKisaSureliGoster()
        {
            pnlKartlar.Enabled = false;
            foreach (PictureBox item in kartlar)
            {
                KartiAc(item);
            }
            Thread.Sleep(2000);
            foreach (PictureBox item in kartlar)
            {
                KartiKapat(item);
            }
            Application.DoEvents();
            pnlKartlar.Enabled = true;
        }
        private void SeviyeAyarla()
        {
            switch (_zs)
            {
                case ZorlukSeviye.Kolay:
                    satirAdet = sutunAdet = 4;
                    break;
                case ZorlukSeviye.Orta:
                    satirAdet = sutunAdet = 6;
                    break;
                case ZorlukSeviye.Zor:
                    satirAdet = sutunAdet = 8;
                    break;
                default:
                    throw new Exception("Olmayan bir seviye seçimi yapıldı.");
            }
        }
        private void BayrakHavuzunuDoldur()
        {
            bayrakHavuzu = Enumerable.Range(1, 263).ToArray();
            Islemler.Karistir(bayrakHavuzu);
        }
        private void KartlariDiz()
        {
            BayraklariDoldur();
            kartlar = new List<PictureBox>();
            pnlKartlar.Width = sutunAdet * (kartArasi + kartBoyut) - kartArasi;
            pnlKartlar.Height = satirAdet * (kartArasi + kartBoyut) - kartArasi;
            ClientSize = new Size(pnlKartlar.Width + 20, pnlKartlar.Height + 60);
            for (int i = 0; i < KartAdet; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Click += Pb_Click;
                kartlar.Add(pb);
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
            tiklamaSay++;
            lblDeneme.Text = "Deneme Adedi : " + tiklamaSay;
            if (acilanlar.Count == 1 && pb == acilanlar[0])
                return;//acilana tekrar tıkladıysa
            if (acilanlar.Count == 2)
                AcikOlanlariKapat();
            acilanlar.Add(pb);
            KartiAc(pb);
            if (acilanlar.Count == 2 && AcilanlarAyniysa())
            {
                Thread.Sleep(500); //aynı olan açık kartları gizlenmeden önce görebilsin
                AcikKartlariGizle();
                acilanKartlar += 2;
                if(acilanKartlar == KartAdet)
                {
                    DialogResult dr = MessageBox.Show($"Tebrikler {tiklamaSay} denemede kazandınız! Yeniden oynamak ister misiniz?","Oyun bitti",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Yes)
                    {
                        this.Close();
                        _anaform.Show();
                    }
                    else
                        Application.Exit();
                }
            }
        }
        private void KartiAc(PictureBox pb)
        {
            int indeks = (int)pb.Tag;
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("_" + bayraklar[indeks]);
            pb.Refresh(); // picture boxu tekrar çiz yeniden boya
        }
        private bool AcilanlarAyniysa()
        {
            int indeks1 = (int)acilanlar[0].Tag;
            int indeks2 = (int)acilanlar[1].Tag;

            return bayraklar[indeks1] == bayraklar[indeks2];
        }

        private void AcikKartlariGizle()
        {
            foreach (PictureBox item in acilanlar)
            {
                item.Visible = false;
            }
        }

        private void AcikOlanlariKapat()
        {
            foreach (PictureBox item in acilanlar)
            {
                KartiKapat(item);
            }
            acilanlar.Clear();
        }

        private void BayraklariDoldur()
        {
            bayraklar = new int[KartAdet];
            Array.Copy(bayrakHavuzu, bayraklar, KartAdet / 2);
            Array.Copy(bayrakHavuzu, 0, bayraklar, KartAdet / 2, KartAdet / 2);
            Islemler.Karistir(bayraklar);
        }
        private void FrmOyun_FormClosing(object sender, FormClosingEventArgs e)
        {
            _anaform.Show();
        }

        private void FrmOyun_Shown(object sender, EventArgs e)
        {
            KartlariKisaSureliGoster();
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            _anaform.Show();
        }
    }
}
