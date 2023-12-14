using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isimSoyisimDondurenKod
{
    class bilgi 
    {
        public void isim(ref string ismi, ref string soyadi,ref int yas)
        {
            ismi = "EFE";
            soyadi ="KAZGAN";
            yas = 25;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim = "Levent";
            string soyadi = "YANIK";
            int yas = 25;
            bilgi bilgi = new bilgi();
            bilgi.isim(ref  isim, ref soyadi, ref yas);

            Console.WriteLine("Önceki değerler döndürüldü");
            Console.WriteLine("ad:" + isim);
            Console.WriteLine("soyad:" + soyadi);
            Console.WriteLine("yas"+yas);

        }
    }
}
