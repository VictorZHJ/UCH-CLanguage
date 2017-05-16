using System;
namespace BoxApplication
{
  class Box
  {
     public string boxid;
     public double length;   // 长度
     public double breadth;  // 宽度
     public double height;   // 高度

    //靜態函數
    public static void 設定(Box This, string name, double length, double breadth, double height){
      This.boxid = name;
      This.length = length;
      This.breadth = breadth;
      This.height = height;
    }

    //物件函數
    // 1. 沒有 static 修飾字
    // 2. 預設傳入 一個 this 參數，型別就是 Box
    public void set( string name, double length, double breadth, double height){
      this.boxid = name;
      this.length = length;
      this.breadth = breadth;
      this.height = height;
      
    }
    
    public static void 顯示(Box This){
      Console.WriteLine("name:" + This.boxid);
      Console.Write("\t length:" + This.length);
      Console.Write("\t breadth:" + This.breadth);
      Console.WriteLine("\t height:" + This.height);
    }

    public void display(){
      Console.WriteLine("name:" + this.boxid);
      Console.Write("\t length:" + this.length);
      Console.Write("\t breadth:" + this.breadth);
      Console.WriteLine("\t height:" + this.height);
    }
    
    
    public static double 體積(Box b1){
      return b1.length * b1.breadth * b1.height;
    }

    public double volume(){
      return length * breadth * height;
    }

    public double area(){
      return 2*(length * breadth + breadth * height + height*length);
    }



  }
}
