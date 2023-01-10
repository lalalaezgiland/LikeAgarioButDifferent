using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public GameObject _enemy;
    public Text _Lives;
    public float Increase;
    public GameObject _gameOverPaneli;

    int lives = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Bunu yapma sebebimiz ekran degil oyunun ortasýný kabul ediyor.

        transform.position = Vector3.MoveTowards(transform.position, mousePos, 10*Time.deltaTime);
        //3 parametre aliyor, 1.si basladigi nokta, 2.si hangi hedefa gidecegi, 3.su hizi.
        //transform.Rotate(_player.transform.position, mousePos, 20 * Time.deltaTime);

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            //transform.camera.localScale += new Vector3(Increase, Increase);
            Destroy(other.gameObject);

            lives -= 1;
            _Lives.text = "Lives " + lives;
        }
        if(lives == 0)
        {
            _gameOverPaneli.SetActive(true);
        }
    }
}
