using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : Node
{
    private void OnMouseDown()
    {
        OutPoints[0].value = !OutPoints[0].value;
        OutPoints[0].OnCircuitChanged();
    }
}