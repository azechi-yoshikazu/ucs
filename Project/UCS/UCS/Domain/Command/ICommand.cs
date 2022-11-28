using System;
using System.Collections.Generic;
using System.Text;

namespace UCS.Domain.Command
{
    interface ICommand
    {
        public void Execute();
    }
}
