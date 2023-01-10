using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
            InvokeRepeating("EnemySpawner", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnemySpawner()
    {
        float posx = Random.Range(-30, 30);
        float posy = Random.Range(-30, 30);
        Vector2 pozisyon = new Vector2(posx, posy);

        Instantiate(enemy, pozisyon, Quaternion.identity);
    }
}
