using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotasyon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //objenin z eksenini mousenin oldu�u konuma �eviriyor
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // burda mousenin pozisyonunu ald�k
        Vector3 rotation = mousepos - transform.position; // rotation ad�nda bir de�i�ken at�p i�erisine mousepos-transform.position de�erini atad�k
        float rot2 = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot2);


    }
}
