

using Builder_Pattern.Builder;
using Builder_Pattern.Director;

Director director = new();
ConcreteBuilder builder = new();

director.Builder = builder;


Console.WriteLine("Standard Basic Product :");

director.BuildMinimalViableProduct();
builder.GetProduct().ShowParts();

Console.WriteLine("Standard Full Featured Product :");

director.BuildFullFeaturedProduct();
builder.GetProduct().ShowParts();