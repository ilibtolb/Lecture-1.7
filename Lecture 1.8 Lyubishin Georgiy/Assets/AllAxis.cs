using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllAxis : MonoBehaviour
{
    public Vector3 Rot;
    private void Update()
    {
        Quaternion delta = Quaternion.Euler(Rot * Time.deltaTime);
        transform.rotation *= delta;
    }
}
