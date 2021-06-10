using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MüzikÇalar
{
    public partial class Uyarı : Form
    {
        public Uyarı()
        {
            InitializeComponent();
        }

        private void Uyarı_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Uyarı formunda evet butonuna basıldığı zaman uygulamayı kapatır
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //Uyarı formunda hayır butonuna basıldığı zaman Uyarı form penceresini kapatır ve müzik listemiz silinmeden kalır
        }
    }
}
