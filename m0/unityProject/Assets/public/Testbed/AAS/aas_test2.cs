using System.Collections;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine;

/*
	AssetReferenceを使ってロードする
	ref https://qiita.com/k7a/items/b4fd298bcb64dc968ad1
*/

public class aas_test2 : MonoBehaviour {

	[AssetReferenceTypeRestriction(typeof(Texture2D))]
    public AssetReference m_ref;

	public GameObject m_obj;

	// Use this for initialization
	IEnumerator Start () {
		
		var aop = Addressables.LoadAsset<Texture2D>(m_ref);
		yield return aop;

		var tex = aop.Result;
		if (tex!=null)
		{
			var render = m_obj.GetComponent<Renderer>();
			render.material.SetTexture("_MainTex",tex);
		}					
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
