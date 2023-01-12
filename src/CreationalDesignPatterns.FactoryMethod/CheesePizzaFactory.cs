namespace CreationalDesignPatterns.FactoryMethod;

public sealed class CheesePizzaFactory : PizzaFactory
{
    protected override IPizza Create()
    {
        return new CheesePizza();
    }
}