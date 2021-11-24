using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YAxis : MonoBehaviour
{
    public float Rotation;
    private void Update()
    {
        Vector3 Rot = new Vector3(0, Rotation, 0);
        Quaternion delta = Quaternion.Euler(Rot * Time.deltaTime);
        transform.rotation *= delta;
    }
}
