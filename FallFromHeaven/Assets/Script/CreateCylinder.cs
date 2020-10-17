using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCylinder : MonoBehaviour
{
    public GameObject cylinder;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(cylinder, new Vector3(0,cylinder.transform.position.y-40,0), Quaternion.identity);
        }
    }
}
