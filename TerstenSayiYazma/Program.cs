using System;

namespace TerstenSayiYazma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool tekrarSayiAl = true;
            int girilenSayi = 0;
            while (tekrarSayiAl)
            {
                Console.Write("Pozitif bir tam sayı giriniz: ");
                girilenSayi = int.Parse(Console.ReadLine());
                if(girilenSayi <= 0)
                    tekrarSayiAl = true;
                else
                    tekrarSayiAl = false;
            }

            int tempSayi = girilenSayi;
            string tempStr = "";
            while(tempSayi % 10 >= 0 && tempSayi != 0)
            {
                tempStr = tempStr + (tempSayi % 10);
                tempSayi = tempSayi / 10; 
            }

            Console.WriteLine("Girilen Sayı : "+girilenSayi);
            Console.WriteLine("Sayının Tersi: "+int.Parse(tempStr));

            Console.ReadLine();

            // Girdi -> 879
            // Çıktı -> 978

            // Girdi -> 1003
            // Çıktı -> 3001

            // Girdi -> 3000
            // Çıktı -> 3
        }
    }
}
