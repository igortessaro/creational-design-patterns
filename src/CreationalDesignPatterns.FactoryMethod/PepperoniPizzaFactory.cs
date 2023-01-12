namespace CreationalDesignPatterns.FactoryMethod;

public sealed class PepperoniPizzaFactory : PizzaFactory
{
    protected override IPizza Create()
    {
        return new PepperoniPizza();
    }
}