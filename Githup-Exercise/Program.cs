namespace Githup_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 20;
            int num2 = 10;
            Console.WriteLine(num+num2);

            string text = "doston";
            Console.WriteLine(text);

            Console.WriteLine(num/num2);

            num = 40;
            num2 = 50;
            Console.WriteLine(num2-num);

            int[] number = { 11, 32, 12, 32, 12 };

            for (int i = 0; i < number.Length; i++)
            {
                if(number[i] % 2 == 1)
                {
                    Console.WriteLine(number[i]);
                }
            }

            int res = 32;
            Console.WriteLine(Math.Pow(res,2));

            // I committed this project

            Console.WriteLine("Hello Bro");

            
        }
    }
}
