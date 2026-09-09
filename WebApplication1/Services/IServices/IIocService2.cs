namespace WebApplication1.Services.IServices;

public interface IIocService2
{
    public IscopedService IscopedService { get; }
    public IsingletonService IsingletonService { get; }
    public ItransientService ItransientService { get; }
}
