using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureChange : MonoBehaviour {

	//テクスチャ変数
	public Material Mat;
	public Texture tex1;
	public Texture tex2;
	//変数設定
	public int random_num = 0;

	void Start () {
		Mat = GetComponent<Renderer> ().material;
	}

	void Update () {
		
	}

	//ランダムでテクスチャ変更
	public void TexChange(){		
		Debug.Log("テクスチャーチェンジ");

		random_num =  Random.Range (1,3);//1-2にしたいときは最大値を＋1

		switch (random_num) {
		case 1:
			Mat.SetTexture ("_EmissionMap", tex1);
			break;
		case 2:
			Mat.SetTexture ("_EmissionMap", tex2);
			break;
		}
	}
}
