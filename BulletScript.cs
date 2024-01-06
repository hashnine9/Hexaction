using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb;
    public float force=20;

    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);     //마우스 커서 위치
        Vector3 direction = mousePos-transform.position;                //마우스 커서 위치 - 플레이어 위치
        Vector3 rotation = transform.position - mousePos;               //플레이어 위치 - 마우스 커서 위치
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;    //아크탄젠트(삼각함수)를 이용해 라디안값을 구하고 이를 각도로 변환
        transform.rotation = Quaternion.Euler(0,0,rot+90);                  //플레이어의 회전값을 변환한 각도로 치환
        Invoke("DestroyBullet", 10);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="void")
        {
            Destroy(this.gameObject);
        }
        else if(collision.gameObject.tag=="seedBox")
        {
            Destroy(this.gameObject);
        }
        else if(this.gameObject.tag=="seedBullet")
        {
            if(GetBrownBoxScript.earthCount==true)
            {
                Destroy(this.gameObject);
            } else
            {
                Invoke("DestroyBullet", 0.1f);
                force=0;
                this.GetComponent<Animator>().Play("bulletDelete");
            }
        }
        else
        {
            force=0;
            this.GetComponent<Animator>().Play("bulletDelete");
            Invoke("DestroyBullet", 0.1f);
        }
    }

    void DestroyBullet()
    {
        Destroy(this.gameObject);
    }
}
