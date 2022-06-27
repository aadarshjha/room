using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInteractable : Interactable
{
    public override void OnInteract()
    {
        Debug.Log("Interact " + gameObject.name);
    }
    public override void OnFocus()
    {
        Debug.Log("Focus " + gameObject.name);
    }
    public override void OnLoseFocus()
    {
        Debug.Log("Lose Focus " + gameObject.name);
    }
}
