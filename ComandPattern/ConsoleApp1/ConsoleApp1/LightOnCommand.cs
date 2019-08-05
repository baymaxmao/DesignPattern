
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class LightOnCommand : Command
    {
        Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
           
            light.on();
        }

        public void load()
        {
            
        }

        public void store()
        {
           
        }

        //这种撤销方式不判断当前状态，执行特性操作，只适用于0-1状态
        //更复杂的状态操作需要状态变量
        public void undo()
        {
            light.off();
        }
       
    }
    //命令实例化时传入了接收对象，执行excute操作-执行对象的相关操作
    class LightOffCommand : Command
    {
        Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.off();
        }

        public void load()
        {
            
        }

        public void store()
        {
            
        }

        public void undo()
        {
            light.on();
        }

    }
}
