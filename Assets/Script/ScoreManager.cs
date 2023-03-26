using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI highScoreText;

    public static ScoreManager instance;

    public CharacterController playerCharacter; 
    public float Score=0;


    void Awake(){
        instance = this;
    }
    void Start()
    {
        Score =0;

        
        if(!PlayerPrefs.HasKey("HighScore")){
            PlayerPrefs.SetFloat("HighScore", 0);
        }
         
        highScoreText.text = "HighScore: " + PlayerPrefs.GetFloat("HighScore").ToString("0"); 

    }

    // Update is called once per frame
    void Update()
    {
        if(!playerCharacter.oldumMu){
            Score+= Time.deltaTime;
        }
        else{
              //check for highscore



        }
   

        scoreText.text = "Score: " + Score.ToString("0");

    }

public void UpdateHighscore(){
    if(Score > PlayerPrefs.GetFloat("HighScore")){
        PlayerPrefs.SetFloat("HighScore", Score);
    }
}

}




