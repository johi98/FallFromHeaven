using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coin;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            GameObject score = GameObject.Find("Score"); //스코어 스크립트를 불러온다
            CoinScore ps = score.GetComponent<CoinScore>();
            ps.score++; // 스코어를 1씩 증가시킨다
            ps.textScore.text = "Coins:" + ps.score.ToString(); //textscore에 score 넣어주고 , tostring 문자화한다
            Destroy(coin);
        }
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);
    }

}
