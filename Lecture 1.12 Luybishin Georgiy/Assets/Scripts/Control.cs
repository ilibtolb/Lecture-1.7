using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private Vector3 _previous;
    public float Sensitivity;
    public Transform Level;

    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previous;
            Level.Rotate(0, -delta.x * Sensitivity, 0);
        }


        _previous = Input.mousePosition;
    }
}
