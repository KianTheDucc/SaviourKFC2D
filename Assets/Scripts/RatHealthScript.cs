using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatHealthScript : MonoBehaviour
{
    public float health;
    public float randnum;
    public GameObject Powerup;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0)
        {
            GameObject.Find("Bob").GetComponent<GunBehaviour>().IncrementScore();

            randnum = Random.Range(0, 20);

            if (randnum == 7) 
            {
                Instantiate(Powerup, gameObject.transform.position, Quaternion.identity);
            }

            Destroy(gameObject);
            
        }
    }
}
