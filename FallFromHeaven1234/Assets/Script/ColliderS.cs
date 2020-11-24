using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderS : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            GameObject scoreC = GameObject.Find("TriggerScore"); //스코어 스크립트를 불러온다
            TriggerScore ps = scoreC.GetComponent<TriggerScore>();
            ps.scoreC++; // 스코어를 1씩 증가시킨다
            ps.textScore.text = "Score:" + ps.scoreC.ToString();

            // Start is called before the first frame update
            void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {

            }
        }
    }
}
