public class BusinessModuleProxy : IBusinessModule
{
    private readonly BusinessModule _realSubject;

    public BusinessModuleProxy()
    {
        _realSubject = new BusinessModule();
    }

    public void Method()
    {
        Console.WriteLine("Before method");
        _realSubject.Method();
        Console.WriteLine("After method");
    }
}