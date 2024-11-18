


class Program {

    static void Main() {

        var range = 250; // size of int array?
        var counts = new int[range]; // range is the size of this?
        string text = "something"; // decleare a string
        while (!string.IsNullOrWhiteSpace(text)) // do this for as long as there is no whitspace, null or empty string.
        {
            text = Console.ReadLine(); // std::cin
            foreach (var character in text.ToUpper() ?? string.Empty) // if text is not null eval text ?? if text is null eval empty string
            {
                counts[(int)character]++; // counts is an array we convert character from char to int.
            }
            for (var i = 0; i < range; i++) // loop range
            {
                if (counts[i] > 0) // if there is characters do
                {
                    var character = (char)i; // convert index back to char
                    double newCount = 100 * counts[i] / text.Length;
                    Console.WriteLine(character + " - " + newCount + "%"); // print char + anount of.
                }
            }
        }
    }
}
