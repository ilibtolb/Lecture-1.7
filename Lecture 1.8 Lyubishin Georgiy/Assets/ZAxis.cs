using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAxis : MonoBehaviour
{
    public float Rotation;
    private void Update()
    {
        Vector3 Rot = new Vector3(0, 0, Rotation);
        Quaternion delta = Quaternion.Euler(Rot * Time.deltaTime);
        transform.rotation *= delta;
    }
}
