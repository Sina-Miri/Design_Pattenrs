
namespace Command_Pattern.Commands
{
    public class CopyCommand : ICommand
    {
        private Receiver.Receiver _receiver;
        private string _text;

        public CopyCommand(Receiver.Receiver receiver, string text)
        {
            _receiver = receiver;
            _text = text;
        } 

        public void ExecuteAction()
        {
            _receiver.Copy(_text);
        }
    }
}
