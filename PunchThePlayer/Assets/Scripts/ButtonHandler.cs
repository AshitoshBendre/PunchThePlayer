using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    //Cache
    TapController tapcontroller;

    void Start()
    {
        tapcontroller = GetComponent<TapController>();
    }

    void Update()
    {
        
    }

    public void OnButtonPressed(int id)
    {
        tapcontroller.AddScore(id);
        Debug.Log("Button Pressed AddScore Called");
    }
}
