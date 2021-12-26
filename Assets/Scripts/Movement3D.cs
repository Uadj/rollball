using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3D : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    private Rigidbody rigidbody3D;

    private void Awake()
    {
        rigidbody3D = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    public void MoveTo(Vector3 direction)
    {
        Vector3 moveForce = Vector3.zero;
        direction.y = 0;
        moveForce = direction.normalized * moveSpeed;
        rigidbody3D.AddForce(moveForce);
    }
}
