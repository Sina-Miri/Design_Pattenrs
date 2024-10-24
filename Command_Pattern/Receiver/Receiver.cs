using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Receiver
{
    public class Receiver
    {
        public void Copy(string text)
        {
            Console.WriteLine($"{text} Copied !");
        }

        public void Paste(string text)  
        {
            Console.WriteLine($"{text} Pasted !");
        }
    }
}
