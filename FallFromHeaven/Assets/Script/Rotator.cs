using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
     float RotatorSpeed = 10;

    private void FixedUpdate()
    {
        if(Input.touchCount>0 &&Input.GetTouch(0).phase == TouchPhase.Moved)
        {//화면의 닿은 손가락이 0개 초과이고 터치후 움직이고 있을 경우 
            Vector3 Rotation = Input.GetTouch(0).deltaPosition;
            //터치 지점에서 이동한 만큼 값을 Vector3 값으로 받아옴
            transform.Rotate(0, -(Rotation.x * RotatorSpeed * Time.deltaTime), 0);
            //사용자가 움직인 화면의  백터 x값을 받아 현재 y값의 기울기를 더하거나 빼서 Rotate로 돌려주는 코드
        }

      /*  if (Input.GetMouseButton(0))
        {//화면의 닿은 손가락이 0개 초과이고 터치후 움직이고 있을 경우 
            Vector3 Rotation = new Vector3(0, Input.mousePosition.x, 0);
            //터치 지점에서 이동한 만큼 값을 Vector3 값으로 받아옴
            transform.Rotate(Rotation * Time.deltaTime);
            //사용자가 움직인 화면의  백터 x값을 받아 현재 y값의 기울기를 더하거나 빼서 Rotate로 돌려주는 코드
        }*/
    }
}
