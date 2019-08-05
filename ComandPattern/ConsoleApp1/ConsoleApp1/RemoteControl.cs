
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        //用于记录最后一个命令
        Command UndoCommand;
        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];
            Command noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
                onCommands[i] = noCommand;
            for (int i = 0; i < offCommands.Length; i++)
                offCommands[i] = noCommand;
        }
        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
            UndoCommand= onCommands[slot];
        }
        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
            UndoCommand = offCommands[slot];
        }
        public void undoButtonWasPushed()
        {
            UndoCommand.undo();
        }
        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n-------Remote Control-------\n");
            for(int i = 0; i < onCommands.Length; i++)
            {
                sb.Append($"[slot{i}][{onCommands[i].ToString()}[{offCommands[i].ToString()}]]");
            }
            return sb.ToString();
        }
    }
}
