using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class DegitalClock : MonoBehaviour {

	public Text degtime;
	public float hour,min,sec;

	void Start () {
		degtime = GetComponent<Text>() as Text;
	}
	
	// Update is called once per frame
	void Update () {
		DateTime nowtime =DateTime.Now;
		hour = nowtime.Hour;
		min = nowtime.Minute;
		sec = nowtime.Second;

		degtime.text = hour.ToString("00")+":"+min.ToString("00")+":"+sec.ToString("00");
	}
}
