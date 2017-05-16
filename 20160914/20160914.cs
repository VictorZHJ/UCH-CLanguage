using System;
namespace HelloWorldApplication
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            int r;
            double pi = 3.14159;
            Console.Write("輸入 r 值：");
            r = Convert.ToInt32(Console.ReadLine());
          
            double aa = r * r * pi;
            double bb = r * 2 * pi;
                      
            Console.WriteLine("圓面積是：" + aa);
            Console.WriteLine("圓周長是：" + bb);
            Console.ReadKey();
        }
    }
}