using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotatorSpeed;

    private void FixedUpdate()
    {
        if(Input.touchCount>0 &&Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector3 Rotation = Input.GetTouch(0).deltaPosition;
            transform.Rotate(0, Rotation.x * RotatorSpeed * Time.deltaTime, 0);
        }
    }
}
