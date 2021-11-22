using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeInput : NodePoint
{
    [SerializeField] private Line kabel;
    public NodeOutput Input;


    private void Awake()
    {
        var kbl = Instantiate(kabel, new Vector3(0, 0, 0), Quaternion.identity);
        kbl.transform.parent = gameObject.transform;
              
    }

   

    public override void OnCircuitChanged()
    {


        if (Input == null)
            value = false;

        base.OnCircuitChanged();

        GetComponentInParent<Node>().OnCircuitChange();
        
        

    }
}
