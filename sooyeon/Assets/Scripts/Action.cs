using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    public AudioSource source_food;
    public AudioClip soundClip_food;
    public GameObject Character;
    public GameObject chat2;
    public GameObject meat;
    GameObject target;


    void Awake()
    {     
    }

    public void Eat()
    {       
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(Character.transform.position, 1f);
        foreach (Collider2D en in hitColliders)
        {
            Rigidbody2D rb = en.GetComponent<Rigidbody2D>();
            if (rb != null && rb.tag == "meat")
            {
                chat2.SetActive(true);
                StartCoroutine(StartRutine());
                
                float randomX = Random.Range(-15f, 15f);
                float randomY = Random.Range(-15f, 15f);
                rb.gameObject.transform.Translate(new Vector3(randomX, randomY, 0));

                source_food.PlayOneShot(soundClip_food, 1.0f);
            }
        }        
    }
    IEnumerator StartRutine()
    {
        yield return new WaitForSeconds(3f);
        chat2.SetActive(false);
    }

    public void Attack()
    {
        target = GameObject.Find("tree");
        target.GetComponent<Animator>().SetBool("stand", false);
        target.GetComponent<Animator>().SetBool("hit", true);
            StartCoroutine(StartWait());

    }
    IEnumerator StartWait()
    {
        yield return new WaitForSeconds(0.5f);
        target.GetComponent<Animator>().SetBool("hit", false);
        target.GetComponent<Animator>().SetBool("stand", true);
    }




}
