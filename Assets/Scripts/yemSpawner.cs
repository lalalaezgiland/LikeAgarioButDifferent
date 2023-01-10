using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yemSpawner : MonoBehaviour
{
    public GameObject yem;
    void Start()
    {
        for (int i = 0; i < 10; i++)
            InvokeRepeating("YemSpawner", 1, 1);
        //sürekli yapmasi icin bir kod, ayni kodu bir suru kere yazmamak icin

    }

    // Update is called once per frame
    void Update()
    {

    }
    void YemSpawner()
    {
        float posx = Random.Range(-30, 30);
        float posy = Random.Range(-30, 30);
        Vector2 pozisyon = new Vector2(posx, posy);

        Instantiate(yem, pozisyon, Quaternion.identity);
    }
}
