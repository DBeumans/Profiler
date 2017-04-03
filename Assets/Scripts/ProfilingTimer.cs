using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfilingTimer : MonoBehaviour {

	static float startTime;

	private static readonly Dictionary<string,float> profilingTimeList = new Dictionary<string,float>();

	public static void StartProfilingTime(string text) {
		profilingTimeList[text] = Time.realtimeSinceStartup * 1000;
		Debug.Log( text + " Time: " + "\n" +"MiliSeconds: "  + profilingTimeList[text]) ;
	}

	public static void EndProfilingTime(string text) {
		if(!containsKey(text) )
			return;
		float end = Time.realtimeSinceStartup * 1000;
		float diff = end - profilingTimeList[text];
		Debug.Log( "Difference " +  text +": " + diff + "\n" + profilingTimeList[text]);
	}

	public static void removeTime(string time) {
		profilingTimeList.Remove (time);
	}

	private static bool containsKey (string text) {
		return profilingTimeList.ContainsKey (text); 
	}

	public static void ShowProfilingTime(string text) {
		if(!containsKey(text) )
			return;
		Debug.Log (profilingTimeList[text]);
	}
}