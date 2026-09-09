using WebApplication1.Services.IServices;

namespace WebApplication1.Services;

public class IocService2 : IIocService2
{
    public IocService2(IscopedService iscopedService, IsingletonService isingletonService, ItransientService itransientService)
    {
        IscopedService = iscopedService;
        IsingletonService = isingletonService;
        ItransientService = itransientService;
    }

    public IscopedService IscopedService { get; }
    public IsingletonService IsingletonService { get; }
    public ItransientService ItransientService { get; }
}

