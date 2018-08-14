using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneChange : MonoBehaviour {

	public int scene_num = 0;

	// Update is called once per frame
	void Update () {
				
		switch(scene_num)
			
		{
			
		case 1: Application.LoadLevel("Star_Field01");
			Debug.Log (scene_num);
			break;
			
		case 2: Application.LoadLevel("Star_Field02");			
			break;
		}

	}

	public void Scene01() {		
		scene_num = 1;		
	}

	public void Scene02(){
		scene_num = 2;
	}
}
