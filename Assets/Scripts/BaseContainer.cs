using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseContainer : MonoBehaviour
{
    public virtual void Interact(Player player)
    {
        Debug.Log("BaseContainer.Interact();");
    }
}
