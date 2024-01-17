using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatSpawnerScript : MonoBehaviour
{
    public GameObject Rat;
    public float spawnRate = 2.5f;
    private float timer = 0;
    public float heightOffset = 5;
    public float playerScore;
    public Transform[] spawnpoints;



    

    // Start is called before the first frame update
    public void Start()
    {
        spawnRat();
    }

    // Update is called once per frame
    public void Update()
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
        //float lowestPoint = transform.position.y - heightOffset;
        //float highestPoint = transform.position.y + heightOffset;
        //float leftmostPoint = transform.position.x - heightOffset;
        //float rightmostPoint = transform.position.x + heightOffset;
        //float RatSpawnX = Random.Range(leftmostPoint, rightmostPoint);
        //float RatSpawnY = Random.Range(lowestPoint, highestPoint);
        int randomIndex = Random.Range(0, spawnpoints.Length);

        Debug.Log("Rat spawn attempted");

        Instantiate(Rat, spawnpoints[randomIndex].position, transform.rotation);

        

    }
}