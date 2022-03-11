using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204031
{
    internal class DoorMachine
    {
        enum State { Terkunci, Terbuka };

        public void kunci()
        {
            State kondisi = State.Terkunci;
            string[] menu = { "Terkunci", "Terbuka" };
            Console.WriteLine("Pintu Terkunci");
            while (kondisi != null)
            {//Dewa_Arjuna_1302204031
                Console.WriteLine("Menu " + menu[(int)kondisi]);
                Console.Write("Masukkan perintah : ");
                string perintah = Console.ReadLine();
                switch (kondisi)
                {//Dewa_Arjuna_1302204031
                    case State.Terkunci:
                        if (perintah == "BukaPintu")
                        {
                            kondisi = State.Terbuka;
                            Console.WriteLine("Pintu tidak terkunci");
                        }
                        else if (perintah == "KunciPintu")
                        {
                            Console.WriteLine("Pintu terkunci");
                        }
                        else
                        {
                            System.Environment.Exit(1);
                        }//Dewa_Arjuna_1302204031
                        break;
                    case State.Terbuka:
                        if (perintah == "KunciPintu")
                        {
                            kondisi = State.Terbuka;
                            Console.WriteLine("Pintu terkunci");
                        }
                        else if (perintah == "BukaPintu")
                        {
                            Console.WriteLine("Pintu tidak terkunci");
                        }
                        else
                        {//Dewa_Arjuna_1302204031
                            System.Environment.Exit(1);
                        }
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
