using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBoxScript : MonoBehaviour
{
    public GameObject box;
    Rigidbody2D rb;
    

    void Start()
    {
        rb=box.GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="sunBullet")
        {
            rb.gravityScale=-1;
        }
        if(collision.gameObject.tag=="moonBullet")
        {
            rb.gravityScale=0;
        }
        if(collision.gameObject.tag=="starBullet")
        {
            rb.gravityScale=1;
        }
    }
}
