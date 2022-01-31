 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float sensitivity = 2.5f; // mouse input sensitivity
    public float drag = 1.5f; // continued mouse movement after input stops

    private Transform character; //this refrences chartacter transform
    private Vector2 mouseDirection; //this stores mouse coordinates
    private Vector2 smoothing; //smoothed cursor movement value
    private Vector2 result; //resulting cursor position

    private void Awake()
    {
        character = transform.parent; //Get refrence to parent's transform
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
