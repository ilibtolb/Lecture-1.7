using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationVector : MonoBehaviour
{

    public Vector3 V1;
    public float numb;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        DrawVector(transform.position, V1);
        Gizmos.color = Color.green;
        DrawVector(transform.position, V1 * numb);
    }
    private void DrawVector(Vector3 start, Vector3 end)
    {
        Gizmos.DrawRay(start, end);
        Gizmos.DrawSphere(start + end, 0.2f);
    }
}
