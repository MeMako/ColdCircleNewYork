using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;

    [SerializeField]
    [Tooltip("time between shots")]
    float fireRate;

    [SerializeField] private Transform bulletspawn;

    bool canShoot = true;

    string m_tag;
    private Aim playerAimScript;
    public Vector2 aimDir;

    void Start()
    {
        m_tag = this.tag;

        switch (m_tag)
        {
            case "Player":
                playerAimScript = GetComponent<Aim>();
                break;
            default:
                break;
        }
    }

    void Update()
    {
        aimDir = playerAimScript.aimDir.normalized;

        if (canShoot && Input.GetMouseButton(0))
        {
            GameObject newBullet = Instantiate(bulletPrefab, bulletspawn.position, transform.rotation);
            newBullet.GetComponent<Rigidbody2D>().velocity = -newBullet.transform.up * 10f;

            canShoot = false;

            float temp = (fireRate / 2f) / 2f;
            float randomVariance = Random.Range(fireRate - temp, fireRate + temp);
            Invoke("FireRateWait", randomVariance);
        }
    }

    void FireRateWait()
    {
        canShoot = true;
    }
}
