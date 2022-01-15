using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadHighscore : MonoBehaviour
{
    public Text teksHighscore;
    // Start is called before the first frame update
    void Start()
    {
        teksHighscore.text = "Highscore : " + LoadHighScore().ToString();
    }

    public static float LoadHighScore() {
        float hg = 0;
        if (!PlayerPrefs.HasKey ("highscore")) {
            PlayerPrefs.SetFloat ("highscore", 0);
        } else {
            hg = PlayerPrefs.GetFloat ("highscore");
        }
        return hg;
    }

    public static void SaveHighScore(float score) {
        float hg = 0;
        if (!PlayerPrefs.HasKey ("highscore")) {
            PlayerPrefs.SetFloat ("highscore", 0);
        } else {
            // hg -= hg;
            // PlayerPrefs.SetFloat ("highscore", hg);
            hg=PlayerPrefs.GetFloat("highscore");
            if(score >= hg){
                PlayerPrefs.SetFloat("highscore", score);
            }else{

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
