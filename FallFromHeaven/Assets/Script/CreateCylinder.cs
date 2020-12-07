using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateCylinder : MonoBehaviour
{

    public List<GameObject> cylinderList_L1;
    public List<GameObject> cylinderList_L2;
    public List<GameObject> cylinderList_L3;
    private bool isCreated= false;
    int listLength = 0;
    int randomIndex = 0;
    bool L1_triger = false;
    bool L2_triger = false;
    bool L3_triger = false;
    

    private void Awake()
    {
         
    }

    private void OnTriggerEnter(Collider other)//콜라이더를 트리거로 설정했기에 트리거로 받아줌
    {
       
        if(GameManager.score >= 0 && GameManager.score < 20)
        {
            L1_triger = true;
        }
        if (GameManager.score >= 20 && GameManager.score < 40)
        {
            L1_triger = false;
            L2_triger = true;
            
        }
        if (GameManager.score >= 40)
        {
            L2_triger = false;
            L3_triger = true;
        }

        if (other.gameObject.tag == "Player")
        {
            if(isCreated == false)
            {
                if (L1_triger)
                {
                    listLength = cylinderList_L1.Count;
                    randomIndex = UnityEngine.Random.Range(0, listLength);

                    Instantiate(cylinderList_L1[randomIndex], new Vector3(0, gameObject.transform.position.y - 40, 0), Quaternion.identity);

                }
                if (L2_triger)
                {
                    listLength = cylinderList_L2.Count;
                    randomIndex = UnityEngine.Random.Range(0, listLength);

                    Instantiate(cylinderList_L2[randomIndex], new Vector3(0, gameObject.transform.position.y - 40, 0), Quaternion.identity);

                }
                if (L3_triger)
                {
                    listLength = cylinderList_L3.Count;
                    randomIndex = UnityEngine.Random.Range(0, listLength);

                    Instantiate(cylinderList_L3[randomIndex], new Vector3(0, gameObject.transform.position.y - 40, 0), Quaternion.identity);

                }
                //Prefeb으로 저장된 실린더를 다다음의 실린더의 위치에 배치해줌
                isCreated = true;
                //만약 배치가 완료되었다면 다시 배치가 안되도록 트루값으로 트리거를 OFF해줌
                //랜덤으로 실린더를 가져오는 코드 작성예정
            }
            
        }
    }
}
