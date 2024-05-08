using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBulltet : MonoBehaviour
{
    [HideInInspector] public string m_tag;

    bool checkCollisions = false;
    private void Start()
    {
        Invoke("DestroyBullet", 5f);
        Invoke("CheckCols", 0.1f);
    }


    void DestroyBullet()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (checkCollisions)
        { 
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Enemy")
        {
            //damage or kill
        }
        Destroy(this.gameObject);
        }
    }

    void CheckCols()
    {
        checkCollisions = true;
    }
}
