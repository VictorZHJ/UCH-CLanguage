using System;

namespace testno39
{
  public class Program
  {
    public static void Main(string[] args)
    {
        int [] a;
        int i,n,label;
        a = new int[100];
        Console.Write("輸入考生人數：");
        n = Convert.ToInt32(Console.ReadLine());
        for(i=0;i<n;i++){
          Console.Write("輸入第" + (i+1) + "考生成績：");
          a[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        insert_sort_des(a,n);
        label = a[(n-1)/2];
        Console.Write("通過的考生成績：");
        for(i = 0; i < n && a[i] >= label; i++)
        Console.Write(a[i] + " ");
    }
    
    
    public static void insert_sort_des(int[ ] a, int n)
    {
        int i, j, key;
        for(i=1;i<n;i++)
        {
          key=a[i];
          for(j=i-1;j>=0 && key>a[j];j--)
          a[j+1]=a[j];
          a[j+1]=key;
        }
    }
  }
}
