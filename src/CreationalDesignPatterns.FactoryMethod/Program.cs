using CreationalDesignPatterns.FactoryMethod;

var cheesePizzaCreator = new CheesePizzaFactory();
var pepperoniPizzaCreator = new PepperoniPizzaFactory();
var veggiePizzaCreator = new VeggiePizzaFactory();

Console.WriteLine($"Your pizza delivery has arrived: {cheesePizzaCreator.PizzaDelivery()}");
Console.WriteLine($"Your pizza delivery has arrived: {pepperoniPizzaCreator.PizzaDelivery()}");
Console.WriteLine($"Your pizza delivery has arrived: {veggiePizzaCreator.PizzaDelivery()}");