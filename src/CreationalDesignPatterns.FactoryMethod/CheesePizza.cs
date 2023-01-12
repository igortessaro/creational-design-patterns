namespace CreationalDesignPatterns.FactoryMethod;

public sealed class CheesePizza: IPizza
{
    public string Deliver()
    {
        return $"This is a delivery of a cheese pizza";
    }
}