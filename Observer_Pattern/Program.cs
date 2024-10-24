using Observer_Pattern.Subject;
using Observer_Pattern.Subscriber;
using System.Drawing;

ColorSubject subject = new();

for(int i = 0;i <= 7;i++)
{
    IObserver observer = new Observer();
    subject.Register(observer);
}


subject.Color = Color.FromName("red");

await Task.Delay(2000);

subject.Color = Color.FromName("green");

