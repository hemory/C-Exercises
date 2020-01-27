static void Main(string[] args)
        {

            Console.WriteLine("Welcome the Split The Bill App");
            Console.WriteLine();

            Console.WriteLine("What was the total of the bill? ");
            double billTotal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many people are splitting the bill?");
            int numOfPeople = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much tip would you like to leave on the total bill in percentage?");
            double tipAmount = Convert.ToDouble(Console.ReadLine());


            //Calculate Tip
            double tipFraction = tipAmount / 100;

            double totalTipAmount = billTotal * tipFraction;
            double totalSplitAmount = totalTipAmount + billTotal;

            double payPerPerson = totalSplitAmount / numOfPeople;

            Console.WriteLine($"Each person will have to pay ${payPerPerson}");
            


            Console.ReadLine();

        }