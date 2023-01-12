namespace CreationalDesignPatterns.FactoryMethod;

public abstract class PizzaFactory
{
    protected abstract IPizza Create();
    
    public string PizzaDelivery()
    {
        var pizza = Create();
        var result = $"Pizza Factory: {pizza.Deliver()}";

        return result;
    }
}