using Decorator;

var largeSandwich = new LargeSandwich();
Console.WriteLine(largeSandwich.GetName() + " ==> " + largeSandwich.GetPrice());
var largeSandwichWithSauce = new SandwichWithSauce(largeSandwich);
Console.WriteLine(largeSandwichWithSauce.GetName() + " ==> " + largeSandwichWithSauce.GetPrice());


var mediumSandwich=new MediumSandwich();
var mediumSandwichWithPotato = new SandwichWithPotato(mediumSandwich);
Console.WriteLine(mediumSandwichWithPotato.GetName() + " ==> " + mediumSandwichWithPotato.GetPrice());

var smallSandwich = new SmallSandwich();
var smallSandwichWithSauce = new SandwichWithSauce(smallSandwich);
var smallSandwichWithPotato = new SandwichWithPotato(smallSandwichWithSauce);
Console.WriteLine(smallSandwichWithPotato.GetName() + " ==> " + smallSandwichWithPotato.GetPrice());





