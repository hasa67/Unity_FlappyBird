using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public GameObject[] obstacles;
	public GameObject newPosition;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
    {
		if(collision.tag == "Obstacle")
        {
			int counter = Random.Range(0, 4);
			Instantiate(obstacles[counter], new Vector2(newPosition.transform.position.x, obstacles[counter].transform.position.y), Quaternion.identity);
			Destroy(collision.gameObject);
        }
    }
}
