using UnityEngine;
using System.Collections;
using System.Timers;

public class Timer : MonoBehaviour {
	public float score;
	public float time;
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		score = Mathf.Floor(time);
		Debug.Log (score);
	}
}
