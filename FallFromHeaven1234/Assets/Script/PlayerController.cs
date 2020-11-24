using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour ,IPointerDownHandler, IPointerUpHandler , IDragHandler
{
    // Start is called before the first frame update
    [SerializeField] private RectTransform rect_Background= null;
    [SerializeField] private RectTransform rect_Joystick = null;

    private float radius;
    [SerializeField] private GameObject go_player= null;
    [SerializeField] private float moveSpeed = 0;

    private bool isTouch = false;
    private Vector3 movePosition;

    void Start()
    {
        radius = rect_Background.rect.width * 0.5f;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isTouch)
        {
            go_player.transform.position += movePosition;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {


        Vector2 value = eventData.position - (Vector2)rect_Background.position;

        value = Vector2.ClampMagnitude(value, radius);

        rect_Joystick.localPosition = value;


        float distance = Vector2.Distance(rect_Background.position, rect_Joystick.position) / radius;

        value = value.normalized;

        movePosition = new Vector3(value.x * moveSpeed*distance * Time.deltaTime, 0f, value.y * moveSpeed * Time.deltaTime);

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isTouch = true;
      
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isTouch = false;
        rect_Joystick.localPosition = Vector3.zero;
        movePosition = Vector3.zero;
    }

}
