using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

//時計のプログラム
public class DegitalClock : MonoBehaviour {

	public Text degtime;
	public float hour,min,sec;

	void Start () {
		degtime = GetComponent<Text>() as Text;
	}
	
	//日付と時間を取得
	void Update () {
		DateTime nowtime =DateTime.Now;
		hour = nowtime.Hour;
		min = nowtime.Minute;
		sec = nowtime.Second;
	//時間を表示
		degtime.text = hour.ToString("00")+":"+min.ToString("00")+":"+sec.ToString("00");
	}
}
