using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_CarController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] Vector3 movement;
    public static float move_Speed;
    [SerializeField] GameObject frontright_Wheel, frontleft_Wheel;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        move_Speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
    }

    void FixedUpdate() 
    {
        PlayerMove();
        WheelsAnimation();
    }

    void GetPlayerInput()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        //Mobile touch control
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            movement.x = Input.GetTouch(0).deltaPosition.x * 0.02f;
        }

        //Keep going forward
        movement.z = 2;
    }

    void PlayerMove()
    {
        rb.velocity = movement.normalized * move_Speed;
    }

    void WheelsAnimation()
    {
        if (movement.x == 0)
        {
            frontright_Wheel.transform.rotation = Quaternion.Euler(0, 0, 0);
            frontleft_Wheel.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (movement.x > 0)
        {
            frontright_Wheel.transform.rotation = Quaternion.Euler(0, 15, 0);
            frontleft_Wheel.transform.rotation = Quaternion.Euler(0, 15, 0);
        }
        else if (movement.x < 0)
        {
            frontright_Wheel.transform.rotation = Quaternion.Euler(0, -15, 0);
            frontleft_Wheel.transform.rotation = Quaternion.Euler(0, -15, 0);
        }
    }

}
