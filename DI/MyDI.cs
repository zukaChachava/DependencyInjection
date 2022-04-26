namespace DI;

public class MyDI
{
    private IList<ServiceDescriptor> _serviceDescriptors;

    public MyDI()
    {
        _serviceDescriptors = new List<ServiceDescriptor>();
        ServiceCollection = new DIServiceCollection();
    }
    
    public DIServiceCollection ServiceCollection { get; private set; }

    public void AddSingleton<T>()
    {
        
    }
    
    public void AddSingleton<T>(T implementation)
    {
        
    }

    public void AddTransient<T>()
    {
        
    }
    
    public void AddTransient<T>(T implementation)
    {
        
    }
}