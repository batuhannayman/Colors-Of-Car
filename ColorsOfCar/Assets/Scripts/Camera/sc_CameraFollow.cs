using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_CameraFollow : MonoBehaviour
{
    
    [SerializeField] Transform target; //Car's position
    [SerializeField] Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 2.2f, -1.8f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, target.position.y, target.position.z) + offset;
    }
}
