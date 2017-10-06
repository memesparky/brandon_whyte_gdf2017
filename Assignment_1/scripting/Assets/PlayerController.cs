using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//rigid body is a class
public class PlayerController : MonoBehaviour {  //name
    public float speed = .3f; //have to add f after float, private means it cant be accessed outside of script
    private Rigidbody2D rigid; //public adds it in unity as shortcut
    // Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + new Vector3 (speed * Time.deltaTime, 0f, 0f); //like int++. Float is a decimal point.
        rigid.AddForce (new Vector2(10,0));//adds force to a player
	}
}
