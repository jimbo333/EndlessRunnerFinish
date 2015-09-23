using UnityEngine;
using System.Collections;

public class PlatformMovement : MonoBehaviour {
	public float scrollSpeed;
	public float minimumXPos = -50;
	public float resetPos = 50;

	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (scrollSpeed * Time.deltaTime, 0.0f, 0.0f);

		if(this.transform.position.x <= minimumXPos){
			transform.position = new Vector3 (resetPos, this.transform.position.y, 0.0f);
		}
	}
}