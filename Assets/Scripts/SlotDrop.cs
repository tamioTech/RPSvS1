using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotDrop : MonoBehaviour, IDropHandler
{


    private void Awake()
    {

    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("card dropped");

        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<Transform>().position = this.transform.position;
            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = objTr.position;
            //print(eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("trigger finger");
    }


    public void GloveButton()
    {
        print("gloves up");
    }

    public void NewsPaperButton()
    {
        print("extra extra read all about it");
    }

    public void SwordButton()
    {
        print("It cuts like a knife");
    }


}
