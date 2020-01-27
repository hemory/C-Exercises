 static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the grade calculator");
            Console.WriteLine("This app will calculate your grade based on a traditional grading scale");
            Console.WriteLine();

            Console.WriteLine("What is your percentage?");
            double grade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            bool isanA = grade > 90;
            bool isaB = grade < 90 && grade > 79;
            bool isaC = grade < 80 && grade > 69;
            bool isaD = grade < 70 && grade > 59;
            bool isanE = grade < 60;

            if (isanA)
            {
                Console.WriteLine("You got an A");
            }
            if (isaB)
            {
                Console.WriteLine("You got a B");
            }
            if (isaC)
            {
                Console.WriteLine("You got a C");
            }
            if (isaD)
            {
                Console.WriteLine("You got a D");
            }
            if (isanE)
            {
                Console.WriteLine("You got an E");
            }
          





            Console.ReadLine();

        }