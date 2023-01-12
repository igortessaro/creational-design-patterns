namespace CreationalDesignPatterns.FactoryMethod;

public sealed class VeggiePizza : IPizza
{
    public string Deliver()
    {
        return $"This is a delivery of a veggie pizza";
    }
}