using SRTPluginBase;
using SRTPluginProviderMGU;

namespace SRTPluginUIMGUWPF
{
    public class PluginUI : PluginBase, IPluginUI
    {
        public string RequiredProvider => "SRTPluginProviderMGU";

        internal static PluginInfo _info = new PluginInfo();
        public override IPluginInfo Info => _info;

        public IPluginHostDelegates HostDelegates { get; private set; }

        public override int Startup(IPluginHostDelegates hostDelegates)
        {
            HostDelegates = hostDelegates;
            return Plugin.Initialize(this);
        }

        public override int Shutdown() =>
            Plugin.Exit();

        public int ReceiveData(object gameMemory)
        {
            Plugin.Models.AppView.Initalize((IGameMemoryMGU)gameMemory);
            return 0;
        }
    }
}