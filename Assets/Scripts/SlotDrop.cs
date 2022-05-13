using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotDrop : MonoBehaviour, IDropHandler
{
    [SerializeField] private Transform objTr;
    [SerializeField] private Canvas canvas;

    private void Awake()
    {
        objTr = GetComponent<Transform>();
        canvas = GetComponent<Canvas>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("card dropped");

        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<Transform>().position = this.transform.position;
            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = objTr.position;
            print(eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition);
        }
    } 
}
