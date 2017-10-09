using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController_Up : MonoBehaviour
{
    protected Animator animator;
    float directionX = 0;
    float directionY = 0;
    bool walking = false;
    public AudioSource source;
    public AudioClip soundClip;
    float sec;

    public GameObject Character;

    void Awake()
    {
        animator = Character.GetComponent<Animator>();
    }

    public void OnClickTouchUp()
    {
        walking = true;
        directionX = 0;
        directionY = 1;
    }

    public void OnClickStopUp()
    {
        walking = false;
        directionX = 0;
        directionY = 1;
        Character.transform.Translate(new Vector3(directionX, directionY, 0) * Time.deltaTime * 0.75f);
    }


    public void OnClickTouchDown()
    {
        walking = true;
        directionX = 0;
        directionY = -1;
    }

    public void OnClickStopDown()
    {
        walking = false;
        directionX = 0;
        directionY = -1;
    }

    public void OnClickTouchLeft()
    {
        walking = true;
        directionX = -1;
        directionY = 0;
    }

    public void OnClickStopLeft()
    {
        walking = false;
        directionX = -1;
        directionY = 0;
    }

    public void OnClickTouchRight()
    {
        walking = true;
        directionX = 1;
        directionY = 0;
    }

    public void OnClickStopRight()
    {
        walking = false;
        directionX = 1;
        directionY = 0;
    }

    void Update()
    {      
        if (walking)
        {
            sec += 1f;
            if (sec >= 25f)
            {
                source.PlayOneShot(soundClip, 1.0f);
                sec = 0f;
            }            
            Character.transform.Translate(new Vector3(directionX, directionY, 0) * Time.deltaTime * 0.75f);
        }
        animator.SetFloat("DirectionX", directionX);
        animator.SetFloat("DirectionY", directionY);
        animator.SetBool("Walking", walking);
    }
}