using BeverageApp;
using BeverageApp.Condiments;

var darkRoast = new DarkRoast();
var darkRoastWithMocha = new Mocha(darkRoast);
var darkRoastWithDoubleMocha = new Mocha(darkRoastWithMocha);
var darkRoastWithDoubleMochaAndWhip = new Whip(darkRoastWithDoubleMocha);

Console.WriteLine("Description: " + darkRoastWithDoubleMochaAndWhip.GetDescription());
Console.WriteLine("Cost: " + darkRoastWithDoubleMochaAndWhip.Cost());

var houseBlend = new HouseBlend();
var houseBlendWithSoy = new Soy(houseBlend);
var houseBlendWithSoyAndMocha = new Mocha(houseBlendWithSoy);
var houseBlendWithSoyMochaAndWhip = new Whip(houseBlendWithSoyAndMocha);

Console.WriteLine("Description: " + houseBlendWithSoyMochaAndWhip.GetDescription());
Console.WriteLine("Cost: " + houseBlendWithSoyMochaAndWhip.Cost());