using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotDrop : MonoBehaviour, IDropHandler
{
    GameHandler gameHandler;

    private void Awake()
    {
        gameHandler = FindObjectOfType<GameHandler>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("card dropped");

        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<Transform>().position = this.transform.position;
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("trigger finger");
        //print(collision.name);
        if(gameObject.tag == "P1a")
        {
            gameHandler.P1AChoice(collision.tag);
        }
        else if (gameObject.tag == "P1b")
        {
            gameHandler.P1BChoice(collision.tag);
        }
        else if (gameObject.tag == "P1c")
        {
            gameHandler.P1CChoice(collision.tag);
        }
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
