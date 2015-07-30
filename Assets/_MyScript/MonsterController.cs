using UnityEngine;
using System.Collections;

public class MonsterController : MonoBehaviour {

	float speed = 200f;

	// Use this for initialization
	void Start () {
		bool isSpawn = false;

		if (!isSpawn) {
			//GetComponent<RectTransform> ().position.x = Random.Range (-320, 650);
			//GetComponent<RectTransform> ().position.y = -175;
			//GetComponent<RectTransform> ().localScale = new Vector2 (20, -75);
			GetComponent<RectTransform> ().localPosition = new Vector2 (Random.Range (-500, 200), -175);

			float dirY = Input.GetAxis ("Vertical");

			Vector2 movement = new Vector2 (dirY, 0);	
			GetComponent<Rigidbody2D> ().velocity = movement * speed;

			if(GetComponent<RectTransform> ().localPosition.y > -120)
				isSpawn = true;
		}

		float dirX = Input.GetAxis("Horizontal");
		Vector2 movementX = new Vector2 (dirX, 0);
		GetComponent<Rigidbody2D> ().velocity = movementX * speed;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
