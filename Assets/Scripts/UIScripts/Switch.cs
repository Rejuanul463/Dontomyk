using System;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool value;

    [SerializeField] private GameObject on;
    [SerializeField] private GameObject off;
    
    /*this method will swap the button image to make a
     difference and show on and off condition to act like a switch*/
    public void swap()
    {
        on.SetActive(value);
        off.SetActive(!value);
        value = !value;
    }
}
