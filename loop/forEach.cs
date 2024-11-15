using System;

namespace forSaanSkalDetBli {


    class ForEachLoop {

        string[] forStr = { "I", "Love", "C#", "Dette", "er", "gøy" };

        public void forStrLoop() {
            foreach (var arg in forStr) {
                Console.WriteLine(arg);
            }
        }
    }
    
}


