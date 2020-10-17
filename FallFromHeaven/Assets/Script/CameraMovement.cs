using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform Player;

    public Vector3 Offset;

    private Vector3 Velocity;
    public float smoothDamp;

    public float PositionOffset;

    private void Start()
    {
        Vector3 TargetPosition = Player.position + Offset;
        transform.position = TargetPosition;
    }

    private void FixedUpdate()
    {
        Vector3 TargetPosition = Player.position + Offset;

        if(Player.position.y< transform.position.y + PositionOffset)
        {
            transform.position = TargetPosition = Vector3.SmoothDamp(transform.position, TargetPosition, ref Velocity, smoothDamp);
        }
        

    }
}
