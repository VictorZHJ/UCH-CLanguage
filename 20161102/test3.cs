using System;

namespace DecisionMaking
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
          double 里程 = 0;
          double pay = 0;
          
          Console.Write("請輸入里程：");
          里程 = Convert.ToDouble(Console.ReadLine()); 
          
          double aa = 里程 % 0.5;
          if (里程 <= 1.5) {
            pay = 150;            
          }
          else {
            里程 = 里程 - 1.5;
            int 跳表次數 = (int)(里程 / 0.5 ); 
            if (aa<0.5 && aa>0){
              pay = 150 + 跳表次數*10 + 10; 
            }
            else if(aa==0){
               pay = 150 + 跳表次數*10; 
            }
          }
          Console.WriteLine("總計車資：" + pay);
          
          Console.ReadLine();
        }
    }
}