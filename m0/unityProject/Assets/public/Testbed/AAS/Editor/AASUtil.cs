using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.AddressableAssets;

/*
	ref https://qiita.com/k7a/items/b4fd298bcb64dc968ad1

 */

public class AASUtil {

	[UnityEditor.MenuItem("Addressable/Build")]
    public static void Build()
    {
        BuildScript.PrepareRuntimeData(true, false, true, true, false, UnityEditor.BuildTargetGroup.Standalone, UnityEditor.BuildTarget.StandaloneWindows64);
    }
}
