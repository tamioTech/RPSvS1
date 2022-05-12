using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IPointerDownHandler ,IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("I got clicked");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("begin drag");

    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("dragging");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("stop dragging");
    }

}
