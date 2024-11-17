namespace changeWord {


    class WordChange {

        string str;

        public string changeTheWord() {

            Console.WriteLine("Input a word that contains the letter E and se what happens!");
            str = Console.ReadLine();

            //int index = str.IndexOf("e");

            string nstr = str.Replace("e", "a");

            Console.WriteLine(nstr);

            return str;
        }
    }

    
}
