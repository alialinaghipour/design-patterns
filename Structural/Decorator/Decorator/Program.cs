using Decorator;

var largeSandwich = new LargeSandwich();
Console.WriteLine(largeSandwich.GetPrice());

var mediumSandwich=new MediumSandwich();
Console.WriteLine(mediumSandwich.GetPrice());

var smallSandwich = new SmallSandwich();
Console.WriteLine(smallSandwich.GetPrice());

Console.WriteLine("\n***\n");

var largeSandwichWithSauce = new LargeSandwichWithSauce();
Console.WriteLine(largeSandwichWithSauce.GetPrice());

var mediumSandwichWithSauce = new MediumSandwichWithSauce();
Console.WriteLine(mediumSandwichWithSauce.GetPrice());

var smallSanwichWithSauce = new SmallSandwichWithSauce();
Console.WriteLine(smallSanwichWithSauce.GetPrice());


