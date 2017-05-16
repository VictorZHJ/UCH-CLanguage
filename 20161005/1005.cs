using System;

namespace testno25
{
    
    class Program
    {
        static void Main(string[] args)
        {
          int quantity; 
          int salary;
          
          Console.Write("輸入每月賣出產品的數量：");
          quantity = Convert.ToInt32(Console.ReadLine());
          
            if(quantity<=20)
                salary=15000+quantity*380;
            else if(quantity<=40)
                salary=15000+quantity*420;
            else
                salary=15000+quantity*420+(quantity-40)/10*1500;
                
          Console.WriteLine("每月薪資為：" + salary + "元");
          Console.ReadLine();
        }
    }
}