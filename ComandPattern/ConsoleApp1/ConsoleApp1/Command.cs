using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface Command
    {
        void execute();
        //命令撤销
        void undo();
        //日志请求
        void store();
        void load();
    }
}
