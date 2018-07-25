using System.Collections;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine;

/*
	アドレスを指定して読む
	Ref  https://qiita.com/k7a/items/b4fd298bcb64dc968ad1
 */

public class aas_test1 : MonoBehaviour {
	public GameObject m_obj;
	public Texture2D m_tex;

	// Use this for initialization
	IEnumerator Start () {
		m_tex = null;

		var aop = Addressables.LoadAsset<Texture2D>("Assets/AddressableAssets/try3/m_lower_a.bmp");
		aop.Completed += op => {m_tex = aop.Result;};
		yield return aop;

		if (m_tex!=null)
		{
			var render = m_obj.GetComponent<Renderer>();
			render.material.SetTexture("_MainTex",m_tex);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
