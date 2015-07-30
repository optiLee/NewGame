﻿using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour
{
	float speed = 100f;
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		float dirX = Input.GetAxis("Horizontal");
		//if (dirX != 0)
		//	print ("Update : " +dirX);

		Vector2 movement = new Vector2 (dirX, 0);		
		GetComponent<Rigidbody2D>().velocity = movement * speed;
		//GetComponent<Rigidbody2D> ().rotation = Quaternion.Euler (0, 0, GetComponent<Rigidbody>().velocity.x * -tilt);

		// 좌우 이동에 따른 Hero 방향변경
		if (dirX < 0)
			GetComponent<RectTransform>().localScale = new Vector3(-1, 1, 1);
		else if (dirX > 0)
			GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
	}
}
