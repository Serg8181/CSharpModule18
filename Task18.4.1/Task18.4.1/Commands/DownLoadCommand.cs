using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task18._4._1.Receiver;

namespace Task18._4._1.Classes
{
    public class DownLoadCommand : Command
    {
        public Youtube receiver;

        public DownLoadCommand(Youtube receiver)
        {
            this.receiver = receiver;

        }

        public override void Cancel()
        {

        }

        public override void Run()
        {
            receiver.DownLoadVideo();

        }
    }
}
