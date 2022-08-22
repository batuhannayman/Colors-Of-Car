using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_BorderFollow : MonoBehaviour
{
    [SerializeField] Transform target; //Car's position

    void Update()
    {
        transform.position = new Vector3(0, target.position.y, target.position.z);
    }
}
