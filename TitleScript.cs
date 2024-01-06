using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    public GameObject pressStart;

    int counter=0;
    int maxCount=40;

    bool flag;

    void Start()
    {
        counter=0;
        flag=true;
        pressStart.SetActive(flag);
    }

    void FixedUpdate()
    {
        counter=counter+1;
        if(counter>=maxCount)
        {
            pressStart.SetActive(flag);
            counter=0;
            flag=!flag;
        }
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("prolog");
        }
    }
}

