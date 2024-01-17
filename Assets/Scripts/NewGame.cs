using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public float playerScore;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onclick()
    {
        SceneManager.LoadScene("Main_Scene");

        SceneManager.UnloadSceneAsync("Death_Scene");
    }
    private void OnEnable()
    {
        playerScore = PlayerPrefs.GetFloat("score");

        text.text = $"You Died! Your score was: {playerScore}";
    }
}
