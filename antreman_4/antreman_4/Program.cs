using System;

namespace antreman_4
{
    class Program
    {

        /*
         şifre koruması adına sesli harflerin karşılığında verilen sembollere dönüştürür ve şifreyi tersten yazarak gösterir
        amaç: bilgileri daha gizli tutabilmek
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine(sifreOlustur("aslkaldslfa"));
            Console.Read();
        }

        static string sifreOlustur(string sifre)
        {
            string tersMetin = tersCevir(sifre);

            string yeniSifre = "";

            foreach (char harf in tersMetin)
            {
                if (harf == 'a')
                    yeniSifre += '?';
                else if (harf == 'e')
                    yeniSifre += '*';
                else if (harf == 'i' || harf == 'ı')
                    yeniSifre += '=';
                else if (harf == 'ö' || harf == 'o')
                    yeniSifre += '&';
                else if (harf == 'u' || harf == 'ü')
                    yeniSifre += '+';
                else
                    yeniSifre += harf;
            }

            return yeniSifre;
        }
        static string tersCevir(string sifre)
        {
            string tersHali = "";

            for (int x = sifre.Length - 1; x >= 0; x--)
                tersHali += sifre[x];

            return tersHali;
        }

    }
}