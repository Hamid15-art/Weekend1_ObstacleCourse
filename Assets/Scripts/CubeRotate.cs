using UnityEngine;

public class CubeRoatae : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float move = 90f;
    public float Rotatespeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = move * Rotatespeed;
        transform.Rotate(0f, angle, 0f);
    }
}
