using System.Linq.Expressions;
using MyDependencyInjection.DI.Enums;

namespace MyDependencyInjection.DI;

public class MyDI
{
    private IDictionary<int, ServiceDescriptor> _serviceDescriptors;

    public MyDI()
    {
        _serviceDescriptors = new Dictionary<int, ServiceDescriptor>();
    }

    public void AddSingleton<T>()
    {
        AddSingleton(Activator.CreateInstance<T>());
    }

    public void AddSingleton<T>(T implementation)
    {
        _serviceDescriptors.Add(typeof(T).GetHashCode(), new ServiceDescriptor(implementation, Lifetime.Singleton));
    }
    

    public void AddTransient<T>()
    {
        AddTransient(typeof(T));
    }
    
    public void AddTransient(Type type)
    {
        _serviceDescriptors.Add(type.GetHashCode(), new ServiceDescriptor(type, Lifetime.Transient));
    }

    public T GetService<T>()
    {
        int hash = typeof(T).GetHashCode();
        if (!_serviceDescriptors.ContainsKey(hash))
            throw new KeyNotFoundException("That service does not exists");

        var serviceDescriptor = _serviceDescriptors[hash];

        if (serviceDescriptor.Lifetime == Lifetime.Singleton)
            return (T)serviceDescriptor.Implementation;
        
        return  (T)Activator.CreateInstance(_serviceDescriptors[hash].Type);
    }
}