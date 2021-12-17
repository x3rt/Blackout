using System.ComponentModel;
using Exiled.API.Interfaces;

namespace Blackout
{
    public sealed class Config : IConfig
    {
        [Description("If plugin is enabled")]
        public bool IsEnabled { get; set; } = true;
        [Description("Should surface be blacked out")]
        public bool BlackoutSurface { get; set; } = false;
        [Description("How long should the global blackout last")]
        public float BlackoutDuration { get; set; } = 60f;
        [Description("Cooldown between blackouts")]
        public float BlackoutCooldown { get; set; } = 60f;
        [Description("Text to display when the blackout is active. Leave empty to disable")]
        public string CassieAnnouncement { get; set; } = string.Empty;
        [Description("If cassie starting chime should be muted (same as cassie_sl command)")]
        public bool CassieSilent { get; set; } = true;
        [Description("The tier 079 needs to be to use global blackout")]
        public byte MinimumTier { get; set; } = 3;
        [Description("The amount of energy used for the global blackout. Make sure it's not higher than the maximum amount of energy the minimum level you set can have")]
        public float AuxillaryDrain { get; set; } = 100f;
        [Description("Should the doors get locked during the blackout")]
        public bool LockDoors { get; set; } = true;

    }
}