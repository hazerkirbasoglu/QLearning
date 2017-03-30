using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System;

namespace Yazlab2_Proje1
{
    public partial class Labirent : Form
    {
        public Labirent()
        {
            InitializeComponent();
        }

        private void Labirent_Load(object sender, EventArgs e)
        {

        }
        ArrayList list = new ArrayList();
        double matris = 0;
        System.Drawing.Graphics grafiknesne;

        private void Labirent_Paint(object sender, PaintEventArgs e)
        {
            int x = 50,y=50,width=50,height=50;

            list = Form1.listPath;
            grafiknesne = this.CreateGraphics();
            matris = Form1.MatrisEleman;
            matris = Math.Sqrt(matris);
            int sayac = 0;
            int adimSayisi =1;
            int adimSayisi2 = 1;

            for(int i=0;i<matris ;i++)
            {
                for (int j = 0; j < matris; j++)
                {
                    
                        
                        Pen firca1 = new Pen(System.Drawing.Color.Red, 5);
                       grafiknesne.DrawRectangle(firca1, x, y, width, height);

                    if (list.Contains(sayac))
                    {
                        if (list.IndexOf(sayac) == 0)
                        {
                            Pen firca2 = new Pen(System.Drawing.Color.White, 5);
                            grafiknesne.DrawRectangle(firca2, x, y, width, height);
                        }
                    }
                    if (list.Contains(sayac))
                    {
                        if (list.IndexOf(sayac) == list.Count-1)
                        {
                            Pen firca3 = new Pen(System.Drawing.Color.White, 5);
                            grafiknesne.DrawRectangle(firca3, x, y, width, height);
                        }
                    }

                    if (list.Contains(sayac))
                    {
                        if (list.IndexOf(sayac) == 1)
                        {
                            Pen firca4 = new Pen(System.Drawing.Color.White, 5);
                            grafiknesne.DrawRectangle(firca4, x, y, width, height);
                        }
                    }
                    if (list.Contains(sayac))
                    {
                        if (list.IndexOf(sayac) == list.Count - 2)
                        {
                            Pen firca5 = new Pen(System.Drawing.Color.White, 5);
                            grafiknesne.DrawRectangle(firca5, x, y, width, height);
                        }
                    }

                    if (list.Contains(sayac))
                        {
                            adimSayisi = list.IndexOf(sayac) + 1;

                            Font yazi = new Font("Georgia", 7, FontStyle.Bold);
                            Brush firca = new SolidBrush(Color.Blue);
                            grafiknesne.DrawString(adimSayisi + ".Adim", yazi, firca, x + 10, y + 10);
                        }

                        x = x + 50;
                        sayac++;
                    }
                
                x = 50;
                y = y + 50;
            }

        }


       
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
