using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class RemoveCylinder : MonoBehaviour
{
    public GameObject cylinder;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("cccc");
            Destroy(cylinder);
        }
    }

   
}
