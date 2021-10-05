using System;

namespace Part16ParameterizedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;
            Program p = new Program();
            p.ParamArray();
            p.ParamArray(numbers);
            p.ParamArray(1, 2, 3, 4, 5);
            //value pass to method is not mandatory
            //we can pass coma separated values
            //we can pass our array also
            //its all becouse of params keyword

        }
        public void ParamArray(params int [] a)
        {
            Console.WriteLine("elements is the Array is {0}", a.Length);
            foreach(int j in a)
            {
                Console.WriteLine(j);

            }
        }
    }
}
