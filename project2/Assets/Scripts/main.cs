using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public GameObject Character;
    GameObject weapon;
    public Sprite stick;

	void Awake ()
    {
       weapon = Character.transform.GetChild(0).transform.GetChild(0).transform.FindChild("001_cloth_right_arm").transform.GetChild(0).transform.GetChild(0).gameObject;
    }

    public void Onbutt()
    {
        weapon.GetComponent<SpriteRenderer>().sprite = stick;

    }
}
