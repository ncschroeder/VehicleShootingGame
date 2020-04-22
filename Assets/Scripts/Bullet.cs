using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
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

    void OnTriggerEnter2D(Collider2D hitInfo)
	{
        if (hitInfo.name == "Monster")
            hitInfo.GetComponent<Monster>().die();
	}
}
