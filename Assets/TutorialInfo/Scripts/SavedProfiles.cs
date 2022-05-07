using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CreateAssetMenu(fileName = "new Profile", menuName = "SavedProfiles", order = 0)]
public class SavedProfiles : ScriptableObject
{
    public string ProfileName= "";

   [Min(1)] public int Desired = 1;

    private void OnValidate()
    {
        string assetPath = AssetDatabase.GetAssetPath(this.GetInstanceID());
        AssetDatabase.RenameAsset(assetPath, ProfileName);
        AssetDatabase.SaveAssets();
    }
}
