using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidGimikScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="skyBullet")
        {
            Destroy(this.gameObject);
        }
    }
}
