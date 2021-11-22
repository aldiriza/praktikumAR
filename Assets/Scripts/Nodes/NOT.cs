using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NOT : Node
{
    public override void OnCircuitChange()
    {
        base.OnCircuitChange();
        OutPoints[0].value = !InPoints[0].value;
        OutPoints[0].OnCircuitChanged();
    }
}
