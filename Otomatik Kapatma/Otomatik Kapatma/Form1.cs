using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomatik_Kapatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Data, H, M, S = 60,Sayac;

        int RdBtnKontrol()
        {
            if (Close_Rbtn.Checked == true)
            {
                return 0;
            }
            else 
            {
                return 1;
            }
        }
        void LanguageControl()
        {
            if(Rb_Btn_Turksih.Checked==true)
            {
                Close_Rbtn.Text = "Kapat";
                Restart_RdBtn.Text = "Yeniden Başlat";
                label1.Text = "Saat :";
                label2.Text = "Dakika :";
                Baslat_Btn.Text = "Başlat";
                Durdur_Btn.Text = "Durdur";
                Cıkıs_Btn.Text = "Çıkış";
                groupBox1.Text = "İşlem";
                groupBox2.Text = "Dil";
                Zaman.Text = "Zaman";
            }
            else if(Rb_Btn_english.Checked==true)
            {
                Close_Rbtn.Text = "Close";
                Restart_RdBtn.Text = "Restart";
                label1.Text = "Hour :";
                label2.Text = "minute :";
                Baslat_Btn.Text = "Start";
                Durdur_Btn.Text = "Stop";
                Cıkıs_Btn.Text = "Exit";
                groupBox1.Text = "Order";
                groupBox2.Text = "Language";
                Zaman.Text = "Time";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Durdur_Btn_Click(object sender, EventArgs e)
        {
                timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 100;
            S = S - 1;
            Lbl_S.Text = S.ToString();
            Lbl_M.Text = (M - 1).ToString();
            Lbl_H.Text = H.ToString();
            if (S == 0)
            {
                M = M - 1;
                Lbl_M.Text = M.ToString();
                S = 60;
            }
            if (M==0)
            {
                H = H - 1;
                Lbl_H.Text = H.ToString();
                M = 60;
                S = 60;
            }
            if(H==-1||M==0 || S==0)
            {
                timer2.Stop();
                Lbl_S.Text = "00";
                Lbl_M.Text = "00";
                Lbl_H.Text = "00";

                switch (Data)
                {
                    case 0:
                        System.Diagnostics.Process.Start("Shutdown", "-f -s  -t 1");
                        break;
                    case 1:
                        System.Diagnostics.Process.Start("ShutDown", "/r -f -t 1");
                        break;   
                }

            }
        }
        private void Baslat_Btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start(); 
            Lbl_H.Text = H.ToString();
            Lbl_M.Text = M.ToString();
            H = Convert.ToInt32(Saat.Value);
            M = Convert.ToInt32(Dakika.Value);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Data = RdBtnKontrol();
            LanguageControl();
        }
    }
}
