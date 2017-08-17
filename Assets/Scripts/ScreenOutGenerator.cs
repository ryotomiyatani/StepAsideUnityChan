using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOutGenerator : MonoBehaviour {
	private GameObject cameraObj;

	// Use this for initialization
	void Start () {
		this.cameraObj = GameObject.Find ("Main Camera");

	}

	// Update is called once per frame
	void Update () {
		float cameraObjZ = cameraObj.transform.position.z;
		if (cameraObjZ > transform.position.z) {
			Destroy (this.gameObject);

		}
		}

}
