using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{

    private Rigidbody rigi;
    public float distToGround = 2;
    public float jumpPower = 2;
    private bool oneJump = false;
    public GameObject EndPannel;
    AdsManager adsManager;

    // Start is called before the first frame update
    void Start()
    {
      rigi =   gameObject.GetComponent<Rigidbody>();//플레이어의 RIGIDBODY를 받아옴
      adsManager = new AdsManager();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(gameObject.transform.position, Vector3.down, distToGround)==false)
        {//스크립트가 들어간 오브젝트의 아래방향으로 distToGround 값 만큼 레이를 발사래 오브젝트가 있으면 true 값을 주는 코드

            oneJump = false;
            
        }
        
    }
   
    private void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.tag == "Plateform"&&oneJump == false)
        {   //플레이어가 닿은 오브젝트의 tag가 Plateform이고 점프를 하지 않았다면 
            rigi.AddForce(Vector3.up * jumpPower * Time.deltaTime, ForceMode.Impulse);
            //플레이어에게 수직으로 힘을 주며 deltaTime을 통해 플레이어가 받는 힘을 정규화 시켜줌
            oneJump = true ;
            //플레이어가 바닥에 있을때만 점프
        }
        //장애물과 닿으면 플레이어 삭제처리와 판넬불러오기
    
        if (collision.gameObject.tag == "Enemy")
        {
            // Destroy(gameObject);
            adsManager.ShowInterstitialAd();
            gameObject.SetActive(false);
            EndPannel.SetActive(true);
            
      
        }

        
    }
  

  
}
