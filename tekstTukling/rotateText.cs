namespace rotateText {


    class RotateTxt {

        string str;

        public string rotate() {

            Console.WriteLine("Enter any word you want to rotate it");
            str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++) {

                Console.Write(str[str.Length - i - 1]);
            }

            return str;
        }

    }

    
}


