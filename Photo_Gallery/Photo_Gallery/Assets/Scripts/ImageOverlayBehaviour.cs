using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class ImageOverlayBehaviour : MonoBehaviour
{
    private GameObject overlay;
    private Image image;
    private UnityAction<CustomEventData> onPhotoTapped;

    // Start is called before the first frame update
    void Awake()
    {
        overlay = transform.Find("ImageOverlay").gameObject;
        image = overlay.transform.Find("ImageContainer").gameObject.GetComponent<Image>();
        overlay.SetActive(false);
        onPhotoTapped = new UnityAction<CustomEventData> (DisplayImageOverlay);
    }

    private void OnEnable()
    {
        EventManager.StartListening("onPhotoTapped", onPhotoTapped);
    }

    private void OnDisable()
    {
        EventManager.StopListening("onPhotoTapped", onPhotoTapped);
    }

    public void CloseOverlay()
    {
        overlay.SetActive(false);
    }

    void OpenOverlay()
    {
        overlay.SetActive(true);
    }

    void SetImage(Sprite imageSprite)
    {
        image.sprite = imageSprite;
    }

    void DisplayImageOverlay(CustomEventData eventData)
    {
        GameObject tappedObject = eventData.obj;
        Image tappedImageComponent = tappedObject.GetComponent<Image>();
        Sprite ImageSprite = tappedImageComponent.sprite;
        SetImage(ImageSprite);
        OpenOverlay();
    }
}
