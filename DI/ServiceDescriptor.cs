using DI.Enums;

namespace DI;

public class ServiceDescriptor
{
    public ServiceDescriptor(object implementation, Lifetime lifetime)
    {
        Implementation = implementation;
        Type = implementation.GetType();
    }
    
    public Type Type { get; private set; }
    public object Implementation { get; private set; }
    public Lifetime Lifetime { get; private set; }
}