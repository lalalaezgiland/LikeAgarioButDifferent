using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class eatfood : MonoBehaviour
{
    public GameObject _yem;
    public Text Letters;
    public float Increase;
    Camera _camera;

    int Score = 0;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "yem")
        {
            transform.localScale += new Vector3(Increase, Increase);
            Camera.main.orthographicSize += 0.1f;
            Destroy(other.gameObject);

            


            Score += 1;
            Letters.text = "Score: " + Score;
        }
    }
}

