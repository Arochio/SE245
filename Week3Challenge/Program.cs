//import libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Challenge {
    class Program {
        static void Main (string[] args) {

            for(int i = 1; i < 11; i++) {
                for(int j = 1; j < 11; j++) {
                    Console.Write(i*j);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }

        }
    }
}