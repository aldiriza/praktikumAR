using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    

    public NodeInput[] InPoints { get; private set; }

    public NodeOutput[] OutPoints { get; private set; }

    public int instanceId;

    private void Awake()
    {
        InPoints = GetComponentsInChildren<NodeInput>();
        OutPoints = GetComponentsInChildren<NodeOutput>();
        for (var i = 0; i < OutPoints.Length; i++)
        {
            OutPoints[i].id = i;
        }
    }

    private void Start()
    {
        OnCircuitChange(); //akan error tapi gamasalah
    }

    public virtual void OnCircuitChange()
    {
        if (OutPoints == null)
            return;

        foreach (NodeOutput Out in OutPoints)
        {
            Out.OnCircuitChanged();
        }
    }
}
