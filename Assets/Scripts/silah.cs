using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silah : MonoBehaviour
{
    public GameObject mermi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(mermi, transform.position, Quaternion.identity);
    }


}
