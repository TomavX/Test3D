using UnityEngine;
using System.Collections;

public class HeroScript : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxis("Vertical");
        anim.SetFloat("speed",Input.GetAxis("Vertical"));
        transform.Translate(new Vector3(0, 0, .06f * -v));
        anim.SetBool("papa", Input.GetKey("space"));
	}
}
