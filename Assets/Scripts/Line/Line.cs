using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private LineConroller line;

     

    private void Start()
    {
        points[0] = GetComponentInParent<NodeInput>().transform;
        points[1] = GetComponentInParent<NodeInput>().Input.gameObject.transform;
        line = GetComponentInChildren<LineConroller>();
        CreateLine();
    }

    public void CreateLine()
    {
        line.SetUpLine(points);
    }

   

     
}
