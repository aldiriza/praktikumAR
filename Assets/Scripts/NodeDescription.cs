using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using EasyUI.Popup;

public class NodeDescription : MonoBehaviour, IPointerClickHandler
{
    public string title;
    [TextArea(5,20)] public string longText;

    public void OnPointerClick(PointerEventData data)
    {
        Popup.Show(title, longText);
        //Debug.Log(gameObject.name + ": I was clicked!");
    }



}
