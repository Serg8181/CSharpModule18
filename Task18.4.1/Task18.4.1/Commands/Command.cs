using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18._4._1.Classes
{
    public abstract class Command
    {
        public abstract void Run();
        public abstract void Cancel();
    }
}
