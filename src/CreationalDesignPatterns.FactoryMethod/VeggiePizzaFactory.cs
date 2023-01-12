namespace CreationalDesignPatterns.FactoryMethod;

public sealed class VeggiePizzaFactory : PizzaFactory
{
    protected override IPizza Create()
    {
        return new VeggiePizza();
    }
}