using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodePoint : MonoBehaviour
{
    public bool value;
    protected Color deactivated = Color.black;
    protected Color activated = Color.blue;

    [HideInInspector]
    public Node node;

    private Material mat;



    private void Start()
    {
        mat = GetComponent<Renderer>().material;
        OnCircuitChanged(); //akan error tapi gapapa
    }

    public virtual void OnCircuitChanged()
    {
        Color color = value ? activated : deactivated;
        mat.color = color;
    }

}
