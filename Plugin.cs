using System;
using Exiled.API.Enums;
using Exiled.API.Features;

namespace Blackout
{
    internal class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "079 Blackout";
        public override string Author { get; } = "x3rt";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(3, 0, 0);
        
        public static Config SharedConfig { get; set; }
        public static DateTime lastUsed;
        public override PluginPriority Priority => PluginPriority.Last;

        public override void OnEnabled()
        {
            SharedConfig = Config;
            base.OnEnabled();
        }
    }
}