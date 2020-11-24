using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle_Down : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector3(0, -5, 0) * Time.deltaTime);
    }
}
