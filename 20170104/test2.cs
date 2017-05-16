using System;
namespace BoxApplication
{
  class 矩形
  {
     public string boxid;
     public double 位置x;   
     public double 位置y;  
     public double 長;  
     public double 寬;
     

    //靜態函數
    public static void 設定(矩形 This, string boxid, double 位置x, double 位置y, double 長, double 寬){
      This.boxid = boxid;
      This.位置x = 位置x;
      This.位置y = 位置y;
      This.長 = 長;
      This.寬 = 寬;
    }

    //物件函數
    // 1. 沒有 static 修飾字
    // 2. 預設傳入 一個 this 參數，型別就是 矩形
    public void set( string boxid, double 位置x, double 位置y, double 長, double 寬){
      this.boxid = boxid;
      this.位置x = 位置x;
      this.位置y = 位置y;
      this.長 = 長;
      this.寬 = 寬;
      
    }
    
    public static void 顯示(矩形 This){
      Console.WriteLine("boxid:" + This.boxid);
      Console.Write("\t 位置x:" + This.位置x);
      Console.Write("\t 位置y:" + This.位置y);
      Console.Write("\t 長:" + This.長);
      Console.WriteLine("\t 寬:" + This.寬);
    }

    public void display(){
      Console.WriteLine("boxid:" + this.boxid);
      Console.Write("\t 位置x:" + this.位置x);
      Console.Write("\t 位置y:" + this.位置y);
      Console.Write("\t 長:" + this.長);
      Console.WriteLine("\t 寬:" + this.寬);
    }
    
    
    public static double 體積(矩形 b1){
      return b1.位置x * b1.位置y * b1.長;
    }

    public double 面積(){
      return 長 * 寬;
    }

    public double 周長(){
      return (長 * 2 + 寬 * 2);
    }
  }
  
  class Test{
    
    public static void Main(string[] args){
  
      矩形 b1, b2;
      
      
      b1 = new 矩形();
      b2 = new 矩形();
      
      //Box.設定(b1,"1st box", 5,6,7);
      //Box.設定(b2,"2st box", 50,60,70);
      b1.set("1st box", 5,6,7,80);
      b2.set("2st box", 50,60,70,80);
      
      //Box.顯示(b1);
      //Box.顯示(b2);
      b1.display();
      b2.display();
      
      Console.WriteLine(b1.boxid + "面積 : " + b1.面積());
      Console.WriteLine(b1.boxid + "周長: " + b2.周長());
    }
  }
}
