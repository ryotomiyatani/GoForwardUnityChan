using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
	//キューブの移動速度
	private float speed = -0.2f;

	//消滅位置
	private float deadLine = -10;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//キューブを移動させる
		transform.Translate(this.speed, 0, 0);

		//画面外に出たら破壊する
		if(transform.position.x < deadLine){
			Destroy(gameObject);
		}
		
	}

	//衝突時に衝突音の再生
	void OnCollisionEnter2D(Collision2D collision){
		AudioClip clip = gameObject.GetComponent<AudioSource> ().clip;
		if (collision.gameObject.tag == "Block") {
			gameObject.GetComponent<AudioSource> ().PlayOneShot (clip);
		}
		if (collision.gameObject.tag == "Ground") {
			gameObject.GetComponent<AudioSource> ().PlayOneShot (clip);
		}
			
	}
}
