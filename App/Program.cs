using System;
namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Enter Integer : ");
                int a = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter 5 elements");
                int[] Arr = new int[5];
                    for(int i = 0;i<=5;i++)
                    {
                        Arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
            }
            catch (FormatException ex0)
            {
               System.Console.WriteLine(ex0.Message);
            }
            catch (IndexOutOfRangeException ex1)
            {
                System.Console.WriteLine(ex1.Message);
            }
            finally
            {
                System.Console.WriteLine("Thank You");
            }
        }
        
    }
} 