using System;

namespace testno21
{
    
    class Program
    {
        static void Main(string[] args)
        {
          string a,b;
          Console.Write("輸入 a 字串：");
          a = Convert.ToString(Console.ReadLine());
          Console.Write("輸入 b 字串：");
          b = Convert.ToString(Console.ReadLine());
          
          if(String.Equals(a, b))
          {
              Console.WriteLine(a.Length);
          }
          else
          {
              Console.WriteLine("0");
          }
          
        }
    }
}

