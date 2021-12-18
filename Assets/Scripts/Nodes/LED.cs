using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LED : Node
{
    protected Color deactivated = Color.white;
    protected Color activated = Color.blue;
    public bool value;

    private Material mat;


    private void Start()
    {
        
        mat = GetComponent<Renderer>().materials[0];
        Color color = value ? activated : deactivated;
        mat.color = color;
    }

    public override void OnCircuitChange()
    {
        base.OnCircuitChange();
        Color color = InPoints[0].value ? activated : deactivated;
        mat.color = color;
    }
}
