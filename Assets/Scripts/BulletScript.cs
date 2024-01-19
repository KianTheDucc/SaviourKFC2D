using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float playerScore;
    public TextMeshProUGUI text;
    public float spawnRate;

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

            
            collision.gameObject.GetComponent<RatHealthScript>().health -= 5;




            Destroy(this.gameObject);
        }
        else if (collision.gameObject.CompareTag("boundary"))
        {
            Destroy(this.gameObject);
        }
    }
}
