using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMoving : MonoBehaviour
{
    float random;
    
    void Awake ()
    {
        random = Random.RandomRange(0.05f, 2f);
    }
	
	void Update ()
    {        
        gameObject.transform.Translate(Time.deltaTime * random, 0f, 0f);
	}
}
