using System;
using System.Collections.Generic;
using System.Text;

namespace UCS.Domain.Command
{
    class TestCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Execute Test Command.");
        }
    }
}
