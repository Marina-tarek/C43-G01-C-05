namespace ass_c_5
{
    internal class Program
    {
        public static int SumCal(int n)
        {
            // Convert the number to a string
            string n1 = Convert.ToString(n);
            int sum = 0;

            // Loop through each digit in the number
            for (int i = 0; i < n1.Length; i++)
            {
                // Extract each digit and add it to the sum
                sum += Convert.ToInt32(n1.Substring(i, 1));
            }

            return sum; // Return the sum of individual digits
        }
        public static bool isPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static void SWAP(int A, int B)
        {
            int temp = A;
            A= B;
            B = temp;
        }
        public static void SWAP(ref int X, ref int Y)
        {
            int temp = X;
            X = Y;
            Y = temp;
        }
        static void Main(string[] args)
        {
            #region Q1 - Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.
            //passig by value :the change made inside the function not reflect in original value...makes copy of actual parameter
            //..ex:
            //int A = 30, B = 20;
            //Console.WriteLine($"A = {A}"); //30
            //Console.WriteLine($"B = {B}"); // 20
            //SWAP(A, B); // Passing By Value
            //Console.WriteLine("After Swapping");
            //Console.WriteLine($"A = {A}"); // 30
            //Console.WriteLine($"B = {B}"); // 20
            ////===================================
            ////passing by reference:the change made inside the function reflect in original value...address of actual parameter passes to the function
            ////..ex:
            //int x = 30, y = 20;
            //Console.WriteLine($"x = {x}"); // 30
            //Console.WriteLine($"y = {y}"); // 20
            //SWAP(ref x, ref y); // Passing By Reference
            //Console.WriteLine("After Swapping");
            //Console.WriteLine($"x = {x}"); // 20
            //Console.WriteLine($"y = {y}"); // 30
            #endregion

            #region  Q2 - Explain the difference between passing(Reference type parameters) by value and by reference then write a suitable c# example.
            #region Passing By Value
            //int[] numbers = { 1, 2, 3 };
            //int result = SumArray(numbers); // Passing By Value [Address]
            //Console.WriteLine(numbers.GetHashCode());
            //Console.WriteLine($"Sum =  {result}"); // 105
            //Console.WriteLine($"Numbers[0] = {numbers[0]}"); // 100


            #endregion

            #region Passing by Reference 
            //int[] numbers = { 1, 2, 3 };
            //int result = SumArray(ref numbers); // Passing By Reference [Reference of Array : numbers]
            //Console.WriteLine($"Sum =  {result}"); // 105
            //Console.WriteLine($"Numbers[0] = {numbers[0]}"); // 100
            #endregion
            #endregion


            #region Q3 - Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            #endregion

            #region Q4 - Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            // Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7
            //=================
            //int num;
            //Console.Write("Enter Number: ");
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The sum of the digits of the number {0} is : {1} \n", num, SumCal(num));

            #endregion

            #region Q5 - Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            #endregion

            #region Q6 - Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            #endregion

            #region Q7 - Create an iterative(non-recursive) function to calculate the factorial of the number specified as parameter

            #endregion

            #region Q8 - Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            #endregion
        }
    }
}
