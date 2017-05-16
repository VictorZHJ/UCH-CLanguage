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
      Console.WriteLine();
      for(i=0; i<n; i++)
         number[i] = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("排序過程 ");
      insert_sort(number, n);
      Console.Write("排序結果：");
      for(i = 0; i < n; i++)
         Console.Write(number[i]+" ");
         Console.WriteLine();
      
    }
    public static void insert_sort(int[] a, int n){
      int i, j, key;
      for(i=1; i<n; i++)
      {
        key = a[i];
        for(j=i-1; j>=0 && key<a[j]; j--)
        a[j+1]=a[j];
        a[j+1]=key;
        Console.Write("步驟 " + i + "：");
        for(j=0;j<n;j++) 
          Console.Write(a[j] + " ");
          Console.WriteLine();
      }
      return;
    }
  }
}




