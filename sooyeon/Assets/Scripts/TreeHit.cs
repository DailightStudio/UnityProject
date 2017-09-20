using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHit : MonoBehaviour
{
	void Start ()
    {
		
	}
	
	public void Hit ()
    {
        gameObject.GetComponent<Animator>().SetBool("hit", false);
        gameObject.GetComponent<Animator>().SetBool("stand", true);
	}
}
