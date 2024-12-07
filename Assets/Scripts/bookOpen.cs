using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class bookOpen : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked: " + eventData.pointerCurrentRaycast.gameObject.name);
        if (eventData.pointerCurrentRaycast.gameObject.name == "Book")
        {
            Debug.Log("Book Clicked");
            GameObject book = eventData.pointerCurrentRaycast.gameObject;
            book.transform.Rotate(0, 0, 90);
        }
    }

    public void openBook()
    {
        Debug.Log("Book Opened");
    }
}
