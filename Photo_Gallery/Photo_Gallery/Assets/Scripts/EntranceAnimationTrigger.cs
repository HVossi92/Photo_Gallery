using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EntranceAnimationTrigger : MonoBehaviour
{

    public string animationName;

    Animator anim;

    private UnityAction<CustomEventData> onImageTargetDetected;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
        onImageTargetDetected = new UnityAction<CustomEventData> (PlayEntranceAnimation);
    }

    void OnEnable()
    {
        EventManager.StartListening("onImageTargetDetected", onImageTargetDetected);
    }

    void OnDisable()
    {
        EventManager.StopListening("onImageTargetDetected", onImageTargetDetected);
    }

    public void PlayEntranceAnimation(CustomEventData eventData)
    {
        if (animationName != null)
        {
            anim.Play(animationName);
        }
    }
}
