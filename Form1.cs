using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace Yazlab2_Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int IterasyonSayisi = 0;
        int HedefOdacik = 0;
        int BaslangicOdacik = 0;
        double OgrenmeKatsayisi = 0.8;
       public static int MatrisEleman = 0;
        public static ArrayList listPath;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnVeriCek_Click(object sender, EventArgs e)
        {
            BaslangicOdacik = Convert.ToInt32(txtBaslangicOdacik.Text);
            HedefOdacik = Convert.ToInt32(txtHedefOdacik.Text);
            IterasyonSayisi = Convert.ToInt32(txtIterasyonSayisi.Text);
         
            string DosyaYolu = @"C:\Users\Hazer\Desktop\yazlab2_proje1\input.txt";
            FileStream fs = new FileStream(DosyaYolu, FileMode.Open, FileAccess.Read);

            // Dosya Yolu ile txt'nin yolu , FileAccess erişim izni sebebi , FileMode açılacağını veya oluşturulcağını

            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                listBox1.Items.Add(yazi);
                //  lblDeneme.Text=lblDeneme.Text+yazi+" ";
                yazi = sw.ReadLine();
            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();

            MatrisEleman = listBox1.Items.Count;
            MessageBox.Show(MatrisEleman.ToString());
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            char[] ayrac = { ',' };
            //Kaclik Matris eleman sayisidir
            double [,] RMatrisi = new double[MatrisEleman,MatrisEleman];
            for(int i =0 ; i<MatrisEleman; i++)
            {
                for(int j = 0; j<MatrisEleman; j++)
                {
                    RMatrisi[i, j] = -1;
                    // ilk durumda r matrisinin bütün elemanlarını -1 yaptık
                    
                }
            }

            
            
            for (int i=0;i<listBox1.Items.Count;i++)
            {
                string tmp = listBox1.Items[i].ToString();
                string[] rakamlar=tmp.Split(ayrac);
                int ElemanSayisi = rakamlar.Length;

                for(int j=0;j<ElemanSayisi;j++)
                {

                    RMatrisi[i, Convert.ToInt32(rakamlar[j])]=0;
                    RMatrisi[Convert.ToInt32(rakamlar[j]), i] = 0;
                   
                }

            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string tmp = listBox1.Items[i].ToString();
                string[] rakamlar = tmp.Split(ayrac);
                int ElemanSayisi = rakamlar.Length;

                for (int j = 0; j < ElemanSayisi; j++)
                {
                   
                    if (Convert.ToInt32(rakamlar[j]) == HedefOdacik)
                    {
                        RMatrisi[i, Convert.ToInt32(rakamlar[j])] = 100;
                    }
                }

            }
            RMatrisi[HedefOdacik, HedefOdacik] = 100;
            

            string dosya_yolu = @"C:\Users\Hazer\Desktop\yazlab2_proje1\outR.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            
            
            
            for (int i = 0; i < MatrisEleman; i++)
            {
                for (int j = 0; j < MatrisEleman; j++)
                {
                    
                    sw.Write(RMatrisi[i, j]+"   ");
                    
                }
                sw.WriteLine("\n");
            }
            
            sw.Close();
            fs.Close();


             double[,] QMatrisi = new double[MatrisEleman, MatrisEleman];

            for (int i = 0; i < MatrisEleman; i++)
            {
                for (int j = 0; j < MatrisEleman; j++)
                {
                    QMatrisi[i, j] = 0;

                }
            }

            // random gitme olayını tasarla
            int iterasyon = 0;
            int nextState = 0;
            int nextNextState = 0;
            int randomSayi = 0;
            int firstState = 0;
            int previousState = 0;
            

            ArrayList randomDegerler = new ArrayList();

            while (iterasyon<IterasyonSayisi)
            {
                /*         Random rnd = new Random();
                         firstState = rnd.Next(MatrisEleman);



                             do
                         {
                             previousState = firstState;

                             string tmp2 = listBox1.Items[firstState].ToString();
                             string[] rakamlar2 = tmp2.Split(ayrac);
                             int ElemanSayisi2 = rakamlar2.Length;


                             Random rnd2 = new Random();
                             int rastgele = rnd2.Next(ElemanSayisi2);
                             nextState = Convert.ToInt32(rakamlar2[rastgele]);

                             string tmp3 = listBox1.Items[nextState].ToString();
                             string[] rakamlar3 = tmp3.Split(ayrac);
                             int ElemanSayisi3 = rakamlar3.Length;

                             double maxQDegeri = QMatrisi[nextState,
                                     Convert.ToInt32(rakamlar3[0])]; ;

                             for(int a=0;a<rakamlar3.Length;a++)
                             {
                                 if(QMatrisi[nextState,
                                     Convert.ToInt32(rakamlar3[a])]>maxQDegeri)
                                 {
                                     maxQDegeri = QMatrisi[nextState,
                                     Convert.ToInt32(rakamlar3[a])];
                                 }                        
                             }


                             //maxı bul
                             QMatrisi[firstState, nextState] = RMatrisi[firstState, nextState] + OgrenmeKatsayisi*maxQDegeri;
                             //max'ı bul



                             firstState = nextState;


                         } while (RMatrisi[previousState, nextState] != 100);

                             */
                for (int i = 0; i < MatrisEleman; i++)
                {
                    //next state random seçiliyor  
                    string tmp2 = listBox1.Items[i].ToString();
                    string[] rakamlar2 = tmp2.Split(ayrac);
                    int ElemanSayisi2 = rakamlar2.Length;


                    Random rnd = new Random();
                    int rastgele = rnd.Next(ElemanSayisi2);
                     nextState = Convert.ToInt32(rakamlar2[rastgele]);


                    //next state random seçildi
                    string tmp3 = listBox1.Items[nextState].ToString();
                    string[] rakamlar3 = tmp3.Split(ayrac);
                    int ElemanSayisi3 = rakamlar3.Length;

                   

                    double maxQDegeri = QMatrisi[nextState,
                                     Convert.ToInt32(rakamlar3[0])]; ;

                    for (int a = 0; a < rakamlar3.Length; a++)
                    {
                        if (QMatrisi[nextState,
                            Convert.ToInt32(rakamlar3[a])] > maxQDegeri)
                        {
                            maxQDegeri = QMatrisi[nextState,
                            Convert.ToInt32(rakamlar3[a])];
                        }
                    }

                    QMatrisi[i, nextState] = RMatrisi[i, nextState] + (OgrenmeKatsayisi *maxQDegeri);

                }


                iterasyon++;

            }
            /*
            
            */


            int ilkdizin = BaslangicOdacik;
            int sondizin = HedefOdacik;
            int hedefdizin = 0;
            double max = 0;
            listPath = new ArrayList();
            
            listPath.Add(ilkdizin);
            int dolas = 0;
            int dolasFor = 0;

            while(dolas<MatrisEleman)
            { 

                for(dolasFor=0;dolasFor<MatrisEleman;dolasFor++)
            {
              
                if(QMatrisi[ilkdizin, dolasFor] >max)
                {
                        if(!listPath.Contains(dolasFor))
                        { 
                    max = QMatrisi[ilkdizin, dolasFor];
                    hedefdizin = dolasFor;
                        }
                    }
            }
                dolasFor = 0;
                listPath.Add(hedefdizin);
                if(hedefdizin==sondizin)
                {
                    break;
                }
                ilkdizin = hedefdizin;
                dolas++;
                max = 0;
                
            }

            string dosya_yolu3 = @"C:\Users\Hazer\Desktop\yazlab2_proje1\outPath.txt";

            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs3 = new FileStream(dosya_yolu3, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw3 = new StreamWriter(fs3);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.

            sw3.Write("Yol Çizdiriliyor...");

            foreach (object eleman in listPath)
                {
                sw3.Write(eleman.ToString() + "        ");
            }


            sw3.Close();
            fs3.Close();


            string dosya_yolu2 = @"C:\Users\Hazer\Desktop\yazlab2_proje1\outQ.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs2 = new FileStream(dosya_yolu2, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw2 = new StreamWriter(fs2);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.



            for (int i = 0; i < MatrisEleman; i++)
            {
                for (int j = 0; j < MatrisEleman; j++)
                {

                    sw2.Write(QMatrisi[i, j] + "   ");

                }
                sw2.WriteLine("\n");
            }

            sw2.Close();
            fs2.Close();
        }
        Labirent frm = new Labirent();
        private void button1_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Hide();
        }
    }
}
/*
 * using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace Yazlab2_Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int IterasyonSayisi = 0;
        int HedefOdacik = 0;
        int BaslangicOdacik = 0;
        double OgrenmeKatsayisi = 0.8;
        int MatrisEleman = 0;
        public static ArrayList listPath;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnVeriCek_Click(object sender, EventArgs e)
        {
            BaslangicOdacik = Convert.ToInt32(txtBaslangicOdacik.Text);
            HedefOdacik = Convert.ToInt32(txtHedefOdacik.Text);
            IterasyonSayisi = Convert.ToInt32(txtIterasyonSayisi.Text);
         
            string DosyaYolu = @"C:\Users\Hazer\Desktop\input.txt";
            FileStream fs = new FileStream(DosyaYolu, FileMode.Open, FileAccess.Read);

            // Dosya Yolu ile txt'nin yolu , FileAccess erişim izni sebebi , FileMode açılacağını veya oluşturulcağını

            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                listBox1.Items.Add(yazi);
                //  lblDeneme.Text=lblDeneme.Text+yazi+" ";
                yazi = sw.ReadLine();
            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();

            MatrisEleman = listBox1.Items.Count;
            MessageBox.Show(MatrisEleman.ToString());
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            char[] ayrac = { ',' };
            //Kaclik Matris eleman sayisidir
            double [,] RMatrisi = new double[MatrisEleman,MatrisEleman];
            for(int i =0 ; i<MatrisEleman; i++)
            {
                for(int j = 0; j<MatrisEleman; j++)
                {
                    RMatrisi[i, j] = -1;
                    // ilk durumda r matrisinin bütün elemanlarını -1 yaptık
                    
                }
            }

            
            
            for (int i=0;i<listBox1.Items.Count;i++)
            {
                string tmp = listBox1.Items[i].ToString();
                string[] rakamlar=tmp.Split(ayrac);
                int ElemanSayisi = rakamlar.Length;

                for(int j=0;j<ElemanSayisi;j++)
                {

                    RMatrisi[i, Convert.ToInt32(rakamlar[j])]=0;
                    RMatrisi[Convert.ToInt32(rakamlar[j]), i] = 0;
                   
                }

            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string tmp = listBox1.Items[i].ToString();
                string[] rakamlar = tmp.Split(ayrac);
                int ElemanSayisi = rakamlar.Length;

                for (int j = 0; j < ElemanSayisi; j++)
                {
                   
                    if (Convert.ToInt32(rakamlar[j]) == HedefOdacik)
                    {
                        RMatrisi[i, Convert.ToInt32(rakamlar[j])] = 100;
                    }
                }

            }
            RMatrisi[HedefOdacik, HedefOdacik] = 100;
            

            string dosya_yolu = @"C:\Users\Hazer\Desktop\outR.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            
            
            
            for (int i = 0; i < MatrisEleman; i++)
            {
                for (int j = 0; j < MatrisEleman; j++)
                {
                    
                    sw.Write(RMatrisi[i, j]+"   ");
                    
                }
                sw.WriteLine("\n");
            }
            
            sw.Close();
            fs.Close();


             double[,] QMatrisi = new double[MatrisEleman, MatrisEleman];

            for (int i = 0; i < MatrisEleman; i++)
            {
                for (int j = 0; j < MatrisEleman; j++)
                {
                    QMatrisi[i, j] = 0;

                }
            }

            // random gitme olayını tasarla
            int iterasyon = 0;
            

            while (iterasyon<IterasyonSayisi)
            {
                for(int i=0;i<MatrisEleman ;i++)
                {
                   
                    string tmp2 = listBox1.Items[i].ToString();
                    string[] rakamlar2 = tmp2.Split(ayrac);
                    int ElemanSayisi2 = rakamlar2.Length;


                    Random rnd = new Random();
                    int rastgele = rnd.Next(ElemanSayisi2);
                    int nextState = Convert.ToInt32(rakamlar2[rastgele]);



                    string tmp3 = listBox1.Items[nextState].ToString();
                    string[] rakamlar3 = tmp3.Split(ayrac);
                    int ElemanSayisi3 = rakamlar3.Length;


                    Random rnd2 = new Random();
                    int rastgele2 = rnd2.Next(ElemanSayisi3);
                    int nextNextState = Convert.ToInt32(rakamlar3[rastgele2]);

                    QMatrisi[i, nextState] =( RMatrisi[i, nextState] + OgrenmeKatsayisi * QMatrisi[nextState, nextNextState]);
                    
                }

                iterasyon++;
            }

            int ilkdizin = BaslangicOdacik;
            int sondizin = HedefOdacik;
            int hedefdizin = 0;
            double max = 0;
            listPath = new ArrayList();
            
            listPath.Add(ilkdizin);
            int dolas = 0;
            int dolasFor = 0;

            while(dolas<MatrisEleman)
            { 

                for(dolasFor=0;dolasFor<MatrisEleman ; dolasFor++)
            {
              
                if(QMatrisi[ilkdizin, dolasFor] >max)
                {
                        if(!listPath.Contains(dolasFor))
                        { 
                    max = QMatrisi[ilkdizin, dolasFor];
                    hedefdizin = dolasFor;
                        }
                    }
            }
                dolasFor = 0;
                listPath.Add(hedefdizin);
                if(hedefdizin==sondizin)
                {
                    break;
                }
                ilkdizin = hedefdizin;
                dolas++;
                max = 0;
                
            }

            string dosya_yolu3 = @"C:\Users\Hazer\Desktop\outPath.txt";

            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs3 = new FileStream(dosya_yolu3, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw3 = new StreamWriter(fs3);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.

            sw3.Write("Yol Çizdiriliyor...");

            foreach (object eleman in listPath)
                {
                sw3.Write(eleman.ToString() + "        ");
            }


            sw3.Close();
            fs3.Close();


            string dosya_yolu2 = @"C:\Users\Hazer\Desktop\outQ.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs2 = new FileStream(dosya_yolu2, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw2 = new StreamWriter(fs2);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.



            for (int i = 0; i < MatrisEleman; i++)
            {
                for (int j = 0; j < MatrisEleman; j++)
                {

                    sw2.Write(QMatrisi[i, j] + "   ");

                }
                sw2.WriteLine("\n");
            }

            sw2.Close();
            fs2.Close();
        }
    }
}





namespace Yazlab2_Proje1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }


        int KaclikMatris = 3;
        int ElemanSayisi = 9;
        int sayac = 0;
        int locationX = 100;
        int locationY = 100;
        ArrayList list = new ArrayList();
       
        public void Form2_Load(object sender, EventArgs e)
        {
            // DİNAMİK ŞEKİLDE BUTON EKLE SONRA ONLARA PATHLERE GÖRE RENK VER !
            // BUTTONLARIN BİÇİMLERİNİ DEĞİŞ
            //BUTTON CLİCKLEYİNCE sıradaki adımı göstersin
            list.Add(1);
            list.Add(4);
            list.Add(3);
            list.Add(6);
            list.Add(7);

            for (int i=0;i<KaclikMatris; i++)
            { 
                for(int j=0;j<KaclikMatris ;j++)
                { 
            Button btn = new Button();
            btn.Name = "btn_" + sayac.ToString();

            btn.AutoSize = false;

            btn.Size = new System.Drawing.Size(60, 60);
            btn.Text = sayac.ToString();
            btn.Font = new Font(btn.Font.FontFamily.Name, 18);

            btn.Location = new System.Drawing.Point(locationX, locationY);
            btn.BackColor = System.Drawing.Color.Red;
                    if(list.Contains(sayac))
                    {
                        btn.BackColor = System.Drawing.Color.Yellow;
                    }
                    btn.Click += Btn_Click;
            this.Controls.Add(btn);
            sayac++;
            locationX = locationX + 60;

                }
                locationY = locationY + 60;
           
                locationX = 100;
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Name);
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void btnYolGoster_Click(object sender, EventArgs e)
        {
      
        }
    }
}
*/