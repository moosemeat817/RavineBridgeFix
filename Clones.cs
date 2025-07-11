using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RavineBridgeFix
{
    public class Clones : MonoBehaviour
    {


        public static string[,] itemDataArray =
        {
            {"0_Scene",              "1_Name"},

            {"RuralRegion",  "OBJ_BullseyeTarget_Prefab"},
            {"RuralRegion",  "OBJ_SignYieldB_Prefab"},
            {"RuralRegion",  "OBJ_WeathervaneA_Prefab"},
            {"RuralRegion",  "OBJ_HayCartA_Prefab"},

            {"RuralRegion",  "OBJ_WoodStand_B_Prefab (2)"},
            {"RuralRegion",  "OBJ_WoodStand_A_Prefab (1)"},
            {"RuralRegion",  "STRSPAWN_BarnA_prefab"},

            {"RuralRegion",  "STRSPAWN_HuntersBlind_Prefab"},

            {"RuralRegion",  "OBJ_FlagPole_Prefab"},

            {"RuralRegion",  "OBJ_FenceWood_Tall2_PostB_Prefab (1)"},

            {"RavineTransitionZone",  "OBJ_RailTrackCurveTrestleA_Prefab"},


        };

        public static void ChangeObjects()
        {

            GameObject findTargetGO = new GameObject();



            for (int i = 1; i < itemDataArray.GetLength(0); i++)
            {
                // ----- Find Name -----------------------------------------------------------------
                if (GameObject.Find(itemDataArray[i, 1]) == null)
                {
                    //MelonLogger.Msg("ChangeObject is null.");
                    continue;
                }
                else
                {
                    findTargetGO = GameObject.Find(itemDataArray[i, 1]);
                    // GameObject.Find cannot find for already inactive game objects. So this needs to be reloaded after confermation.
                }
                // -------------------------------------------------------------------------------------


                if (findTargetGO != null)
                {
                    // ----- Scene check -----------------------------------------------------------------
                    if (findTargetGO.scene.name != itemDataArray[i, 0]) // Scene 
                    {
                        //MelonLogger.Msg("Scene name does not match.");
                        continue;
                    }
                    // -------------------------------------------------------------------------------------


                    // ==============================================================================================================
                    // Pleasant Valley
                    // ==============================================================================================================

                    string scene = GameManager.m_ActiveScene;


                    if (scene == "RavineTransitionZone")
                    {


                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_RailTrackCurveTrestleA_Prefab" && !GameObject.Find("OBJ_RailTrackCurveTrestleA_Prefab(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-16.2254f, 134.6376f, -102.5837f),
                                Quaternion.Euler(0.5455f, 29.1f, 359.9f)
                            );
                        }
                        // ------------------------------------------------------------------------------------------


 



                    }





                }

            }

        }

    }
}
