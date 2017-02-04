using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyUpdate : MonoBehaviour {
	
	public float minDistance;
	GameObject player;
	public float speed;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
		speed = 5f;
		minDistance = 2f;
	}
	
	// Update is called once per frame
	void Update () {
		// always look at player
		transform.LookAt(player.transform);
		
		if (Vector3.Distance(transform.position, player.transform.position) > minDistance) {
			transform.position += transform.forward * speed * Time.deltaTime;
		}
	}
}
