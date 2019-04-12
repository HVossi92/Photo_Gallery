using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesciptionOverlayBehaviour : EventDrivenObject
{
    private GameObject overlay;
    // Start is called before the first frame update
    void Awake()
    {
        overlay = transform.Find("DescriptionOverlay").gameObject;
        overlay.SetActive(false);
        UpdateRegisterEvent("onDescTapped", OpenOverlay);
    }

    public void CloseOverlay()
    {
        overlay.SetActive(false);
    }

    // Update is called once per frame
    void OpenOverlay (CustomEventData eventData)
    {
        overlay.SetActive(true);
    }
}
