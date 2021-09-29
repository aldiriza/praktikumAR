using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeInput : NodePoint
{

    public NodeOutput Input;
    // Start is called before the first frame update
    public override void OnCircuitChanged()
    {


        if (Input == null)
            value = false;

        base.OnCircuitChanged();

        GetComponentInParent<Node>().OnCircuitChange();

    }
}
