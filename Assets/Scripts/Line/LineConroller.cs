using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineConroller : MonoBehaviour
{
    
    private LineRenderer lr;
    [SerializeField] private Transform[] points;

    protected Color deactivated = Color.white;
    protected Color activated = Color.blue;


    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    public void SetUpLine(Transform[] points) {
        
        lr.positionCount = points.Length;
        lr.startWidth = .002f;
        lr.endWidth = .002f;
        this.points = points;
        

    }

    private void Update()
    {
        for(int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }

    }

    public virtual void ChangeLineColor(bool value)
    {
        Color color = value ? activated : deactivated;
        //lr.SetColors(color, color);
        lr.startColor = color;
        lr.endColor = color;
    }


}
