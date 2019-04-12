using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ImageTargetBehaviour : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mtrackableBehaviour;
    // Start is called before the first frame update
    void Start()
    {
        mtrackableBehaviour = GetComponent<TrackableBehaviour>();

        if (mtrackableBehaviour)
        {
            mtrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        CustomEventData eventData = new CustomEventData();
        eventData.obj = transform.gameObject;
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            eventData.eventName = "onImageTargetDetected";
            EventManager.TriggerEvent(eventData);
        }
        else
        {
            eventData.eventName = "onImageTargetDetected";
            EventManager.TriggerEvent(eventData);
        }
    }
}
