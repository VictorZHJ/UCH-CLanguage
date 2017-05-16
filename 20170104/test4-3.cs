using System;

namespace Zoo {
    
    class 圓 : 形狀{
 
        
        public string 半徑;
        
        public override void 移動(int 哩程){
            Console.WriteLine(名字+"翻滾，前進了" + 哩程 + "公尺");
        }

    }
    
}