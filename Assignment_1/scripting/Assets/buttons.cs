using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour {
    private float x;
    private float y;
    Rigidbody2D rb;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("vertical");
        rb.AddForce(new Vector2(x * Time.deltaTime, y  * Time.deltaTime));
	}
}
