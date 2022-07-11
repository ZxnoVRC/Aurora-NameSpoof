using MelonLoader;
using System;
using System.Collections;
using System.IO;
using UnityEngine;
using VRC.Core;

[assembly: MelonInfo(typeof(Aurora.Mod), "Zxno", "1", "Zxno")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace Aurora
{
    public class Mod : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            MelonCoroutines.Start(changename());
        }







      

        public static bool nametest = true;
        public static IEnumerator changename()
        {
            string GettLine(string fileName, int line)
            {
                using (var str = new StreamReader(fileName))
                {
                    for (int cock = 1; cock < line; cock++)
                        str.ReadLine();
                    return str.ReadLine();
                }
            }

            //dont bully me i know the code is dogshit and unoptimized but it still works fine without fps drops and i am working on other shit rn :(

            if (GettLine("Mods/config.txt", 1) == "0")
            {
                if (GettLine("Mods/config.txt", 1) == "1")
                {
                    Console.WriteLine(GettLine("Mods/config.txt", 1) + " 31232");
                    while (nametest)
                    {

                        yield return new WaitForEndOfFrame();
                        try
                        {
                            if (APIUser.CurrentUser._displayName_k__BackingField != RoomManager.field_Internal_Static_ApiWorld_0.authorName)
                            {
                                if (RoomManager.field_Internal_Static_ApiWorld_0.authorId != "8JoV9XEdpo")
                                {

                                    APIUser.CurrentUser._displayName_k__BackingField = RoomManager.field_Internal_Static_ApiWorld_0.authorName;
                                    APIUser.CurrentUser._id_k__BackingField = RoomManager.field_Internal_Static_ApiWorld_0.authorId;
                                }
                            }


                        }
                        catch { }
                    }
                }
                else if (GettLine("Mods/config.txt", 1) == "2")
                {
                    while (nametest)
                    {
                        yield return new WaitForEndOfFrame();
                        try
                        {
                            if (APIUser.CurrentUser._displayName_k__BackingField != RoomManager.field_Internal_Static_ApiWorld_0.authorName)
                            {
                                if (RoomManager.field_Internal_Static_ApiWorld_0.authorId != "8JoV9XEdpo")
                                {

                                    APIUser.CurrentUser._displayName_k__BackingField = GettLine("Mods/config.txt", 2);
                                    APIUser.CurrentUser._id_k__BackingField = GettLine("Mods/config.txt", 3);
                                }
                            }
                        }
                        catch { }
                    }
                }
            }
        }




    }
}
