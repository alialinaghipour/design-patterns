using Decorator;

var largeSandwich = new LargeSandwich();
Console.WriteLine(largeSandwich.GetPrice());

var mediumSandwich=new MediumSandwich();
Console.WriteLine(mediumSandwich.GetPrice());

var smallSandwich = new SmallSandwich();
Console.WriteLine(smallSandwich.GetPrice());


