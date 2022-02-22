using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	private float speed = 1.5f;

	void Start () {
		
	}
	
	void Update () {
		MoveObstacle();
	}

	void MoveObstacle()
    {
		transform.Translate(-speed * Time.deltaTime, 0, 0);
	}
}
