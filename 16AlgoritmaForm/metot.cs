using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16AlgoritmaForm
{
    class metot
    {
        public string Kıyasla2(int x)
        {
            if (x % 2 == 0)
                return "Girilen sayı çifttir.";
            else if(!(x%2==0))
                return "Girilen sayı tektir.";
            else
                return " ";
        }

        public int yüzSayi(Array a)
        {
            int toplam = 0; // statik metodda global değişken tanımlanamaz.dinamikte tanımlanabilir.
            foreach (var item in a)
            {
                
                toplam = toplam + Convert.ToInt32(item);
            }
            return toplam;
        }
        //Dinamik metot ve Array kullanıldı.

        public  string Dortislem(int a, int b, string islemtipi)
        {
            switch (islemtipi)
            {
                case "+":
                    return (a + b).ToString() ;
                    break;
                case "-":
                    return (a - b).ToString();
                    break;
                case "*":
                    return (a * b).ToString();
                    break;
                case "/":
                    return (a / b).ToString();
                    break;
            }
            return "";
        }
        //Dinamik metot ile yapıldı.Nesne ile çağırılacak.

        public static string Faktöriyel(ref int a)
        {
            int fktryl = 1;
            for(int i=1; i<a; i++)
            {
                fktryl = fktryl * i;
            }
            return fktryl.ToString();
        }
        //static metot ile yapıldı.

        public static string MükemmelSayı(int a)
        {
            int n, toplam = 0;
            for (n = 1; n < a; n++)
            {
                if (a % n == 0)
                {
                    toplam = toplam + n;
                }
            }
            if (toplam == a)
            {
                return "Mükemmel sayıdır.";
            }
            else
            {
                return "Mükemmel sayı değildir.";
            }
            return " ";
        }    
        //static metot ile yapıldı.Public ile diğer sınıfta görülmesi sağlanıyor

    }
}
