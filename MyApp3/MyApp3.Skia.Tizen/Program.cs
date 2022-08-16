using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace MyApp3.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new MyApp3.App());
            host.Run();
        }
    }
}
