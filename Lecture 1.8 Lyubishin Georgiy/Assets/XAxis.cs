using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XAxis : MonoBehaviour
{
    public float Rotation;
    private void Update()
    {
        Vector3 Rot = new Vector3(Rotation, 0, 0);
        Quaternion delta = Quaternion.Euler(Rot * Time.deltaTime);
        transform.rotation *= delta;
    }
}
