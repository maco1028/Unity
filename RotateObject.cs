using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

	public float RY=45;

	void Start () {
		
	}

	void Update () {
		//変数で回転させる
		transform.Rotate(0, RY * Time.deltaTime, 0);
	}
}
