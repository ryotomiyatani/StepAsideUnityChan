﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour {
	//Unityちゃんのオブジェクト
	private GameObject unitychan;
	//Unityちゃんとのカメラ位置
	private float difference;
	// Use this for initialization
	void Start () {
		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
		//Unityちゃんとのカメラの位置(z軸)の差を求める
		this.difference = unitychan.transform.position.z - this.transform.position.z;

	}

	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
	}
}
