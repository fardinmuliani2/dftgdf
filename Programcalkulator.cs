
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Artists
{

    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("holiday", "green day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("kashmir", "led Zeppelin", 150);
            Console.WriteLine(Song.songCount);

            Console.ReadLine();
        }


    }
}
