using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScript : MonoBehaviour
{
    public GameObject activeObject;
    public Camera kamera;
    bool lockActive;
    Vector3 objectPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lockActive && activeObject.activeInHierarchy) 
        {
            activeObject.transform.SetPositionAndRotation(new Vector3(objectPosition.x, objectPosition.y, Vector3.Distance(kamera.transform.position, objectPosition)), Quaternion.identity);
        }
    }

    public void LockingObject() 
    {
        lockActive = !lockActive;
        objectPosition = activeObject.GetComponent<Transform>().position;
    }

}
