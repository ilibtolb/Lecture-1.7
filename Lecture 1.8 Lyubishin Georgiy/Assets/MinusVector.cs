using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusVector : MonoBehaviour
{

    public Vector3 V1;
    public Vector3 V2;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        DrawVector(transform.position, V1);
        Gizmos.color = Color.green;
        DrawVector(transform.position, V2);
        Gizmos.color = Color.blue;
        DrawVector(transform.position + V2, V1 - V2);
    }
    private void DrawVector(Vector3 start, Vector3 end)
    {
        Gizmos.DrawRay(start, end);
        Gizmos.DrawSphere(start + end, 0.2f);
    }
}
