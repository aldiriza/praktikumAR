using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScript : MonoBehaviour
{
    public GameObject activeObject;
    public Camera kamera;
    public float cameraDistance = 5;
    bool lockActive;
    //Vector3 objectPosition;
    //Quaternion objectRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /* Update is called once per frame
    void Update()
    {
        
        if (lockActive && activeObject.activeInHierarchy) 
        {
            var rotation = Quaternion.LookRotation(-Camera.main.transform.forward, -Camera.main.transform.up);
            rotation *= Quaternion.Euler(90, 0, 0);
            activeObject.transform.rotation = rotation;
            //activeObject.transform.SetPositionAndRotation(new Vector3(kamera.transform.position.x, kamera.transform.position.y, cameraDistance), Quaternion.LookRotation(-Camera.main.transform.forward, Camera.main.transform.up));
        }
        
    }
    */

    public void LockingObject() 
    {
        if(activeObject.activeInHierarchy)
            lockActive = !lockActive; //atur kondisi kunci

        if (lockActive && activeObject.activeInHierarchy)
        {
            activeObject.transform.parent = kamera.transform;
        }

        else {
            activeObject.transform.parent = null;
        }
        /*
        objectPosition = activeObject.GetComponent<Transform>().position; //ambil posisi objek
        //objectRotation = activeObject.GetComponent<Quaternion>(); // ambil posisi rotasi objek
        cameraDistance = Vector3.Distance(kamera.transform.position, objectPosition); //ambil jarak antara objek dengan kamera
        */


    }

}
