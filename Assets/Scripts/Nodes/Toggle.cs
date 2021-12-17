using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : Node
{
    protected Color deactivated;
    protected Color activated = Color.blue;
    private Material mat;


    private void Start()
    {
        mat = GetComponent<Renderer>().material;
        deactivated = mat.color;
    }

    private void OnMouseDown()
    {
        OutPoints[0].value = !OutPoints[0].value;
        OutPoints[0].OnCircuitChanged();

        mat.color = OutPoints[0].value ? activated : deactivated;
        
    }
}