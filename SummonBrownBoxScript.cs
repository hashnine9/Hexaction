using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonBrownBoxScript : MonoBehaviour
{
    public GameObject box;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(GetBrownBoxScript.earthCount==true)
        {
            if(collision.gameObject.tag=="walls")
            {
                Vector3 pos;
                pos=this.gameObject.transform.position;
                Instantiate(box, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
            }
        }
    }
}
