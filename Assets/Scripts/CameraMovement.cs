using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject[] monsters;
    static Vector3 yMovement;
    Vector3 moveBackDistance;
    static int speed;
    float maxYCoord = 110;
    public static bool moving;

    void Start()
    {
        moving = true;
        speed = 5;
        // Move up distance
        yMovement = new Vector3(0, 5 * Time.deltaTime, 0);

        // Move back to starting position after vehicle reaches top of background
        moveBackDistance = new Vector3(0, maxYCoord, 0);
    }

    void Update()
    {
        if (moving)
		{
            if (transform.position.y < maxYCoord)
            {
                transform.position += yMovement;
            }
            else
            {
                transform.position -= moveBackDistance;
                foreach (GameObject monster in monsters)
                {
                    monster.GetComponent<MonsterScript>().moveToRandomPosition();
                }

            }
        }
    }

    public static void increaseSpeed()
	{
        speed += 2;
        yMovement.y = speed * Time.deltaTime;
	}
}
