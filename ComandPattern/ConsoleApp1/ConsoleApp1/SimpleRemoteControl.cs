
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SimpleRemoteControl
    {
        Command slot;
        public SimpleRemoteControl()
        {

        }
        public void setCommand(Command command)
        {
            slot = command;
        }
        public void buttonPressed()
        {
            slot.execute();
        }
    }
}
