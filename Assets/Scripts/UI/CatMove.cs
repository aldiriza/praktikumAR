using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMove : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x + Time.deltaTime, transform.position.y, transform.position.z);
		if (transform.position.x > 0 )
			transform.position = new Vector3 (-.02f, transform.position.y, transform.position.z);
	}
}
