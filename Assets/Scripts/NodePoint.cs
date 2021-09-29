using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodePoint : MonoBehaviour
{
    public bool value;
    protected Color deactivated = Color.black;
    protected Color activated = Color.red;

    [HideInInspector]
    public Node node;

    private Material mat;

    private void Awake()
    {
        mat = GetComponent<Renderer>().material;
    }

    public virtual void OnCircuitChanged()
    {
        mat.color = value ? activated : deactivated;
    }

}
