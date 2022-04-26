using MyDependencyInjection.DI.Enums;

namespace MyDependencyInjection.DI;

internal class ServiceDescriptor
{
    private ServiceDescriptor(object implementation, Type type, Lifetime lifetime)
    {
        Implementation = implementation;
        Type = type;
        Lifetime = lifetime;
    }

    internal ServiceDescriptor(object implementation, Lifetime lifetime) : 
        this(implementation, implementation.GetType(), lifetime)
    {
    }

    internal ServiceDescriptor(Type type, Lifetime lifetime):
        this(null, type, lifetime)
    {
    }

    public Type Type { get; private set; }
    public object Implementation { get; private set; }
    public Lifetime Lifetime { get; private set; }
}