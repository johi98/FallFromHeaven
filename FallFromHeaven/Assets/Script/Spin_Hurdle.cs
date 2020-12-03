using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin_Hurdle : MonoBehaviour
{
    float rotate_speed = 50;
    // Update is called once per frame\
    float random_Rotate;

    private void Awake()
    {
        random_Rotate = Random.Range(1, 3);
        if (random_Rotate == 2)
        {
            random_Rotate = -1;
        }
    }
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, rotate_speed * random_Rotate, 0) * Time.deltaTime);
    }


}
