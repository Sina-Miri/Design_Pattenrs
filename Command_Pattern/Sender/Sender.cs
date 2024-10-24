using Command_Pattern.Commands;

namespace Command_Pattern.Sender
{
    public class Sender
    {
        private ICommand _command;  

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.ExecuteAction();
        }
    }
}
