using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_CarColorController : MonoBehaviour
{
    [SerializeField] GameObject car_Red, car_Yellow, car_Gray;
    public static string car_Color;

    void Start() 
    {
        car_Color = "red";
    }

    private void OnTriggerEnter(Collider collider) 
    {
        ChangeColor(collider);
    }

    void ChangeColor(Collider t_collider)
    {
        if (t_collider.gameObject.tag == "ColorChanger_Yellow")
        {
            sc_SFXController.instance.PlayColorSFX();
            car_Color = "yellow";
            car_Red.SetActive(false);
            car_Gray.SetActive(false);
            car_Yellow.SetActive(true);
        }
        else if (t_collider.gameObject.tag == "ColorChanger_Red")
        {
            sc_SFXController.instance.PlayColorSFX();
            car_Color = "red";
            car_Yellow.SetActive(false);
            car_Gray.SetActive(false);
            car_Red.SetActive(true);
        }
        else if (t_collider.gameObject.tag == "ColorChanger_Gray")
        {
            sc_SFXController.instance.PlayColorSFX();
            car_Color = "gray";
            car_Red.SetActive(false);
            car_Yellow.SetActive(false);
            car_Gray.SetActive(true);
        }
    }
}
