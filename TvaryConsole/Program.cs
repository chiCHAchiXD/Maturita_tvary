using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//pridano
using TvaryKnihovna;

namespace TvaryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tvar t1 = new Tvar();   //nelze

            Obdelnik o1 = new Obdelnik();

            //napiste metodu                                                        zadej sirku pro o2: 
            //soukroma staticka vraci int jmenuje se VstupZKlavesnice a ma parametr String
            //Console.Write("zadej sirku pro o2: ");
            //string sirkaStr = Console.ReadLine();
            int sirka = Program.VstupZKlavesnice("zadej sirku pro o2: "); //Convert.ToInt32(sirkaStr);

            //Console.Write("zadej vysku pro o2: ");
            //string vyskaStr = Console.ReadLine();
            //int vyska = Convert.ToInt32(vyskaStr);
            int vyska = Program.VstupZKlavesnice("zadej vysku pro o2: ");

            //Obdelnik o2 = new Obdelnik(7, 4);
            Obdelnik o2 = new Obdelnik(sirka, vyska);

            Kruh k1 = new Kruh();
            Kruh k2 = new Kruh(50);

            Ctverec c1 = new Ctverec();
            Ctverec c2 = new Ctverec(7);

            //spolecne zpracovani vsech objektu v poli tvaru
            Tvar[] poleTvaru = new Tvar[6];    //0..5
            poleTvaru[0] = o1;
            poleTvaru[1] = o2;
            poleTvaru[2] = k1;
            poleTvaru[3] = k2;
            poleTvaru[4] = c1;
            poleTvaru[5] = c2;

            for (int i = 0; i < poleTvaru.Length; i++)
            {
                Console.WriteLine(poleTvaru[i].ToString());
                poleTvaru[i].Nakreslit();
                Console.WriteLine("obvod je " + poleTvaru[i].VypocitatObvod());
                Console.WriteLine("obsah je " + poleTvaru[i].VypocitatObsah());

                Console.WriteLine("-------------");
            }
        }

        private static int VstupZKlavesnice(string hlaseniProUzivatele)
        {
            Console.Write(hlaseniProUzivatele);
            string sirkaStr = Console.ReadLine();
            int sirka = Convert.ToInt32(sirkaStr);
            return sirka;
        }


    }
}
