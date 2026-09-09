using WebApplication1.Services.IServices;

namespace WebApplication1.Services;

/// <summary>
///  作用域的服务(线程单例，每一个线程去创建一个)
/// </summary>
public class scopedService : IscopedService
{
    public int count;
    public scopedService()
    {
        
    }

    public void add()
    {
        count++;
    }


}

