using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    private Rigidbody rigi;
    public float distToGround = 2;
    public float jumpPower = 2;


    // Start is called before the first frame update
    void Start()
    {
      rigi =   gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Plateform")
        {
            rigi.AddForce(Vector3.up * jumpPower * Time.deltaTime, ForceMode.Impulse);
        }
       
    }
}
