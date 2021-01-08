using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarMiYokMuIndeksli
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] sehirler = { "Eskişehir", "İstanbul", "Ankara", "İzmir", "Diyarbakır", "Sinop", "Muğla" };
            bool devamEt = true;

            do
            {
                Console.WriteLine("Bir şehir giriniz: ");
                string girilenSehir = Console.ReadLine();
                bool varMi = false;
                for (int i = 0; i < sehirler.Length; i++)
                {
                    if (sehirler[i] == girilenSehir)
                    {
                        Console.WriteLine($"Aradığın şehir {girilenSehir} bulundu ve indeksi {i}");
                        varMi = true;
                        devamEt = true;
                        break;
                    }
                }

                if (!varMi)
                {
                    Console.WriteLine("Böyle bir şehir bizde yok");
                    Console.WriteLine("Başka bir şehir aramak ister misin? (Evet/Hayır)");
                    string cevap = Console.ReadLine();
                    switch (cevap)
                    {
                        case "evet":
                        case "Evet":
                        case "EVET":
                            devamEt = false;
                            break;
                        case "hayır":
                        case "Hayır":
                        case "HAYIR":
                            break;
                        default:
                            break;
                    }
                } 
            } while (!devamEt);
            Console.ReadKey();
        }
    }
}
