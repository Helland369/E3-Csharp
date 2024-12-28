namespace organTransplant;

public class Hospital
{
        private int _input;
        
        private Patient _bernt;
        private Patient _kåre;
        
        private Random _rand = new Random();
        
        public Hospital()
        { 
            _kåre = new Patient("Kåre", 2);
            _bernt = new Patient("Bernt", 1);
        }

        public void HospitalMenu()
        { 
            int random = _rand.Next(0, 100);
            
            while (true)
            {
                Console.WriteLine("[1] Attempt to give Bernt a new Kidney\n" +
                                  "[0] Exit\n");
                
                _input = Convert.ToInt32(Console.ReadLine());
                
                switch (_input)
                {
                    case 0:
                        return;
                    case 1:
                        if (random < 80)
                        {
                            _kåre.TransplantKidney(_bernt);
                        }
                        else
                        {
                            Console.WriteLine("Transplant failed :(");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }        
            }
        }
}
