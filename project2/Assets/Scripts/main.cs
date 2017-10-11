using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public GameObject Character;
    public GameObject weapon;
    public Sprite stick;

	void Awake ()
    {
      
    }

    public void Onbutt()
    {
        weapon.GetComponent<SpriteRenderer>().sprite = stick;

    }
}
