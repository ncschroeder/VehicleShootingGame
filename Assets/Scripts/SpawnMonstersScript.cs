using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class SpawnMonstersScript : MonoBehaviour
{
    public GameObject monsterPrefab;
    GameObject monster;
    float respawnTime, spawningYCoord, maxSpawningYCoord;
    float maxXCoord, minXCoord;
    Vector3 spawningCoords;
    // Start is called before the first frame update
    void Start()
    {
        spawningCoords = new Vector3();
        respawnTime = 1;
        spawningYCoord = 10;
        maxSpawningYCoord = 40;
        maxXCoord = Camera.main.orthographicSize * Screen.width / Screen.height - 2;
        minXCoord = maxXCoord * -1;

        StartCoroutine(monsterWave());
    }

    // Update is called once per frame
    void Update()
    {
        if (spawningYCoord < maxSpawningYCoord)
            spawningYCoord += 0.1f;
        else
            spawningYCoord = 10;
    }

    void spawnMonster()
	{
        monster = Instantiate(monsterPrefab) as GameObject;
        spawningCoords.x = Random.Range(minXCoord, maxXCoord);
        spawningCoords.y = spawningYCoord;
        monster.transform.position = spawningCoords;
	}

    IEnumerator monsterWave()
	{
        while (true)
        {
            yield return new WaitForSeconds(2);
            spawnMonster();
        }
	}
}
*/