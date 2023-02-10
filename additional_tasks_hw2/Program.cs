namespace additional_tasks_hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1

            Console.WriteLine("Task 1\n");
            Console.Write("1\t");
            Console.Write("1\t");

            int number1 = 1;
            int number2 = 1;

            for (int i = 3; i <= 11; ++i)
            {
                int number3 = number1 + number2;
                Console.Write($"{number3}\t");
                number1 = number2;
                number2 = number3;
            }


            // Task 2
            Console.WriteLine("\nTask 2\n");
            Console.Write("\nEnter the amount of money: ");
            float sum = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of months: ");
            int period = int.Parse(Console.ReadLine());

            for (int i = 0; i < period; i++)
            {
                sum += sum * 0.07F;

            }

            Console.WriteLine($"You will get: {sum}");


            //Task 3

            Console.WriteLine("\nTask 3\n");

        start:
            Console.WriteLine("Enter size of array. It must be more than 5 and equals or less than 10");

            int sizeOfArray = int.Parse(Console.ReadLine());

            if (sizeOfArray <= 5 || sizeOfArray > 10)
            {
                Console.WriteLine("You entered not right size. Try again, please\n");
                goto start;
            }

            int[] array = new int[sizeOfArray];

            Random random = new Random();

            for (int i = 0; i < sizeOfArray; i++)
            {
                array[i] = random.Next(1, 99);
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine("");

            Console.Write("Your new array:");
            int[] secondarray = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                if (array[i] % 2 == 0)
                {
                    secondarray[i] = array[i];
                    Console.Write($"{secondarray[i]}\t");

                }
                else
                {
                    continue;
                }

            }


            //Task 4

            Console.WriteLine("\nTask 4\n");

            Console.Write("Your first array : ");

            int[] numbers = new int[11];

            Random ran = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ran.Next(1, 99);
                Console.Write($"{numbers[i]}\t");

            }

            Console.WriteLine("\nYour second array: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{numbers[i]} \t");
                }
                else
                {
                    numbers[i] = 0;
                    Console.Write($"{numbers[i]} \t");
                }
            }


            // Task 5


            Console.WriteLine("\nTask 5\n");

            string[] names = { "Vasya", "Petya", "Kolya", "Tanya", "Lena", "Asya" };

            Array.Sort(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]}\t");
            }


            // Task 6 

            Console.WriteLine("\nTask 6\n");

            int [] arrayNumbers = new int [11];

            int temp;

            Random rand = new Random();

            Console.Write("Your array:");

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = rand.Next(-99, 99);
                Console.Write($"{arrayNumbers[i]}\t");

            }

            for (int i = 0; i < arrayNumbers.Length - 1; i++)
            {
                for (int j = 0; j < arrayNumbers.Length -1 - i; j++)
                {
                    if(arrayNumbers [j] > arrayNumbers[j+1])
                    {
                        temp = arrayNumbers[j];
                        arrayNumbers[j] = arrayNumbers[j+1];
                        arrayNumbers[j + 1] = temp;
                    }
                }
            }

            Console.Write("\nYour sorted array: ");
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write($"{arrayNumbers[i]}\t");

            }


        }
    }
}