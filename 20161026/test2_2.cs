using System;

namespace testno37{
  public class test2_22{
    public static void insert_sort(int[] a, int n){
      int i, j, key;
      for(i=1; i<n; i++)
      {
        key = a[i];
        for(j=i-1; j>=0 && key<a[j]; j--)
        a[j+1]=a[j];
        a[j+1]=key;
        Console.Write("pass " + i + "：");
        for(j=0;j<n;j++) 
          Console.Write(a[j] + " ");
          Console.WriteLine();
      }
      return;
    }
  }
}
