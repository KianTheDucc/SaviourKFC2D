using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatHealthScript : MonoBehaviour
{
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0)
        {
            GameObject.Find("Bob").GetComponent<GunBehaviour>().IncrementScore();
            Destroy(gameObject);
            
        }
    }
}
