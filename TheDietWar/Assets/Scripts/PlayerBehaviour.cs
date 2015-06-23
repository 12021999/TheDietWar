using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

	void Start () {
	
	}

    void Movimentation()
    {
        if (Input.acceleration.x > 0)
        {
            rigidbody2D.velocity = new Vector2(Input.acceleration.x * 0.5f,0);
        }
        else if (Input.acceleration.x < 0)
        {
            rigidbody2D.velocity = new Vector2(Input.acceleration.x * -0.5f, 0);
        }
    }

	void FixedUpdate () 
    {
        Movimentation();
	}
}
