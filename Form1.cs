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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Yunus Emre Tunç-201913709059
            //Berkay Yakup Sevim-201913709055
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            //Müzik dosyası eklemek için dosya konumuna gidiyor
            for (int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
            {
                listBox1.Items.Add(openFileDialog1.SafeFileNames[i].ToString());
                listBox2.Items.Add(openFileDialog1.FileNames[i].ToString());
                //Müzik listesine ekleme işlemini dosyanın adı ve dosyanın konumu olacak şekilde iki ayrı listboxa ekliyoruz
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            //Buton 4'e yani Müzik Listesini temizle butonuna basıldığı zaman listbox1 ve listbox2'deki kayıtlı dosyaları siliyoruz
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            //Müzik Listesini silmemize rağmen son çalan müzik ara bellekten çalmaya devam etmemesi için müziği durduruyoruz
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            //Buton 7'ye yani Müzik Başa Sar butonuna basıldığı zaman o anda çalınan müziği stop komutu ile müziği durduyoruz ve müzik başa sarılıyor
        }

       
        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume -= 5;
            //Buton 9'a yani Ses Azalt butonuna her basıldığı zaman ses düzeyi 5 seviye düşüyor
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume += 5;
            //Buton 8'e yani Ses Arttır butonuna her basıldığı zaman ses düzeyi 5 seviye artıyor
        }
        int i = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            //Tek butonda durdur ve başlat işlemini yapmak için bir if yapısı tasarladık. Bir adet sayaç kullanarak,
            //mod özelleğini kullanarak butonun text'ini ve işlemini değiştirdik 
            if (i % 2 == 0)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                button3.Text = "Başlat";
            }
            if (i % 2 == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                button3.Text = "Durdur";
            }
            i++;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listbox 1'den bir index seçildiği zaman listbox 2'deki adres eşitlenir axWindowsMediaPlayer1.Ctlcontrols.play()
            //kullanılarak müzik adresine ulaşılır ve başlatılır
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            axWindowsMediaPlayer1.URL = listBox2.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            button3.Text = "Durdur";
            //Buton 3 müzik listeden ilk defa seçildiği zaman hala başlat yazıyor olmasını bu şekilde engelledik ve durdur yazdırdık
        }
        int j = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            //Tek butonda sesi aç ve sesize al işlemini yapmak için bir if yapısı tasarladık. Bir adet sayaç kullanarak,
            //mod özelleğini kullanarak butonun text'ini ve işlemini değiştirdik
            if (j % 2 == 0)
            {
                axWindowsMediaPlayer1.settings.mute = true;
                button2.Text = "Sesi Aç";
            }
            if (j % 2 == 1)
            {
                axWindowsMediaPlayer1.settings.mute = false;
                button2.Text = "Sessize Al";
            }
            j++;
            
        }
         private void button5_Click(object sender, EventArgs e)
        {
            Uyarı cikis = new Uyarı();
            cikis.Show();
            //Buton 5'e yani Çıkış butonuna basıldığı zaman oluşturmuş olduğumuz Uyarı form dosyasını kullanıcıya
            //gösterip çıkmak istediğinden emin olup olmadığını soruyoruz.
        }

    }
}
