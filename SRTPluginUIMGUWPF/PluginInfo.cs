using SRTPluginBase;
using System;

namespace SRTPluginUIMGUWPF
{
    public class PluginInfo : IPluginInfo
    {
        public string Name => "WPF UI (Martian Gothic: Unification)";

        public string Description => "A WPF-based User Interface for displaying Martian Gothic: Unification game memory values.";

        public string Author => "Kapdap";

        public Uri MoreInfoURL => new Uri("https://github.com/kapdap/mgu-srt-ui-wpf/");

        public int VersionMajor => assemblyFileVersion.ProductMajorPart;

        public int VersionMinor => assemblyFileVersion.ProductMinorPart;

        public int VersionBuild => assemblyFileVersion.ProductBuildPart;

        public int VersionRevision => assemblyFileVersion.ProductPrivatePart;

        private System.Diagnostics.FileVersionInfo assemblyFileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
    }
}