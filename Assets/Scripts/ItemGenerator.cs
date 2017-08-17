using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {
	//Unityちゃん
	public GameObject unityChan;
	//カメラ
	public GameObject camera;

	//carPrefabを入れる
	public GameObject carPrefab;
	//coinPrefabを入れる
	public GameObject coinPrefab;
	//cornPrefabを入れる
	public GameObject cornPrefab;
	//スタート地点
	private int startPos = -160;
	//ゴール地点
	private float golePos = 120f;
	//アイテムを出すx軸の範囲
	private float posRange = 3.4f;

	int distance = 0;



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float unityChanPosZ = unityChan.transform.position.z + 40;

		float destroyLine = camera.transform.position.y;
		Debug.Log (unityChan.transform.position.z);
	
		if(unityChanPosZ < golePos){
		if (unityChan.transform.position.z >= -245 + distance ) {
			distance += 15;
			Debug.Log (distance);
			//一定の距離ごとにアイテムを生成
			for (float i = unityChanPosZ; i < unityChanPosZ + 15; i += 15) {
				
				//どのアイテムを出すのかをランダムに設定
				int num = Random.Range (0, 10);
				if (num <= 1) {
					//コーンをx軸方向に一直線に生成
					for (float j = -1; j <= 1; j += 0.4f) {
						GameObject cone = Instantiate (cornPrefab) as GameObject;
						cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, i);
					}
				} else {
					for (int j = -1; j < 2; j++) {
						//アイテムの種類を決める
						int item = Random.Range (1, 11);
						//アイテムを置くZ軸のオフセットをランダムに設定
						int offsetZ = Random.Range (-5, 6);
						//60%コイン配置：30%車配置：10%何もなし
						if (1 <= item && item <= 6) {
							//コインを生成
							GameObject coin = Instantiate (coinPrefab) as GameObject;
							coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
						} else if (7 <= item && item <= 9) {
							//車を生成
							GameObject car = Instantiate (carPrefab) as GameObject;
							car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
						}
					}
				}
			}
		}
	}

}
}
