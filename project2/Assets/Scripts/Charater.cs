using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charater : MonoBehaviour
{
    float attackSpeed = 1f;
    float time = 0f;
    GameObject hitEnemy;
    public GameObject force;

    void Start()
    {
        

    }

    void OnCollisionStay2D(Collision2D col)
    {                     
        if (col.gameObject.tag == "enemy")
        {
            gameObject.transform.GetChild(0).GetComponent<Animator>().SetBool("walk", false);
            time += attackSpeed * Time.deltaTime;
            if (time >= attackSpeed) //공속
            {                
                gameObject.transform.GetChild(0).GetComponent<Animator>().SetBool("attack", true);
                force.transform.GetComponent<Animator>().SetBool("attack", true);
                StartCoroutine(Attack());
                hitEnemy = col.gameObject;                
                time = 0f;
            }                
        }
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(0.1f);
        gameObject.transform.GetChild(0).GetComponent<Animator>().SetBool("attack", false);
        force.transform.GetComponent<Animator>().SetBool("attack", false);
        hitEnemy.GetComponent<SpriteRenderer>().color = Color.red;
        StartCoroutine(Hit());
    }

    IEnumerator Hit()
    {
        yield return new WaitForSeconds(0.1f);
        hitEnemy.GetComponent<SpriteRenderer>().color = Color.white;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            gameObject.transform.GetChild(0).GetComponent<Animator>().SetBool("walk", true);
        }            
    }

}
