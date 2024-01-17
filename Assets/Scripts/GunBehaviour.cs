using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GunBehaviour : MonoBehaviour
{
    public Camera Camera;
    public TMP_Text text;
    public float playerScore;
    public GameObject bullet;
    public float power;
    public float spawnIncrement;

    // Start is called before the first frame update
    void Start()
    {
        spawnIncrement = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

    }   
    void Shoot()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 Direction = mousePos - transform.position;
        
        Direction.Normalize();
        
        float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
        
        
        
        GameObject bulletProjectile = Instantiate(bullet, transform.position, Quaternion.AngleAxis(angle, Vector3.forward));
        
        Rigidbody2D rb2d = bulletProjectile.GetComponent<Rigidbody2D>();

        rb2d.AddForce(Direction * power, ForceMode2D.Impulse);
    }

    public void IncrementScore()
    {
        playerScore += 1;

        text.text = $"Score: {playerScore}";

        text.ForceMeshUpdate();

        if (playerScore / 10 % 1 == 0)
        {
            GameObject.Find("RatSpawner").GetComponent<RatSpawnerScript>().spawnRate -= spawnIncrement;
        }
    }
    void OnDisable()
    {
        PlayerPrefs.SetFloat("score", playerScore);
    }


}
