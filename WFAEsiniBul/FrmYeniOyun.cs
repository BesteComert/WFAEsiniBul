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
    public partial class FrmYeniOyun : Form
    {
        public FrmYeniOyun()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            ZorlukSeviye zs = rbKolay.Checked ? ZorlukSeviye.Kolay : rbOrta.Checked ? ZorlukSeviye.Orta : ZorlukSeviye.Zor;
            Hide();
            new FrmOyun(this,zs).ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
