using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineConroller : MonoBehaviour
{
    
    private LineRenderer lr;
    [SerializeField] private Transform[] points;

 

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    public void SetUpLine(Transform[] points) {
        
        lr.positionCount = points.Length;
        lr.startWidth = .005f;
        lr.endWidth = .005f;
        this.points = points;
        

    }

    private void Update()
    {
        for(int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }

    }

    
}
