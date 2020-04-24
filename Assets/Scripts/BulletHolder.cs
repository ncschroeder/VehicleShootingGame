using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHolder : MonoBehaviour
{
    public GameObject bulletPrefab;
    float bulletSpeed = 1000;
    GameObject bullet;
    Rigidbody2D bulletRigidBody;

    void Update()
    {
        if (Input.GetKeyDown("space"))
            fire();
    }

    public void fire()
	{
        bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
        bulletRigidBody = bullet.GetComponent<Rigidbody2D>();
        bulletRigidBody.AddForce(bulletRigidBody.transform.up * bulletSpeed);
        Destroy(bullet, 1);
	}
}
