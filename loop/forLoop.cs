using System;

namespace forTheLoop {

    class ForLoop {

        string[] str = { "Terje er kul", "Terje er kul", "Terje er kul", "Terje er kul", "Terje er kul" };

        public void forStr() {
            for (int i = 0; i < str.Length; i++) {
                Console.WriteLine(str[i]);
            }
        }
    }
}


