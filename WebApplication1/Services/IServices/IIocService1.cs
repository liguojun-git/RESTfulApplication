namespace WebApplication1.Services.IServices;

public interface IIocService1
{
    public IscopedService IscopedService { get; }
    public IsingletonService IsingletonService { get; }
    public ItransientService ItransientService { get; }
}
