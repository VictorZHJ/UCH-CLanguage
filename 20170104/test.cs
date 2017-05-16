
using System;

namespace VariableDefinition
{
  
  struct 矩形 {
    public string 代號;
    public int 位置x;
    public int 位置y;  
    public int 長;
    public int 寬;
  };
  
  
  class Program
  {
    static void Main(string[] args)
    {
      
      矩形 a;
      
      Console.WriteLine("Please input the data of a student: ");

      Console.Write("輸入代號: ");
      a.代號 = Console.ReadLine();  
      Console.Write("輸入位置x:");
      a.位置x = Convert.ToInt32(Console.ReadLine());
      Console.Write("輸入位置y: ");
      a.位置y = Convert.ToInt32(Console.ReadLine());
      Console.Write("輸入長: ");
      a.長 = Convert.ToInt32(Console.ReadLine());
      Console.Write("輸入寬: ");
      a.寬 = Convert.ToInt32(Console.ReadLine());  
      
      Console.WriteLine("輸入的資料如下:");
      Console.WriteLine("代號: " + a.代號);
      Console.WriteLine("位置x: " + a.位置x);
      Console.WriteLine("位置y: " + a.位置y);
      Console.WriteLine("長: " + a.長);
      Console.WriteLine("寬: " + a.寬);
      
    }
  }
}