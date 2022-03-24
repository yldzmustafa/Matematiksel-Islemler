using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16AlgoritmaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s = 0, n = 0, toplam = 0;

        #region 2 Sayı Kıyaslama
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (radioButton2.Checked)
                {

                    if (textBox1.Text == "")
                        MessageBox.Show("Sayı girişlerini kontrol edin!");

                    else if (textBox2.Text == "")
                        MessageBox.Show("Sayı girişlerini kontrol edin!");

                    else
                    {
                        int s1 = 0, s2 = 0;

                        s1 = int.Parse(textBox1.Text);
                        s2 = int.Parse(textBox2.Text);
                        if (s1 < s2)
                        {
                            snclbl.Text = "1.Sayı 2.Sayıdan Küçüktür.";
                        }
                        else if (s1 > s2)
                        {
                            snclbl.Text = "1.Sayı 2.Sayıdan Büyüktür.";
                        }
                        else
                        {
                            snclbl.Text = "İki Sayı Birbirine eşittir.";
                        }

                    }
                }
            }
            else if (radioButton18.Checked)
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                snclbl.Text = Kıyasla(a, b);
            }

        }

        private string Kıyasla(int a, int b)
        {
            if (a > b)
                return "1.sayı 2.sayıdan sayıdan büyüktür.";
            else if (a < b)
                return "1.sayı 2.sayıdan sayıdan küçüktür.";
            else if (a == b)
                return "İki sayı birbirine eşittir.";
            else
                return " ";
        }          
        //Aynı sınıfta dinamik metot ile yapıldı.
        #endregion

        #region Tek sayı çift sayı
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (radioButton3.Checked)
                {
                    if (textBox3.Text == "")
                    {
                        MessageBox.Show("Sayı girişi yapmalısınız!");
                    }
                    else
                    {
                        int s = 0;

                        s = int.Parse(textBox3.Text);
                        if (s % 2 == 0)
                            snclbl1.Text = "Girilen sayı çift sayıdır.";
                        else if (s % 2 != 0)
                            snclbl1.Text = "Girilen sayı tek sayıdır.";
                        else
                            snclbl1.Text = "Lütfen sayı girişi yapınız !";
                    }
                }
            }
            else if (radioButton18.Checked)
            {
                int a = int.Parse(textBox3.Text);
                metot nesne = new metot();
                snclbl1.Text = nesne.Kıyasla2(a);
            }

        }  //Tek sayı çift sayı

        //Metodu metot clasından dinamik olduğu için nesne ile çağırılıyor.
        #endregion

        #region 100 sayının Toplamı
        int girilenyüzsayi = 0, yüzsayitoplam = 0, sayacyüz = 0;
        int[] dizi = new int[100];
        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox4.Text == "")
                    MessageBox.Show("Sayı girişi yapmalısınız!");
                else
                {

                    if (sayacyüz < 100)
                    {
                        snclbl3.Text = "";
                        girilenyüzsayi = Convert.ToInt32(textBox4.Text);
                        yüzsayitoplam += girilenyüzsayi;
                        listBox1.Items.Add(girilenyüzsayi);
                        sayacyüz++;
                    }
                    else
                    {
                        snclbl3.Text += yüzsayitoplam.ToString();
                        textBox4.Visible = false;
                        button3.Visible = false;
                    }
                }


                //snclbl3.Text = "";
                //girilenyüzsayi = Convert.ToInt32(textBox4.Text);
                //yüzsayitoplam += girilenyüzsayi;
                //listBox1.Items.Add(girilenyüzsayi);       
                //sayacyüz++;
                //if (sayacyüz == 5)
                //{
                //    snclbl3.Text += yüzsayitoplam.ToString();
                //}
            }

            else if (radioButton18.Checked)
            {
                if (sayacyüz < 100)
                {
                    dizi[sayacyüz] = Convert.ToInt32(textBox4.Text);
                    listBox1.Items.Add(dizi[sayacyüz]);
                    sayacyüz++;
                }
                else if (sayacyüz == 100)
                {
                    button3.Visible = false;
                }
                metot nesne = new metot();
                snclbl3.Text = nesne.yüzSayi(dizi).ToString();
                // başına metodun bulunduğusınıf adını ekledik ekledik.
                //farklı sınıfta statik metot çağırdığımız için.


            }
        }

        //Metodu metot classında

        #endregion

        #region Negatif-Pozitif
        int x = 0, ns = 0, ps = 0, sayac = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox5.Text == "")
                    MessageBox.Show("Sayı girişi yapmalısınız!");
                else
                {
                    sayac = sayac + 1;

                    if (sayac <= 20)
                    {
                        sayiadedi.Text = "";
                        sayiadedi.Text += sayac.ToString();
                        x = Convert.ToInt32(textBox5.Text);
                        if (x < 0)
                        {
                            ns = ns + 1;
                            snclbl4.Text = ns.ToString();
                        }
                        else
                            ps = ps + 1;
                        snclbl5.Text = ps.ToString();
                    }
                }

            }
            else if (radioButton18.Checked)
            {

                if (sayac < 20)
                {
                    int a = Convert.ToInt32(textBox5.Text);
                    sayac++;
                    sayiadedi.Text = sayac.ToString();


                    Kıyasla3(a);
                }
                else if (sayac == 20)
                {
                    button4.Visible = false;
                }
            }
        }

        private void Kıyasla3(int a)
        {
            if (a < 0)
            {
                ns += 1;
            }
            else if (a > 0)
            {

                ps += 1;
            }
            snclbl5.Text = ps.ToString();
            snclbl4.Text = ns.ToString();
        }  //Void ile yapıldı.

        #endregion

        #region Sıfır girilene kadar toplam

        int sıfırx = 0, sıfıtoplam = 0;
        private void button5_Click_2(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                if (textBox6.Text == "")
                    MessageBox.Show("Sayı girişi yapmalısınız!");
                else
                {
                    sıfırx = Convert.ToInt32(textBox6.Text);
                    if (sıfırx != 0)
                    {
                        listBox2.Items.Add(sıfırx);
                        sıfıtoplam = sıfıtoplam + sıfırx;
                    }
                    else
                    {
                        textBox6.Visible = false;
                        button5.Visible = false;
                        snclbl6.Text = sıfıtoplam.ToString();
                    }
                }

            }
            else if (radioButton18.Checked)
            {
                int a = int.Parse(textBox6.Text);
                listBox2.Items.Add(a);
                snclbl6.Text = Sıfırtopla(a);
                if (a == 0)
                {
                    button5.Visible = false;
                }
            }
        }
        static int sıfırtoplam = 0;
        static int m = 0;
        static string Sıfırtopla(params int[] b)
        {
            //aynı class ta dinamik formu görüyor ama static görmüyor.

            if (m < b.Length)
            {
               if (b[m] != 0)
               {
                 //listBox2.Items.Add(b);

                 sıfırtoplam += b[m];
                 return "";
               }
               else
               {
                return sıfırtoplam.ToString();
               }
            return "";
                m++;
            }
            return "";
        }  
        //static metot ve params ile oluşturuldu.
        //Çıkan sonuç string değer olarak döndürülüp metottan çıkıldı.
        #endregion

        #region Teklerin karesi Çiftlerin Küpü

        int a = 0;
        int npsayi = 0, npsayac = 0, ct = 0, tt = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox7.Text == "")
                {
                    MessageBox.Show("Sayı girişi yapmalısınız!");
                }
                else
                {
                    if (npsayac < 20)
                    {
                        npsayi = Convert.ToInt32(textBox7.Text);
                        npsayac++;
                        if (npsayi % 2 == 0)
                        {
                            ct = ct + npsayi * npsayi * npsayi;
                            listBox4.Items.Add(npsayi);
                        }
                        else
                        {
                            tt = tt + npsayi * npsayi;
                            listBox3.Items.Add(npsayi);
                        }
                    }
                    else
                    {
                        textBox7.Visible = false;
                        button7.Visible = false;
                    }
                }
            }
            else if (radioButton18.Checked)
            {
                if (npsayac <= 20)
                {
                   
                    a = Convert.ToInt32(textBox7.Text);
                    Yazdır(a);
                    npsayac++;
                    if(npsayac==20)
                       button7.Visible = false;
                }
               

            }

        }    //sayı girişi yapan buton
        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                snclbl7.Text = tt.ToString();
                snclbl8.Text = ct.ToString();
            }
            else if (radioButton18.Checked)
            {

                if (npsayac <= 20)
                {
                    npsayac++;
                    KareKup(a);

                }
            }


        }    //sonucu yazdıran buton

        private void KareKup(int b)
        {

            snclbl7.Text = tt.ToString();
            snclbl8.Text = ct.ToString();
        }    
        //Hesabı yazdıran metot void ile yapılarak sonuç metotta yazdırıldı.

        private void Yazdır(int a)
        {
            if (a % 2 == 0)
            {
                listBox4.Items.Add(a);
                ct = ct + a * a * a;
            }
            else
            {
                listBox3.Items.Add(a);
                tt = tt + a * a;
                
            }
        }        
        //listeleyen ve hesaplayan metot void ile yapıldı.
        #endregion

        #region Vize-Final

        int vnot = 0, fnot = 0, bnot = 0;
        float vfort = 0;
        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox8.Text == "" || textBox9.Text == "")
                {
                    MessageBox.Show("Lütfen Sayı Girişi Yapınız !");
                }
                else
                {

                    vnot = Convert.ToInt32(textBox8.Text);
                    fnot = Convert.ToInt32(textBox9.Text);
                    vfort = Convert.ToSingle(0.4 * vnot + 0.6 * fnot);
                    if (vfort < 50)
                    {
                        snclbl9.Text = "Kaldı Bütünleme Notu Gir.";
                        textBox10.Visible = true;

                    }
                    else
                        snclbl9.Text = "Geçti.";
                }

                if (snclbl9.Text == "Geçti.")
                {
                    textBox10.Visible = false;
                }

            }
            else if (radioButton18.Checked)
            {
                float a = int.Parse(textBox8.Text);
                float b = int.Parse(textBox9.Text);
               snclbl9.Text= Vizefinal(a, b);
            }

        }  
        //vizefinal hesabı yapan buton

        public string Vizefinal(float a, float b)
        {
            float toplam = 0, ort = 0;
            ort = Convert.ToSingle(0.4 * a + 0.6 * b);
            if (ort < 50)
            {
                textBox10.Visible = true;
                return $"{ort} Kaldınız";
                
            }
            else
                return $"{ort} Geçtiniz";
        }  
        //vizefinal hesabı yapan metot dinamik metot ile yapıldı.

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox10.Text == "")
                {
                    MessageBox.Show("Lütfen Sayı Girişi Yapınız !");
                }
                else
                {

                    bnot = Convert.ToInt32(textBox10.Text);
                    if (bnot < 50)
                    {
                        snclbl10.Text = "Kaldı.";
                    }
                    else
                        snclbl10.Text = "Geçti.";
                }

            }
            else if (radioButton18.Checked)
            {
                int a = int.Parse(textBox10.Text);
                snclbl10.Text = Büt(a);
            }
        }    
        //Büte girmesi durumunu yapan buton

        private static string Büt(int a)
        {
            if (a > 50)
            {
                return "Geçtiniz";
            }
            else
                return "Kaldınız";
        }  
        //bütünlemeyi yapan static metot
        #endregion

        #region Basit Dört İşlem

        int hspsayi1 = 0, hspsayi2 = 0, hspsonuc = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox11.Text == "" || textBox12.Text == "")
                {
                    MessageBox.Show("Lütfen Sayı Girişi Yapınız !");
                }
                else
                {

                    string islemtipi = comboBox1.Text;
                    switch (islemtipi)
                    {
                        case "+":
                            hesapsnc.Text = (hspsayi1 + hspsayi2).ToString();
                            break;
                        case "-":
                            hesapsnc.Text = (hspsayi1 - hspsayi2).ToString();
                            break;
                        case "*":
                            hesapsnc.Text = (hspsayi1 * hspsayi2).ToString();
                            break;
                        case "/":
                            hesapsnc.Text = (hspsayi1 / hspsayi2).ToString();
                            break;
                        default:
                            hesapsnc.Text = "Lütfen işlem tipini doğru seçiniz!";
                            break;
                    }
                }
            }
            else if (radioButton18.Checked)
            {
                int a = int.Parse(textBox11.Text);
                int b = int.Parse(textBox12.Text);
                string islemtipi = comboBox1.Text;
                metot nesne = new metot();
                hesapsnc.Text = nesne.Dortislem(a, b, islemtipi);
            }

        }   


        //Dört işlem metodu dinamik olduğu için metot sınıfından nesne oluşturularak çağırıldı.

        #endregion

        #region 10 öğrencinin dönem sonu ortalaması

        int dsvnot = 0, dsfnot = 0, dstoplam = 0, dsort = 0, sayacds = 1, snfort = 0, topla = 0;
        float ort = 0;

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sonucds.Text = (dstoplam / 10).ToString();
            }
            else if (radioButton18.Checked)
            {
                sonucds.Text = Orthesapla(topla).ToString();
            }
        }  //Ortalamayı sonuca yazdıran buton
        
        private int Orthesapla(int topla)
        {
            snfort = topla / 10;
            return snfort;
        } 
        //dinamik metot.Çıkan sonuç int değer olarak döndürüldü ve metottan çıkıldı.
        //ortalama sonucunu yazdıran metot

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                if (textBox13.Text == "" || textBox14.Text == "")
                {
                    MessageBox.Show("Lütfen Sayı Girişi Yapınız !");
                }
                else
                {
                    if (sayacds <= 10)
                    {
                        dsvnot = Convert.ToInt32(textBox13.Text);
                        dsfnot = Convert.ToInt32(textBox14.Text);
                        dsort = Convert.ToInt32(0.4 * dsvnot + 0.6 * dsfnot);
                        listBox5.Items.Add(dsort);
                        dstoplam = dstoplam + dsort;
                        sayacds++;
                    }
                    else
                        button12.Visible = false;
                }
            }
            else if (radioButton18.Checked)
            {
                if (sayac < 10)
                {
                    float vize = Convert.ToSingle(textBox13.Text);
                    float final = Convert.ToSingle(textBox14.Text);
                    Ort(vize, final);
                    sayac++;
                }

            }
        }  //notları girdiğimiz buton
        
        private string Ort(float vize, float final)
        {

            ort = Convert.ToSingle(0.4 * vize + 0.6 * final);
            topla += Convert.ToInt32(ort);
            return listBox5.Items.Add(ort).ToString();

            if (sayac == 10)
                button12.Visible = false;
            return "";
        }  
        //dinamik metot ile yapıldı çıkan sonuç string değer olarak döndürülüp metottan çıkıldı.
        //ortalamayı hesaplayan ve listeleyen metot

        #endregion

        #region Faktöriyel

        int fktrylsayı = 0, sayacfktryl = 1, fktryl = 1;
        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox15.Text == "")
                    MessageBox.Show("Lütfen Sayı Girişi Yapınız !");
                else
                {

                    fktryl = 1;

                    fktrylsayı = Convert.ToInt32(textBox15.Text);
                    for (sayacfktryl = 1; sayacfktryl < fktrylsayı; sayacfktryl++)
                    {
                        fktryl += fktryl * sayacfktryl;
                    }
                    fktrylsonuc.Text = fktryl.ToString();
                }
            }
            else if (radioButton18.Checked)
            {
                int a = int.Parse(textBox15.Text);
                fktrylsonuc.Text = metot.Faktöriyel(ref a);
            }

        }

        //Metodu Metot Cllasında
        #endregion

        #region Çarpım Tablosu
        int snccrpm = 0;
        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                string girdi = comboBox2.Text;
                if (girdi == "1'ler")
                {
                    listBox6.Items.Clear();
                    for (int i = 1; i <= 1; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            snccrpm = i * j;
                            listBox6.Items.Add(i + " * " + j + " = " + snccrpm.ToString());
                        }
                    }
                }
                else if (girdi == "2'ler")
                {
                    listBox6.Items.Clear();
                    for (int i = 2; i <= 2; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            snccrpm = i * j;
                            listBox6.Items.Add(i + " * " + j + " = " + snccrpm.ToString());
                        }
                    }
                }
                else if (girdi == "3'ler")
                {
                    listBox6.Items.Clear();
                    for (int i = 3; i <= 3; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            snccrpm = i * j;
                            listBox6.Items.Add(i + " * " + j + " = " + snccrpm.ToString());
                        }
                    }
                }
                else if (girdi == "4'ler")
                {
                    listBox6.Items.Clear();
                    for (int i = 4; i <= 4; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            snccrpm = i * j;
                            listBox6.Items.Add(i + " * " + j + " = " + snccrpm.ToString());
                        }
                    }
                }
                else if (girdi == "5'ler")
                {
                    listBox6.Items.Clear();
                    for (int i = 5; i <= 5; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            snccrpm = i * j;
                            listBox6.Items.Add(i + " * " + j + " = " + snccrpm.ToString());
                        }
                    }
                }
                else if (girdi == "6'lar")
                {
                    listBox6.Items.Clear();
                    for (int i = 6; i <= 6; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            snccrpm = i * j;
                            listBox6.Items.Add(i + " * " + j + " = " + snccrpm.ToString());
                        }
                    }
                }
                else if (girdi == "7'ler")
                {
                    listBox6.Items.Clear();
                    for (int i = 7; i <= 7; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            snccrpm = i * j;
                            listBox6.Items.Add(i + " * " + j + " = " + snccrpm.ToString());
                        }
                    }
                }
                else if (girdi == "8'ler")
                {
                    listBox6.Items.Clear();
                    for (int i = 8; i <= 8; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            snccrpm = i * j;
                            listBox6.Items.Add(i + " * " + j + " = " + snccrpm.ToString());
                        }
                    }
                }
                else if (girdi == "9'lar")
                {
                    listBox6.Items.Clear();
                    for (int i = 9; i <= 9; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            snccrpm = i * j;
                            listBox6.Items.Add(i + " * " + j + " = " + snccrpm.ToString());
                        }
                    }
                }
                else if (girdi == "10'lar")
                {
                    listBox6.Items.Clear();
                    for (int i = 10; i <= 10; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            snccrpm = i * j;
                            listBox6.Items.Add(i + " * " + j + " = " + snccrpm.ToString());
                        }
                    }
                }
            }
            else if (radioButton18.Checked)
            {
                string islem = comboBox2.Text;
                int i;
                int j = 0;
                Carpım(islem,out i,ref j);

            }

        }

        private void Carpım(string islem,out int i,ref int j)
        {
            i = 0;
            listBox6.Items.Clear();
            switch (islem)
            {

                case "1'ler":
                    for (j = 1; j <= 10; j++)
                    {
                        i = 1;
                        snccrpm = i * j;

                        listBox6.Items.Add(i + "*" + j + "=" + snccrpm.ToString());
                    }
                    break;
                case "2'ler":
                    for (j = 1; j <= 10; j++)
                    {
                        i = 2;
                        snccrpm = i * j;
                        listBox6.Items.Add(i + "*" + j + "=" + snccrpm.ToString());
                    }
                    break;
                case "3'ler":
                    for (j = 1; j <= 10; j++)
                    {
                        i = 3;
                        snccrpm = i * j;
                        listBox6.Items.Add(i + "*" + j + "=" + snccrpm.ToString());
                    }
                    break;
                case "4'ler":
                    for (j = 1; j <= 10; j++)
                    {
                        i = 4;
                        snccrpm = i * j;
                        listBox6.Items.Add(i + "*" + j + "=" + snccrpm.ToString());
                    }
                    break;
                case "5'ler":
                    for (j = 1; j <= 10; j++)
                    {
                        i = 5;
                        snccrpm = i * j;
                        listBox6.Items.Add(i + "*" + j + "=" + snccrpm.ToString());
                    }
                    break;
                case "6'lar":
                    for (j = 1; j <= 10; j++)
                    {
                        i = 6;
                        snccrpm = i * j;
                        listBox6.Items.Add(i + "*" + j + "=" + snccrpm.ToString());
                    }
                    break;
                case "7'ler":
                    for (j = 1; j <= 10; j++)
                    {
                        i = 7;
                        snccrpm = i * j;
                        listBox6.Items.Add(i + "*" + j + "=" + snccrpm.ToString());
                    }
                    break;
                case "8'ler":
                    for (j = 1; j <= 10; j++)
                    {
                        i = 8;
                        snccrpm = i * j;
                        listBox6.Items.Add(i + "*" + j + "=" + snccrpm.ToString());
                    }
                    break;
                case "9'lar":
                    for (j = 1; j <= 10; j++)
                    {
                        i = 9;
                        snccrpm = i * j;
                        listBox6.Items.Add(i + "*" + j + "=" + snccrpm.ToString());
                    }
                    break;
                case "10'lar":
                    for (j = 1; j <= 10; j++)
                    {
                        i = 10;
                        snccrpm = i * j;
                        listBox6.Items.Add(i + "*" + j + "=" + snccrpm.ToString());
                    }
                    break;
                default:
                    listBox6.Items.Add("Seçim yap!");
                    break;
            }
        }    
        //void metoduyla yapıldı ve out ref kullanıldı.
        //out başlangıç değeri verilmeyen,ref başlangıç değeri verilen değişkeni değiştirme.
        #endregion

        #region Girilen Sayı Kaç Basamaklı

        int bsmksayı = 0, bsmkbol = 0, bsmk = 0;
        private void button15_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox16.Text == "")
                {
                    MessageBox.Show("Lütfen Sayı Girişi Yapınız !");
                }
                else
                {
                    bsmk = 0;
                    bsmksayı = Convert.ToInt32(textBox16.Text);
                    if (bsmksayı >= 1)
                    {
                        bsmkbol = bsmksayı / 10;
                        bsmk++;
                        while (bsmkbol >= 1)
                        {
                            bsmkbol = bsmkbol / 10;
                            bsmk++;
                        }
                        bsmksonuc.Text = bsmk + " basamaklıdır.";

                    }
                }
            }
            else if (radioButton18.Checked)
            {
                int a = int.Parse(textBox16.Text);
                bsmksonuc.Text = basamak(a);
            }


        }

        private static string basamak(int a)
        {
            int bsmkbol = 0, bsmk = 0;

            if (a >= 1)
            {
                bsmkbol = a / 10;
                bsmk++;

                while (bsmkbol >= 1)
                {
                    bsmkbol = bsmkbol / 10;
                    bsmk++;
                }
                return bsmk + " basamaklıdır.";
            }
            return (bsmk + 1).ToString() + " basamaklıdır.";
        }  
        //static metod ile yapıldı.Çıkan değer string olarak döndürüldü
        #endregion

        #region Mağaza İndirimi

        int ürün = 0, tplmürünfiyat = 0, indirim = 0;
        private void button16_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ürün = Convert.ToInt32(textBox17.Text);
                tplmürünfiyat = Convert.ToInt32(textBox18.Text);
                if (ürün < 5)
                {
                    tplmindirim.Text = "%20 İndirim Uygulandı.";
                    tplmürünfiyat = Convert.ToInt32(0.8 * tplmürünfiyat);
                    tplmfyt.Text = tplmürünfiyat.ToString();
                }
                else if (ürün >= 5)
                {
                    tplmindirim.Text = "%50 indirim Uygulandı.";
                    tplmürünfiyat = Convert.ToInt32(0.5 * tplmürünfiyat);
                    tplmfyt.Text = tplmürünfiyat.ToString();
                }
                else
                    tplmindirim.Text = "Ürün girmediğiniz için indirim uygulanamadı.";
            }
            else if (radioButton18.Checked)
            {
                int ürün = int.Parse(textBox17.Text);
                int fiyat = int.Parse(textBox18.Text);
                Magaza(ürün, fiyat);
            }
        }

        private void Magaza(int ürün, int fiyat)
        {
            if (ürün >= 5)
            {
                tplmindirim.Text = "%50 indirim uygulandı.";
                tplmfyt.Text = (fiyat * 0.5).ToString();
            }
            else
            {
                tplmindirim.Text = "%20 indirim uygulandı.";
                tplmfyt.Text = (fiyat * 0.8).ToString();
            }
        }  
        //void ile yapıldı.
        #endregion

        #region Kod1-2-3 e göre KDV girme

        private void button17_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string kdv = comboBox3.Text;
                if (kdv == "Kod1")
                {
                    kdvsonuc.Text = "Girdiğiniz Tekstil ürünlerine \n %25 KDV uygulanacaktır.";
                }
                else if (kdv == "Kod2")
                {
                    kdvsonuc.Text = "Girdiğiniz Gıda ürünlerine \n %20 KDV uygulanacaktır.";
                }
                else if (kdv == "Kod3")
                {
                    kdvsonuc.Text = "Girdiğiniz Elektronik ürünlerine \n %30 KDV uygulanacaktır.";
                }
                else
                {
                    kdvsonuc.Text = "Lütfen geçerli bir kod seçiniz.";
                }
            }
            else if (radioButton18.Checked)
            {
                string Kdv = comboBox3.Text;
                kdvsonuc.Text = KDV(Kdv);
            }
        }

        private static string KDV(string kdv)
        {
            if (kdv == "Kod1")
            {
                return "%8 KDV uygulandı.";
            }
            else if (kdv == "Kod2")
            {
                return "%7 KDV uygulandı.";
            }
            else
                return "%10 KDV uygulandı.";
        }  
        //static metot ile yapıldı. aynı sınıfta olduğu için private
        #endregion

        #region 10 sayıdan en küçüğü

        int ü = 0;
        int enkucuksayi = 0, enkucuksayac = 1, referans = 0;
        private void button18_Click(object sender, EventArgs e)
        {
            int sayi9 = 0;
            if (radioButton1.Checked)
            {
                if (textBox19.Text == "")
                {
                    MessageBox.Show("Lütfen Sayı Giriniz!");
                }
                else
                {
                    if (enkucuksayac <= 10)
                    {

                        if (enkucuksayac == 1)
                        {
                            referans = Convert.ToInt32(textBox19.Text);
                            listBox7.Items.Add(referans);
                            textBox19.Clear();

                        }
                        else
                        {
                            enkucuksayi = Convert.ToInt32(textBox19.Text);
                            listBox7.Items.Add(enkucuksayi);
                            textBox19.Clear();

                            if (referans < enkucuksayi)
                            {
                                enkucuksonuc.Text = referans.ToString();
                            }
                            else if (referans > enkucuksayi)
                            {
                                referans = enkucuksayi;
                                enkucuksonuc.Text = referans.ToString();
                            }
                            else
                                enkucuksonuc.Text = referans.ToString();
                        }
                        enkucuksayac++;
                    }
                    else
                    {
                        textBox19.Visible = false;
                        button18.Visible = false;
                    }
                }
            }
            else if (radioButton18.Checked)
            {
                if (ü < 10)
                {
                    sayi9 = Convert.ToInt32(textBox19.Text);
                    listBox7.Items.Add(sayi9);
                    ü++;
                }
                enkucuksonuc.Text = Enkucuk(sayi9).ToString();
            }

        }

        int sayacenkucuk = 0, referansenkucuk = 0;
        int Enkucuk(int b)
        {
            if (sayacenkucuk == 0)
            {
                referansenkucuk = b;
            }
            if (sayacenkucuk < 10)
            {
                if (referansenkucuk > b)
                {
                    referansenkucuk = b;
                }
                sayacenkucuk++;
            }
            return referansenkucuk;
        }   
        //dinamik metot ile yapıldı.Sonuç olarak int değer döndürüp metottan çıkılıyor.
        //Aynı sınıfta olduğu için nesne oluşturulmadan direkt ismi ile metodu çağırdık.
        #endregion

        #region Mükemmel Sayı

        int müksayi, müksayac = 1, müktoplam = 0;
        private void button19_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox20.Text == "")
                {
                    MessageBox.Show("Lütfen Sayı Girişi Yapınız!");
                }
                else
                {
                    müksayi = Convert.ToInt32(textBox20.Text);
                    müktoplam = 0;
                    for (müksayac = 1; müksayac <= müksayi; müksayac++)
                    {
                        if (müksayi % müksayac == 0)
                        {
                            müktoplam = müktoplam + müksayac;
                        }
                        else if (müktoplam == müksayi)
                        {
                            müksonuc.Text = müksayi.ToString() + " mükemmel sayıdır.";
                        }
                        else
                        {
                            müksonuc.Text = müksayi.ToString() + " mükemmel sayı değildir.";
                        }

                    }
                }
            }
            else if (radioButton18.Checked)
            {
                if (textBox20.Text == "")
                {
                    MessageBox.Show("Lütfen Sayı Girişi Yapınız!");
                }
                else
                {
                    if (radioButton10.Checked == true)
                    {
                        int a = Convert.ToInt32(textBox20.Text);
                        müksonuc.Text =metot.MükemmelSayı(a);
                    }
                }

            }
        }

         //Metodu metot sınıfında
        #endregion



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                groupBox17.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox18.Visible = false;

                enkucuksayi = 0;
                enkucuksayac = 1;
                referans = 0;
                enkucuksonuc.Text = "";
                listBox7.Items.Clear();
                textBox19.Visible = true;
                button18.Visible = true;
                textBox19.BackColor = Color.White;

            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton2.Checked)
            {
                
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;

                textBox1.Clear();
                textBox2.Clear();
                snclbl.Text="";

                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
            }
     
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int s1 = 0;
            if (!int.TryParse(textBox1.Text, out s1))
            {

                textBox1.BackColor = Color.Red;
                textBox1.Select();
                return;
            }
            else
            {
                textBox1.BackColor = Color.White;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            int s2 = 0;
            if (!int.TryParse(textBox2.Text, out s2))
            {

                textBox2.BackColor = Color.Red;
                textBox2.Select();
                return;
            }
            else
            {
                textBox2.BackColor = Color.White;
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                groupBox3.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = false;
                groupBox4.Visible = true;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;

                textBox3.Clear();
                snclbl1.Text = "";
                sayac = 0;
                ns = 0;
                ps = 0;

                textBox3.BackColor = Color.White;
            }
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox4_Leave(object sender, EventArgs e)
        {
            int s;
            if (!int.TryParse(textBox4.Text, out s))
            {
                textBox4.BackColor = Color.Red;
                textBox4.Select();
                return;
            }
            else
            {
                textBox4.BackColor = Color.White;
            }
        }
       

        private void textBox3_Leave(object sender, EventArgs e)
        {
            int s;
            if (!int.TryParse(textBox3.Text, out s))
            {
                textBox3.BackColor = Color.Red;
                textBox3.Select();
                return;
            }
            else
            {
                textBox3.BackColor = Color.White;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox7.Visible = false;
            groupBox6.Visible = true;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;

            textBox5.Clear();
            sayiadedi.Text = "";
            snclbl4.Text = "";
            snclbl5.Text = "";
            sayac = 0;
            ns = 0;
            ps = 0;

            textBox5.BackColor = Color.White;
        }
       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton5_Leave(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                groupBox7.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox5.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;

                textBox6.Visible = true;
                button5.Visible = true;
                sıfırx = 0;
                listBox2.Items.Clear();
                snclbl6.Text = "";
                textBox6.Clear();
                sıfıtoplam = 0;

                textBox6.BackColor = Color.White;
            }
        }
        
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            int sıfırx;
            if (!int.TryParse(textBox6.Text, out sıfırx))
            {
                textBox6.BackColor = Color.Red;
                textBox6.Select();
                return;
            }
            else
                textBox6.BackColor = Color.White;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                groupBox8.Visible = true;
                groupBox7.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox5.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;

                textBox7.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                ct = 0;
                tt = 0;
                npsayac = 0;
                textBox7.Visible = true;
                button7.Visible = true;
                snclbl7.Text = "";
                snclbl8.Text = "";

                textBox7.BackColor = Color.White;

            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            int vnot;
            if (!int.TryParse(textBox8.Text, out vnot))
            {
                textBox8.BackColor = Color.Red;
                textBox8.Select();
                return;
            }
            else
                textBox8.BackColor = Color.White;

        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            int fnot;
            if (!int.TryParse(textBox9.Text, out fnot))
            {
                textBox9.BackColor = Color.Red;
                textBox9.Select();
                return;
            }
            else
                textBox9.BackColor = Color.White;
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            int bnot;
            if (!int.TryParse(textBox10.Text, out bnot))
            {
                textBox10.BackColor = Color.Red;
                textBox10.Select();
                return;
            }
            else
                textBox10.BackColor = Color.White;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                groupBox10.Visible = true;
                groupBox9.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox5.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;

                textBox11.Clear();
                textBox12.Clear();
                hesapsnc.Text = "";
                hspsayi1 = 0;
                hspsayi2 = 0;
                comboBox1.SelectedItem = null;

                textBox11.BackColor = Color.White;
            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox12.Text, out hspsayi2))
            {
                textBox12.BackColor = Color.Red;
                textBox12.Select();
                return;
            }
            else
                textBox12.BackColor = Color.White;
        }

        private void textBox14_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox14.Text, out dsfnot))
            {
                textBox14.BackColor = Color.Red;
                textBox14.Select();
                return;
            }
            else
                textBox14.BackColor = Color.White;
        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void textBox15_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox15.Text, out fktrylsayı))
            {
                textBox15.BackColor = Color.Red;
                textBox15.Select();
                return;
            }
            else
                textBox15.BackColor = Color.White;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                groupBox13.Visible = true;
                groupBox12.Visible = false;
                groupBox11.Visible = false;
                groupBox9.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox5.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox10.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;

                listBox6.Items.Clear();
                comboBox2.SelectedItem = null;
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                groupBox14.Visible = true;
                groupBox13.Visible = false;
                groupBox12.Visible = false;
                groupBox11.Visible = false;
                groupBox9.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox5.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox10.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;

                textBox16.Clear();
                bsmk = 0;
                bsmksonuc.Text = "";
                textBox16.BackColor = Color.White;

            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox17.Text, out ürün))
            {
                textBox17.BackColor = Color.Red;
                textBox17.Select();
                return;
            }
            else
                textBox17.BackColor = Color.White;
        }

        private void textBox18_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox18.Text, out ürün))
            {
                textBox18.BackColor = Color.Red;
                textBox18.Select();
                return;
            }
            else
                textBox18.BackColor = Color.White;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            groupBox16.Visible = true;
            groupBox15.Visible = false;
            groupBox12.Visible = false;
            groupBox11.Visible = false;
            groupBox9.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox10.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;

        }

        private void button19_Click(object sender, EventArgs e)
        {
          
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            groupBox18.Visible = true;
            groupBox16.Visible = false;
            groupBox15.Visible = false;
            groupBox12.Visible = false;
            groupBox11.Visible = false;
            groupBox9.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox10.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox17.Visible = false;


            müksonuc.Text = "";
            textBox20.Clear();
            müksayi = 0;
            müksayac = 1;
            müktoplam = 0;
            textBox20.BackColor = Color.White;


        }
      
        private void textBox20_Leave(object sender, EventArgs e)
        {
            if(!int.TryParse(textBox20.Text, out müksayi)){
                textBox20.BackColor = Color.Red;
                textBox20.Select();
                return;
            }
            else
            {
                textBox20.BackColor = Color.White;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox19_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox19.Text, out enkucuksayi))
            {
                textBox19.BackColor = Color.Red;
                textBox19.Select();
                return;
            }
            else
                textBox19.BackColor = Color.White;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            groupBox15.Visible = true;
            groupBox12.Visible = false;
            groupBox11.Visible = false;
            groupBox9.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox6.Visible = false;
            groupBox5.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox10.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox16.Visible = false;
            groupBox17.Visible = false;
            groupBox18.Visible = false;

            textBox17.Clear();
            textBox18.Clear();
            tplmindirim.Text = "";
            tplmfyt.Text = "";
            textBox17.BackColor = Color.White;
            textBox18.BackColor = Color.White;
        }

        private void textBox16_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox16.Text, out bsmksayı))
            {
                textBox16.BackColor = Color.Red;
                textBox16.Select();
                return;
            }
            else
                textBox16.BackColor = Color.White;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                groupBox12.Visible = true;
                groupBox11.Visible = false;
                groupBox9.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox5.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox10.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;

                textBox15.Clear();
                fktryl = 0;
                fktrylsonuc.Text = "";

                textBox15.BackColor = Color.White;
            }
        }

        private void textBox13_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox13.Text, out dsvnot))
            {
                textBox13.BackColor = Color.Red;
                textBox13.Select();
                return;
            }
            else
                textBox13.BackColor = Color.White;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked)
            {
                groupBox11.Visible = true;
                groupBox9.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox5.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox10.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;

                textBox13.Clear();
                textBox14.Clear();
                sonucds.Text = "";
                dsvnot = 0;
                dsfnot = 0;
                dstoplam = 0;
                dsort = 0;
                sayacds = 1;
                sayac = 0;
                topla = 0;
                ort = 0;

                listBox5.Items.Clear();
                button12.Visible = true;

                textBox13.BackColor = Color.White;
                textBox14.BackColor = Color.White;
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox11.Text, out hspsayi1))
            {
                textBox11.BackColor = Color.Red;
                textBox11.Select();
                return;
            }
            else
                textBox11.BackColor = Color.White;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                groupBox9.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox5.Visible = false;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;

                vnot = 0;
                fnot = 0;
                vfort = 0;
                snclbl9.Text = "";
                snclbl10.Text = "";
                textBox8.Clear();
                textBox10.Clear();
                textBox9.Clear();
                textBox10.Visible = false;

                textBox8.BackColor = Color.White;
                textBox9.BackColor = Color.White;
                textBox10.BackColor = Color.White;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            int npsayi;
            if(!int.TryParse(textBox7.Text, out npsayi))
            {
                textBox7.BackColor = Color.Red;
                textBox7.Select();
                return;
            }
            else
            {
                textBox7.BackColor = Color.White;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            int x;
            if (!int.TryParse(textBox5.Text, out x))
            {
                textBox5.BackColor = Color.Red;
                textBox5.Select();
                return;
            }
            else
                textBox5.BackColor = Color.White;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                groupBox3.Visible = false;  
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox5.Visible = true;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                groupBox10.Visible = false;
                groupBox11.Visible = false;
                groupBox12.Visible = false;
                groupBox13.Visible = false;
                groupBox14.Visible = false;
                groupBox15.Visible = false;
                groupBox16.Visible = false;
                groupBox17.Visible = false;
                groupBox18.Visible = false;

                button3.Visible = true;
                textBox4.Visible = true;
                yüzsayitoplam = 0;
                listBox1.Items.Clear();
                sayacyüz = 0;
                snclbl3.Text = "";

                textBox4.Clear();
                textBox4.BackColor = Color.White;

            }
         
        }


    }
}
