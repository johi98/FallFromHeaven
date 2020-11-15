using System.Collections.Generic;
using UnityEngine;

public class Spin_UpDown_hurdle : MonoBehaviour
{
    float rotate_speed = 50;
    Vector3 savePositionY;
    bool upDownCheck = true;
    float random_Rotate;
    // Update is called once per frame

    private void Start()
    {
        upDownCheck = true;
        SavePositionY();
        
    }

    private void Awake()
    {
        random_Rotate = Random.Range(1, 3);
        if(random_Rotate == 2)
        {
            random_Rotate = -1;
        }
    }
    void Update()
    {
        isEnd();
        gameObject.transform.Rotate(new Vector3(0, rotate_speed*random_Rotate, 0) * Time.deltaTime);
        if (upDownCheck)
        {
            gameObject.transform.Translate(new Vector3(0, 5, 0) * Time.deltaTime);
        

        }
        
        if(upDownCheck==false)
        {
            gameObject.transform.Translate(new Vector3(0, -5, 0) * Time.deltaTime);
            
        }
       
    }
    private void SavePositionY()
    {
        savePositionY = gameObject.transform.position;
    }

    private void isEnd()
    {
        if(gameObject.transform.position.y >= savePositionY.y +5)
        {
            SavePositionY();
            upDownCheck = false;//내려감
        }
        if (gameObject.transform.position.y <= savePositionY.y - 5)
        {
            SavePositionY();
            upDownCheck = true;//올라감
        }
       


    }

}

