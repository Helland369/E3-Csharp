using System;


namespace calendar {


    class Calendar {

        static int inPut;

        public void switchCalendar() {
            Console.WriteLine("Enter a number to find a day of the week");
            inPut = Convert.ToInt32(Console.ReadLine());

            switch (inPut) {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    switchCalendar();
                    break;
            }


        }
    }
}


