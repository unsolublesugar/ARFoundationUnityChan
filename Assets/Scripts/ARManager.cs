using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class ARManager : MonoBehaviour {

    [SerializeField] GameObject objectPrefab;
    private ARRaycastManager raycastManager;
    private List<ARRaycastHit> raycastHitList = new List<ARRaycastHit> ();
    void Start () {
        raycastManager = GetComponent<ARRaycastManager> ();
    }

    void Update () {

        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch (0);
            if (touch.phase != TouchPhase.Ended) {
                return;
            }
            if (raycastManager.Raycast (touch.position, raycastHitList, TrackableType.All)) {
                Instantiate (objectPrefab, raycastHitList[0].pose.position, raycastHitList[0].pose.rotation);

            }
        }
    }
}