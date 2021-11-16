using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public void onPlay() {
        SceneManager.LoadScene("Game");
    }

    public void onPanduan() {
        SceneManager.LoadScene("Panduan");
    }

    public void onKredit() {
        SceneManager.LoadScene("Kredit");
    }

    public void onMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void onExit() {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
