using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLock : MonoBehaviour
{
    public float sensitivity = 2.5f;
    public float drag = 1.5f;

    private Transform character;
    private Vector2 mouseDirection;
    private Vector2 smoothing;
    private Vector2 result;

    private void Awake()
    {
        character = transform.parent; //get refrence to parent's transform
    }
    // Update is called once per frame
    void Update()
    {
        mouseDirection = new Vector2(Input.GetAxisRaw("Mouse X") * sensitivity,
            Input.GetAxisRaw("Mouse Y") * sensitivity); //calculate mouse direction
        smoothing = Vector2.Lerp(smoothing, mouseDirection, 1 / drag); //calcualte smoothing
        result += smoothing;
        result.y = Mathf.Clamp(result.y, -80, 80); //clamps y angle
        transform.localRotation = Quaternion.AngleAxis(-result.y, Vector3.right); //apply x axis rotation
        character.rotation = Quaternion.AngleAxis(result.x, character.up); // apply y rotation to character
    }
}
