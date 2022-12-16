using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireforce = 20f;
    // Start is called before thedm first frame updatesn
    public void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireforce, ForceMode2D.Impulse);
    }
}
