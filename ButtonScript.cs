using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    SpriteRenderer sr;

    public GameObject floor;

    public AudioSource audioSource;
    public AudioClip audioClear;

    bool flag;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        sr = GetComponent<SpriteRenderer>();

        flag=false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(flag==false)
        {
            audioSource.clip=audioClear;
            audioSource.Play();
            flag=true;
        }
        sr.color=new Color(1,1,1,1);
        floor.SetActive(false);
    }
}