using ModSettings;

namespace RavineBridgeFix
{
    internal class RavineBridgeFix : JsonModSettings
    {

        [Name("Ravine Bridge Fix")]
        [Description("Fix the bridge in the Ravine")]
        public bool fixBridge = false;




    }

    internal static class Settings
    {
        public static RavineBridgeFix options;

        public static void OnLoad()
        {
            options = new RavineBridgeFix();
            options.AddToModSettings("Ravine Bridge Fix", MenuType.Both);
        }
    }

}