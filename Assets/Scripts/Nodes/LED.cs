using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LED : Node
{
    protected Color deactivated = Color.black;
    protected Color activated = Color.red;

    private Material mat;


    private void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    public override void OnCircuitChange()
    {
        base.OnCircuitChange();
        mat.color = InPoints[0].value ? activated : deactivated;
    }
}
