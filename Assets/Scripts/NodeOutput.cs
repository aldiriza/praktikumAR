using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeOutput : NodePoint
{
    public List<NodeInput> Outs = new List<NodeInput>();
    public int id;
    // Start is called before the first frame update
    public override void OnCircuitChanged()
    {
        base.OnCircuitChanged();

        foreach (var Out in Outs)
        {
            if (Out.value == value)
                continue;
            Out.value = value;

            Out.OnCircuitChanged();
        }
    }
}
