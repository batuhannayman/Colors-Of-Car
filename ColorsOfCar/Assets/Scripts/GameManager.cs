using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject panel_MainMenu, panel_Game, panel_GameOver;
    [SerializeField] Text highest_Score, gameover_Score;
    public static GameManager instance;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        Time.timeScale = 0;
        LoadHighest();
    }

    public void StartClick()
    {
        Time.timeScale = 1;
        panel_MainMenu.SetActive(false);
        panel_Game.SetActive(true);
    }

    public void MenuClick()
    {
        SceneManager.LoadScene(0);
    }


    void LoadHighest()
    {
        if (PlayerPrefs.HasKey("highest_Score"))
        {
            highest_Score.text = PlayerPrefs.GetInt("highest_Score").ToString();
        }
        else
        {
            PlayerPrefs.SetInt("highest_Score", 0);
            highest_Score.text = PlayerPrefs.GetInt("highest_Score").ToString();
        }
    }

    public void GameOver()
    {
        if (sc_ScoreControlller.score > PlayerPrefs.GetInt("highest_Score"))
        {
            PlayerPrefs.SetInt("highest_Score", sc_ScoreControlller.score);
        }

        Time.timeScale = 0;
        panel_Game.SetActive(false);
        panel_GameOver.SetActive(true);
        gameover_Score.text = sc_ScoreControlller.score.ToString();
    }
}
