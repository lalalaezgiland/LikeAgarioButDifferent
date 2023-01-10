using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menzil : MonoBehaviour
{
    public GameObject _mermi;


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "mermi")
        {
            Destroy(other.gameObject);
        }
    }
}
