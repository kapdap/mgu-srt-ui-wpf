using SRTPluginBase;
using SRTPluginProviderMGU;

namespace SRTPluginUIMGUWPF
{
    public class PluginUI : IPluginUI
    {
        public string RequiredProvider => "SRTPluginProviderMGU";

        internal static PluginInfo _info = new PluginInfo();
        public IPluginInfo Info => _info;

        public IPluginHostDelegates HostDelegates { get; private set; }

        public int Startup(IPluginHostDelegates hostDelegates)
        {
            HostDelegates = hostDelegates;
            return Plugin.Initialize(this);
        }

        public int Shutdown() =>
            Plugin.Exit();

        public int ReceiveData(object gameMemory)
        {
            Plugin.Models.AppView.Initalize((GameMemoryMGU)gameMemory);
            return 0;
        }
    }
}