using PizzaStore.PizzaStores;

var nyPizzaStore = new NYPizzaStore();
nyPizzaStore.OrderPizza("cheEse");

var chicagoPizzaStore = new ChicagoPizzaStore();
chicagoPizzaStore.OrderPizza("Veggie");

var californiaPizzaStore = new CaliforniaPizzaStore();
californiaPizzaStore.OrderPizza("clAm");