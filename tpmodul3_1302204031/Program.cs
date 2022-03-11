// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;

namespace tpmodul3_1302204031
{
    public class Program
    {//Dewa_Arjuna_1302204031
        public static void Main()
        {
            Console.WriteLine("Table-Driven");
            KodePos kode = new KodePos();
            kode.getKodePos();
            Console.WriteLine("\nState-Based");
            DoorMachine pintu = new DoorMachine();
            pintu.kunci();
        }
    }//Dewa_Arjuna_1302204031
}