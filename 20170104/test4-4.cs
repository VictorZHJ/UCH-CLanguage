using System;

namespace Zoo
{
  class main{
    
    public static void Main(String[] args){
      // 獅子 a = new 獅子();
      // 鳥 b = new 鳥();
      // 魚 c = new 魚();
      形狀[] a = new 形狀[2];
      
      // 動物 a = new 獅子();
      // 動物 b = new 鳥();
      // 動物 c = new 魚();
      a[0] = new 矩形();
      a[1] = new 圓();

      
      a[0].名字 = "小白";
      a[1].名字 = "小黑";

      
      
      a[0].餵食();
      ((矩形)a[0]).跌倒();
      //a[0].移動(100);
      
      a[1].餵食();
      //b.搖尾巴();
      //a[1].移動(1000);
      
      //a[2].移動(1000);
      
      for (int i=0; i<3;i++) a[i].移動(1000);
      
      
    }
    
  } 
}