using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sc_ScoreControlller : MonoBehaviour
{
    [SerializeField] Text txt_Score;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        TextChange(0);
    }

    void OnTriggerEnter(Collider collider) 
    {
        if (sc_CarColorController.car_Color == "red")
        {
            RedColorCheck(collider);
        }
        else if (sc_CarColorController.car_Color == "yellow")
        {
            YellowColorCheck(collider);
        }
        else if (sc_CarColorController.car_Color == "gray")
        {
            GrayColorCheck(collider);
        }
    }

    void TextChange(int i)
    {
        txt_Score.text = i.ToString();
        CarSpeed(i);
    }

    void GameOver()
    {
        GameManager.instance.GameOver();
        sc_SFXController.instance.PlayLoseSFX();
    }

    void DestroyBall(Collider t_collider)
    {
        Destroy(t_collider.gameObject);
    }

    void CarSpeed(int i)
    {
        if (i > 500)
        {
            sc_CarController.move_Speed = 12f;
        }
        else if (i > 300)
        {
            sc_CarController.move_Speed = 11f;
        }
        else if (i > 150)
        {
            sc_CarController.move_Speed = 10.5f;
        }
        
    }

    void RedColorCheck(Collider t_collider)
    {
        if (t_collider.gameObject.tag == "RedBall")
        {
            score++;
            TextChange(score);
            DestroyBall(t_collider);
        }

        else if (t_collider.gameObject.tag == "YellowBall" || t_collider.gameObject.tag == "GrayBall")
        {
            GameOver();
        }
    }

    void YellowColorCheck(Collider t_collider)
    {
        if (t_collider.gameObject.tag == "YellowBall")
        {
            score++;
            TextChange(score);
            DestroyBall(t_collider);
        }

        else if (t_collider.gameObject.tag == "RedBall" || t_collider.gameObject.tag == "GrayBall")
        {
            GameOver();
        }
    }

    void GrayColorCheck(Collider t_collider)
    {
        if (t_collider.gameObject.tag == "GrayBall")
        {
            score++;
            TextChange(score);
            DestroyBall(t_collider);
        }

        else if (t_collider.gameObject.tag == "RedBall" || t_collider.gameObject.tag == "YellowBall")
        {
            GameOver();
        }
    }
}
