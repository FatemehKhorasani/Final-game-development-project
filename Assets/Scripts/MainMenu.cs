using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static int currentCount;
    public int highScore;
    public Text texthighScore;
    public Text textScore;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        currentCount = 0;
        textScore.text = currentCount.ToString();
        highScore = PlayerPrefs.GetInt("highScore");
        texthighScore.text = highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //animator.Play();

        if (currentCount > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", currentCount);
        }

        textScore.text = currentCount.ToString();
        texthighScore.text = highScore.ToString();
    }

    

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ResetScoreValue()
    {
        PlayerPrefs.SetInt("highScore", 0); 
        highScore = 0; 
        texthighScore.text = highScore.ToString(); 
    }

    public void BackToMainMenuScene()
    {
        SceneManager.LoadScene(0);
    }
}
