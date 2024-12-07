using storageSystem;


class Proram
{

    static int x;

    static void Main()
    {
        Storage st = new Storage();

        do
        {

            Console.WriteLine("[1] Add Clothes items\n[2] Add food items\n[3] Add Electronics items\n[4] Remove item\n[5] Print items\n[0] EXIT");

            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 0:
                    return;
                case 1:
                    st.addClothes();
                    break;
                case 2:
                    st.addFood();
                    break;
                case 3:
                    st.addElectronics();
                    break;
                case 4:
                    st.removeItem();
                    break;
                case 5:
                    st.printListItems();
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        } while (x != 0);

    }
}
