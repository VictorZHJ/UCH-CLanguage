using System;
namespace moneyApplication
{
    class moneymoney
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("輸入金額： ");
            a = Convert.ToInt32(Console.ReadLine());  //Convert 是一個類別，裡面放了一堆 轉換型別的函數，大部份是 從字串轉數值 的函數
            Console.WriteLine("10元硬幣有：" + a/10  + "個");
            Console.WriteLine("5元硬幣有：" + a%10/5 + "個");
            Console.WriteLine("1元硬幣有：" + a%10%5 + "個");
        }
    }
}