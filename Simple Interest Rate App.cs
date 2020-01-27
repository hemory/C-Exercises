  static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the simple interest calculator");
            Console.WriteLine("This app will calculate how much interest you have paid over a given number of years");
            Console.WriteLine();

            //Principle
            Console.WriteLine("Enter principle...");
            decimal principle = Convert.ToDecimal(Console.ReadLine());

            if (principle < 0)
            {
                Console.WriteLine("Principle cannot be negative");
                principle = 0;
            }


            //Interest
            Console.WriteLine("Enter interest rate...");
            decimal interest = Convert.ToDecimal(Console.ReadLine());

            if (interest < 0)
            {
                Console.WriteLine("Interest cannot be negative");
                interest = 0;
            }

            //Term
            Console.WriteLine("How many years do you want to calculate for?");
            decimal term = Convert.ToDecimal(Console.ReadLine());

            if (term < 0)
            {
                Console.WriteLine("Term cannot be negative");
                term = 0;
            }



            //Calculate interest rate
            decimal interestRate = interest / 100;

            //Calculate interest paid
            decimal interestPaid = principle * interest * term;

            //calculate total
            decimal total = principle + interestPaid;

            //Output
            Console.WriteLine();

            Console.WriteLine($"Principle: {principle}");
            Console.WriteLine($"Interest: {interest}");
            Console.WriteLine();
            Console.WriteLine($"Interest paid: {interestPaid}");
            Console.WriteLine($"Total: {total}");


            Console.ReadLine();

        }