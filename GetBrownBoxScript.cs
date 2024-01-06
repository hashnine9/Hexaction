using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBrownBoxScript : MonoBehaviour
{
    public static bool earthCount;

    void Start()
    {
        earthCount=false;
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="earthBullet")
        {
            Destroy(gameObject);
            earthCount=true;
        }
    }
}
