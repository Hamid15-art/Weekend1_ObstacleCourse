using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float move = 90f;
    [SerializeField] private Vector3 value;
    private float scalespeed = 1f;
    private int maxScale = 5;
    private bool isscale = true;

    void Start()
    {

    }

    void Update()
    {
        float angle = move * Time.deltaTime;
        transform.Rotate(0f, angle, 0f);

        Vector3 step = value * scalespeed * Time.deltaTime;

        for (int i = 0; i < maxScale; i++)
        {
            if (isscale)
            {
                gameObject.transform.localScale += step;

                if (gameObject.transform.localScale.x >= 5f)
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