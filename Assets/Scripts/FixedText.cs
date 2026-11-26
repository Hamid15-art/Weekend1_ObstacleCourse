using UnityEngine;

public class FixedText : MonoBehaviour
{
    private Vector3 fixedPosition;
    private Quaternion fixedRotation;

    void Start()
    {
        fixedPosition = transform.position;
        fixedRotation = transform.rotation;
    }

    void Update()
    {
        transform.position = fixedPosition;
        transform.rotation = fixedRotation;
    }
}
