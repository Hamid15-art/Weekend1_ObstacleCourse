using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float moveSpeed = 2f;
    private bool movingForward;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (movingForward)
            {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

                if (transform.localPosition.z >= 10f)
                {
                    movingForward = false;
                }
            }
            else
            {
                transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

                if (transform.localPosition.z <= 1f)
                {
                    movingForward = true;
                }
            }
        }
    }
