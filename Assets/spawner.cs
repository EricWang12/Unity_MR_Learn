using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;

public class spawner : MonoBehaviour
{
    public GameObject targetObject;
    public Vector3 targetPos;
    public GameObject CameraObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createObject()
    {
        var camera = CameraObject.GetComponent<CameraManager>();
        if (camera.Phtotaken)
        {
            NearInteractionGrabbable grabbable = targetObject.AddComponent<NearInteractionGrabbable>();
            ManipulationHandler manipulationHandler = targetObject.AddComponent<ManipulationHandler>();
            Instantiate(targetObject, targetPos, new Quaternion(0, 0, 0, 0));
        }
    }
}
