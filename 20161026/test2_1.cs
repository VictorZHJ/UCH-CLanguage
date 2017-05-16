using System;

namespace testno37{
  public class Program{
   public static void Main(string[] args){
      int[] number;
      number = new int[100];
      int i,n;
      Console.Write("輸入 n 值：");
      n = Convert.ToInt32(Console.ReadLine());
      Console.Write("待排序資料：");
      for(i=0; i<n; i++)
         number[i] = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("排序過程 ");
      test2_22.insert_sort(number, n);
      Console.Write("排序結果：");
      for(i = 0; i < n; i++)
         Console.Write(number[i]+" ");
      
    }
  }
}
