using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour {
    public float speed = 10f;
    Animator my_animator;
	// Use this for initialization
	void Start () {
		my_animator = GetComponent <Animator > ();
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveHorizontal, 0f, 0f) * Time.deltaTime * speed;
        if (moveHorizontal > 0)
        {
            my_animator.SetTrigger("isWalking");
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (moveHorizontal < 0)
        {
            my_animator.SetTrigger("isWalking");
            transform.localScale = new Vector3(-1f,1f,1f);
        }
        else
            my_animator.SetTrigger("isIdle");
        
	}
}
