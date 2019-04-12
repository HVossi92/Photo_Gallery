using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ImageTargetCanvasBehaviour : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        GameObject obj = pointerEventData.pointerCurrentRaycast.gameObject;
        
        if(obj != null)
        {
            string eventName = "on" + obj.tag + "Tapped";
            CustomEventData eventData = new CustomEventData(eventName, obj);
            EventManager.TriggerEvent(eventData);
        }
    }
}
