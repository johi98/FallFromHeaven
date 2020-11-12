using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin_Hurdle : MonoBehaviour
{
    float rotate_speed = 50;
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, rotate_speed , 0)*Time.deltaTime);
    }

    
}
