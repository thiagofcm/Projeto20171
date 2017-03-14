using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float ForcaDoPulo = 10f;
    public AudioClip somPulo;
    public AudioClip somMorte;

    private  Animator anim;
    private Rigidbody rb;
    private AudioSource audiosource;
    private bool pulando = false;
             
	void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        audiosource = GetComponent<AudioSource>();
	}
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            anim.Play("pulando");
            audiosource.PlayOneShot(somPulo);
            rb.useGravity = true;
            pulando = true;
        }

	}

     void FixedUpdate()
    {
        if(pulando)
        {
            pulando = false;
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * ForcaDoPulo, ForceMode.Impulse); 
        }
    }

    private void OnCollisionEnter(Collision outro)
    {
        if (outro.gameObject.tag == "obstaculo")
        {
            rb.AddForce(new Vector3(-0.5f, 0.2f, 0f), ForceMode.Impulse);
            rb.detectCollisions = false;
            anim.Play("morrendo");
            audiosource.PlayOneShot(somMorte); 
        }
    }

}
