using System;

namespace testno12
{
    
    class Program
    {
        static void Main(string[] args)
        {
          int i, n, sum=0;
          
          Console.Write("輸入 n 值：");
          n = Convert.ToInt32(Console.ReadLine());
          
          for(i=2; i<=n; i++)
            sum=sum+(i-1)*i;

                
          Console.WriteLine("1*2+2*3+3*4+...+(n-1)*n=" + sum);
          Console.ReadLine();
        }
    }
}
