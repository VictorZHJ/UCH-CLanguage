using System;

namespace Zoo {
    
    abstract class 形狀{
        public string 名字;
        public void 餵食(){
            Console.WriteLine(名字 + " 正在吃東西.....");
            Console.WriteLine(名字 + " 吃飽了.....");
        }
        
        // public virtual void 移動(int 哩程){
            
        // }
        public abstract void 移動(int 哩程);
        
    }
    
}