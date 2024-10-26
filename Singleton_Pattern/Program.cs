

using Singleton_Pattern;

var instance = Singleton.GetInstance();
var instance2 = Singleton.GetInstance();

Console.WriteLine(ReferenceEquals(instance, instance2));

