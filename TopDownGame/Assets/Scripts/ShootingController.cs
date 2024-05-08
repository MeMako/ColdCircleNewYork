using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingController : MonoBehaviour
{
    public Text ammocount ; public int magsize; private int currentammo;

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

        currentammo = magsize;

        ammocount.text = currentammo.ToString() + "/" + magsize.ToString();

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
            currentammo--;
            ammocount.text = currentammo.ToString() + "/" + magsize.ToString();
            Invoke("FireRateWait", randomVariance);
        }
        if (Input.GetKeyDown(KeyCode.W)) { canShoot = false; Invoke("reloadwait", 8f); }
    }

    void FireRateWait()
    {
        canShoot = true;
        if (currentammo == 0)
        {

            canShoot = false;

            Invoke("reloadwait", 8f);

        }
    }
    void reloadwait ()
    {

        canShoot = true;
        
        currentammo = magsize;

        ammocount.text = currentammo.ToString() + "/" + magsize.ToString();

    }
}
