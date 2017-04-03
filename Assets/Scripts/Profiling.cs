using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profiling : MonoBehaviour {
	

	void Start(){
		GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
		//timer = GetComponent<ProfilingTimer> ();

		ProfilingTimer.StartProfilingTime ("Speed");

		Instantiate (go);

		ProfilingTimer.EndProfilingTime ("Speed");
		ProfilingTimer.ShowProfilingTime ("Speed");
/*

		float start = Time.realtimeSinceStartup * 1000;
		Instantiate (go);
		float end = Time.realtimeSinceStartup * 1000;
		Debug.Log( start - end);*/

	}
}
