namespace MyDependencyInjection.CApp;

public class TestService
{
    private Guid? _guid;
    
    public TestService()
    {
        
    }

    public Guid GetGuid
    {
        get
        {
            _guid ??= Guid.NewGuid();
            return _guid ?? default;
        }
    }
}