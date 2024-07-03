using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task18._4._1.Classes;

namespace Task18._4._1.Sender
{
    public class User
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void Run()
        {
            _command.Run();
        }

        public void Cancel()
        {
            _command?.Cancel();
        }
    }
}
