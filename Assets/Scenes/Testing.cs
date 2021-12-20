using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public GameObject activeObject;
    public Camera kamera;
    public float cameraDistance;
    bool lockActive;
    Vector3 objectPosition;
    Vector3 relativePosition;
    //Quaternion objectRotation;
    // Start is called before the first frame update
    void Start()
    {
        lockActive = !lockActive; //atur kondisi kunci
        objectPosition = activeObject.GetComponent<Transform>().position;
        activeObject.transform.parent = kamera.transform;

        ///ambil posisi objek
        //objectRotation = activeObject.GetComponent<Quaternion>(); // ambil posisi rotasi objek
        //cameraDistance = Vector3.Distance(kamera.transform.position, objectPosition); //ambil jarak antara objek dengan kamera
    }

    // Update is called once per frame
    void Update()
    {
        if (lockActive && activeObject.activeInHierarchy)
        {
            // relativePosition = kamera.transform.InverseTransformDirection(activeObject.transform.position - kamera.transform.position);
            //var rotation = Quaternion.LookRotation(-Camera.main.transform.forward, -Camera.main.transform.up);
            //rotation *= Quaternion.Euler(90, 0, 0);
            //activeObject.transform.SetPositionAndRotation(new Vector3(kamera.transform.position.x, kamera.transform.position.y-cameraDistance, kamera.transform.position.z), rotation);
            //activeObject.transform.rotation = rotation;
        }
    }

    public void LockingObject()
    {

    }
}
