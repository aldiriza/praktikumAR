using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineConroller : MonoBehaviour
{
    private LineRenderer lr;
    [SerializeField] private Transform[] points;

    public void SetUpLine(Transform[] points) {
        lr = GetComponent<LineRenderer>();
        lr.positionCount = points.Length;
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
