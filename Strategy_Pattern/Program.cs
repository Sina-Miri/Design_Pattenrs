
using Strategy_Pattern.Context;
using Strategy_Pattern.Strategy;

Context context = new();


ConcreteStrategyA concreteStrategyA = new();
ConcreteStrategyB concreteStrategyB = new();    

context.SetStrategy(concreteStrategyA);
context.ExecuteStrategy();

context.SetStrategy(concreteStrategyB);
context.ExecuteStrategy();
