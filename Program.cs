using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathProcess(4.5, 5.5, '+');
            Console.WriteLine(SymbolCounter("salam , necesen ,", ','));
            Console.WriteLine(SumNums(56));
            Console.WriteLine(ShowResult(4, 4));
            Console.WriteLine(ReturnPositiveELements(new int[] { 1, 3, 6, 8, -4, 7 }));
            Console.WriteLine(ReturnOpposite("sagol"));
        }


        //Verilmiş iki ədəd üzərində verilmiş operator simvoluna əsasən riyazi əməliyyat aparıb nəticəsini console-da göstərən metod.
        static void MathProcess(double reqem1, double reqem2, char simvol)
        {
            switch (simvol)
            {
                case '+':
                    Console.WriteLine($"reqemlerin cemi : {reqem1 + reqem2}");
                    break;
                case '-':
                    Console.WriteLine($"reqemlerin cixilmasi : {reqem1 - reqem2}");
                    break;
                case '*':
                    Console.WriteLine($"reqemlerin vurulmasi :{reqem1 * reqem2}");
                    break;
                case '/':
                    if (reqem2 != 0)
                    {
                        Console.WriteLine($"reqemlerin bolunmesi :{reqem1 / reqem2}");
                    }
                    else
                    {
                        Console.WriteLine(" 0 a bolme emeliyyati aparilmir");
                    }
                    break;
                default:
                    Console.WriteLine("duzgun simvol daxil edin");
                    break;
            }


        }


        //Verilmiş yazıdaki verilmiş simvolların sayını qaytaran metod
        static int SymbolCounter(string text, char symbol)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    count++;
                }

            }
            return count;
        }



        //Verilmişdədin rəqəmləri cəmini qaytaran metod
        static int SumNums(int nums)
        {
            int sum = 0;

            if (nums != 0)
            {
                int digit = nums % 10;
                sum += digit;
                nums = (nums - digit) / 10;
                sum += nums;
            }
            return sum;
        }


        //Verilmiş ədədi verilmiş qüvvətə yüksəldib nəticəsini qaytaran metod
        static int ShowResult(int num, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;

        }

        //Verilmiş ədədlər siyahısının bütün elementlərini  müsbət şəkildə qaytaran metod
        static int[] ReturnPositiveELements(int[] nums)
        {
            int count = nums.Length;
            int[] PositiveNums = new int[count];
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    PositiveNums[index] = nums[i];
                    index++;
                }
                else
                {
                    PositiveNums[index] = -nums[i];
                    index++;
                }

            }
            return PositiveNums;

        }

        //Verilmiş yazını tərs formada qaytaran metod 
        static string ReturnOpposite(string text)
        {
            string result = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }
            return result;
        }

    }
}
