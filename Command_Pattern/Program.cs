using Command_Pattern.Commands;
using Command_Pattern.Receiver;
using Command_Pattern.Sender;

Sender sender = new();
Receiver receiver = new();


// Execute Copy Command
ICommand copyCommand = new CopyCommand(receiver, "Test Text");

sender.SetCommand(copyCommand);
sender.ExecuteCommand();


// Execute Paste Command
ICommand pasteCommand = new PasteCommand(receiver, "Test Text 2");    

sender.SetCommand(pasteCommand);
sender.ExecuteCommand();




