using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerJumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private RectTransform rect_JupmButton = null;
    [SerializeField] private GameObject go_player = null;
    [SerializeField] private float jumpPower = 10f;
    [SerializeField] private float distToGround = 1f;
    // Start is called before the first frame update

    private Rigidbody rigid;
    void Start()
    {
        rigid = go_player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (Physics.Raycast(go_player.transform.position, Vector3.down, distToGround))
        {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }


}
