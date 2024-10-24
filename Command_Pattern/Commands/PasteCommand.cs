using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Commands
{
    public class PasteCommand : ICommand
    {
        private Receiver.Receiver _receiver;
        private string _text;

        public PasteCommand(Receiver.Receiver receiver, string text)
        {
            _receiver = receiver;
            _text = text;
        }

        public void ExecuteAction()
        {
            _receiver.Paste(_text);
        }
    }
}
