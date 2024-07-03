using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Task18._4._1.Receiver;

namespace Task18._4._1.Classes
{
    public class GetInfoCommand : Command
    { 
    
        public Youtube receiver;

        public GetInfoCommand(Youtube receiver)
        {
            this.receiver = receiver;
        
        }

        public override void Cancel()
        {
            
        }

        public override void Run()
        {
            receiver.GetInfo();
              
        }
    }
}
