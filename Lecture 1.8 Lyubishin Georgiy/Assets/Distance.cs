using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{

    public Transform Static;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 0), ForceMode.Impulse);

    }
    private void Update()
    {
        Debug.Log(Static.position - transform.position);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawLine(Static.position, transform.position);
    }
}
