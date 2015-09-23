using UnityEngine;
using System.Collections;

public class MoveAll : MonoBehaviour {
	public float scrollSpeed;
	public float destroyPos = -50;

	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (scrollSpeed * Time.deltaTime, 0.0f, 0.0f);

		if (this.transform.position.x <= destroyPos){
			Destroy(this.gameObject);
		}
	}
}
