using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveWithMouse : MonoBehaviour,IPointerEnterHandler , IPointerClickHandler
{
    //[SerializeField] GameObject rawImage;
    //void Update()
    //{
    //    //Vector3 mousePos = Input.mousePosition;
    //    //Vector3 ImagePos = rawImage.transform.position;
    //    //    if (Input.GetMouseButton(0))
    //    //    {
    //    //        rawImage.transform.position = mousePos;
    //    //    }
    //}
    //public void OnPointerDown()
    //{
    //    Debug.Log(gameObject.name);
    //    Debug.Log("Hoveroing");
    //    //Vector3 mousePos = Input.mousePosition;
    //    //if (Input.GetMouseButton(0))
    //    //    rawImage.transform.position = mousePos;
    //}
    private bool mouse_over = false;
    void Update()
    {
        if (mouse_over)
        {
            Debug.Log("Mouse Over");
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked On Image");
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        mouse_over = true;
        Debug.Log("Mouse enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouse_over = false;
        Debug.Log("Mouse exit");
    }
}
