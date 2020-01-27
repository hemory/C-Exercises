static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the 2020 month generator.");
            Console.WriteLine();
            Console.WriteLine("Please enter a month and I will give you the amount of days in that month: ");

            string month = Console.ReadLine().ToLower();

            Dictionary<string, int> montDictionary = new Dictionary<string, int>
            {
                {"january", 31},
                {"february", 29},
                {"march", 31},
                {"april", 30},
                {"may", 31},
                {"june", 30},
                {"july", 31},
                {"august", 31},
                {"september", 30},
                {"october", 31},
                {"november", 30},
                {"december", 31},
            };

            Console.WriteLine($"The month of {month} has {montDictionary[month]} days.");


            Console.ReadLine();

        }