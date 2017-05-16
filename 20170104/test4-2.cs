using System;

namespace Zoo {
    
    class 矩形 : 形狀{
        
        public double 長;
        public double 寬;
        
        public void 跌倒(){
            Console.WriteLine(名字+ "跌倒了");
        }
        
        public override void 移動(int 哩程){
            Console.WriteLine(名字+"跑步，前進了" + 哩程 + "公尺");
        }
        
    }
    
}