using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {


            Random rnd = new Random();
            int ilkSayi = 0, ikinciSayi = 0, toplamPuan = 0, sayilarinToplami = 0, girilenCevap = 0, dogruCevapSayisi = 0, yanlisCevapSayisi = 0;
            char devam;
            do
            {

                ilkSayi = rnd.Next(1, 100);
                ikinciSayi = rnd.Next(1, 100);
                sayilarinToplami = ilkSayi + ikinciSayi;
                Console.WriteLine("{0} + {1} = ?", ilkSayi, ikinciSayi);
                Console.Write("Cevabınız : ");
                girilenCevap = Convert.ToInt32(Console.ReadLine());
                if (girilenCevap == sayilarinToplami)
                {
                    Console.WriteLine("Tebrikler Bildiniz");
                    toplamPuan += 5;
                    dogruCevapSayisi += 1;
                }
                else
                {
                    Console.WriteLine("Üzgünüm Bilemediniz");
                    toplamPuan -= 2;
                    yanlisCevapSayisi += 1; 
                }
                Console.Write("Tekrar Oynamak istiyormusunuz(evet veya hayir)?");
                devam = Convert.ToChar(Console.ReadLine());

            } while (devam == 'E' || devam == 'e');

            Console.WriteLine("Toplam Doğru Cevap Sayınız {0}, Yanlış Cevap Sayınız {1}, Toplamda Almış Olduğunuz Puan {2}", dogruCevapSayisi, yanlisCevapSayisi, toplamPuan);

        }
    }
}
