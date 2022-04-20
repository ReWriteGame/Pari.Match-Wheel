using UnityEngine;

public class RotationCompensationChild : MonoBehaviour
{
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - transform.parent.position;
    }

    void FixedUpdate()
    {
        transform.position = transform.parent.position + offset;
    }
}
