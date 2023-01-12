namespace CreationalDesignPatterns.FactoryMethod;

public sealed class PepperoniPizza : IPizza
{
    public string Deliver()
    {
        return $"This is a delivery of a pepperoni pizza";
    }
}