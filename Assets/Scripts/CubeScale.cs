using UnityEngine;

public class CubeScale : MonoBehaviour
{ 
    [SerializeField] private Vector3 value;
    private float scalespeed = 1f;
    private int maxScale = 20;
    private bool isscale = true;

    void Start()
    {

    }

    void Update()
    {
      

        Vector3 step = value * scalespeed * Time.deltaTime;

        for (int i = 0; i < maxScale; i++)
        {
            if (isscale)
            {
                gameObject.transform.localScale += step;

                if (gameObject.transform.localScale.x >= 20f)
                {
                    isscale = false;
                }
            }
            else
            {
                gameObject.transform.localScale -= step;

                if (gameObject.transform.localScale.x <= 1f)
                {
                    isscale = true;
                }
            }
        }
    }
}

