using MelonLoader.Utils;
using UnityEngine.Rendering.PostProcessing;

namespace RavineBridgeFix
{

    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();    

        }



        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {

           

            if (sceneName == "RavineTransitionZone" && Settings.options.fixBridge)
            {
                
                GameObject.Find("Art/Objects/OBJ_RailTrackCurveTrestleA_Group/OBJ_RailTrackCurveTrestleB_Prefab").gameObject.SetActive(false);
                Clones.ChangeObjects();

            }


        }

    }
}
