using Microsoft.Extensions.DependencyInjection;

namespace Main.Util
{
    internal class AppDI : Singleton<AppDI>
    {
        public IServiceProvider Services;

        public static T GetService<T>() => Instance.Services.GetService<T>();
    }
}
