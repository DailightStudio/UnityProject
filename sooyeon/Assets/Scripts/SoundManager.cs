using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public GameObject chat;
    float sec;
    int random;
    public AudioSource source_hungry;
    public AudioClip soundClip_hungry;


    void Update ()
    {
        sec += 1f;
        if (sec >= 300f)
        {
            sec = 0f;
            random = Random.Range(1, 100);
            if (random <= 20)
            {
                chat.SetActive(true);
                StartCoroutine(StartRutine());
                source_hungry.PlayOneShot(soundClip_hungry, 1.0f);
            }     
        }
    }
    IEnumerator StartRutine()
    {
        yield return new WaitForSeconds(3f);
        chat.SetActive(false);
    }
}
