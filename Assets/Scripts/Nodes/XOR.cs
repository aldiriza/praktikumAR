using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XOR : Node
{
    public override void OnCircuitChange()
    {
        base.OnCircuitChange();
        OutPoints[0].value = InPoints[0].value != InPoints[1].value;
        OutPoints[0].OnCircuitChanged();
    }
}
