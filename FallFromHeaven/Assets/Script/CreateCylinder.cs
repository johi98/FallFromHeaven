using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCylinder : MonoBehaviour
{
    public GameObject cylinder;
    private bool isCreated= false;
    private void OnTriggerEnter(Collider other)//콜라이더를 트리거로 설정했기에 트리거로 받아줌
    {
        if (other.gameObject.tag == "Player")
        {
            if(isCreated == false)
            {
                Instantiate(cylinder, new Vector3(0, cylinder.transform.position.y - 40, 0), Quaternion.identity);
                //Prefeb으로 저장된 실린더를 다다음의 실린더의 위치에 배치해줌
                isCreated = true;
                //만약 배치가 완료되었다면 다시 배치가 안되도록 트루값으로 트리거를 OFF해줌
                //랜덤으로 실린더를 가져오는 코드 작성예정
            }
            
        }
    }
}
