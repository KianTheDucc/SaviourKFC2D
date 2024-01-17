using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatSpawnerScript : MonoBehaviour
{
    public GameObject Rat;
    public float spawnRate = 5;
    private float timer = 0;
    public float heightOffset = 90;
    public float playerScore;

    // Start is called before the first frame update
    void Start()
    {
        spawnRat();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnRat();
            timer = 0;
        }
        

    }
    void spawnRat()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        float leftmostPoint = transform.position.x - heightOffset;
        float rightmostPoint = transform.position.x + heightOffset;

        Instantiate(Rat, new Vector3(Random.Range(leftmostPoint, rightmostPoint), Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}