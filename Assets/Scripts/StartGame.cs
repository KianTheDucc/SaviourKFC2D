using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Start_Game()
    {
        SceneManager.LoadScene("Main_Scene");
        SceneManager.UnloadSceneAsync("Main_Menu");
    }

    public void Quit_Game()
    {
        Application.Quit();
    }
}
