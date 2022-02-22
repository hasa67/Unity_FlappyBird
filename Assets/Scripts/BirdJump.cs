using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdJump : MonoBehaviour {

	public Rigidbody2D bird;
	private float jumpForce = 10f;
	
	int score = 0;
	public Text scoreText;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump"))
        {
			bird.velocity = new Vector2(0, jumpForce);
        }
		
	}

	private void OnCollisionEnter2D(Collision2D collision)
    {
		if(collision.gameObject.tag == "Pipes")
        {
			Destroy(gameObject);
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


    }

	private void OnTriggerEnter2D(Collider2D collision)
    {
		if (collision.tag == "ScoreMaker")
		{
			score++;
			scoreText.text = score.ToString();
		}
	}
}
