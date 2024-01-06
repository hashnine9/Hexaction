using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmPlay : MonoBehaviour
{
    public GameObject bgm;
    public AudioSource audioSource;

    void Start()
    {
        DontDestroyOnLoad(bgm);
        audioSource = bgm.GetComponent<AudioSource>();
        audioSource.Play();

    }
}