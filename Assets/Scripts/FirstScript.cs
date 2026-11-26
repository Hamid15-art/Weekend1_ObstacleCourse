using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] int lives = 2;

    public GameObject gameobject;

    public Collider collider;
    [SerializeField] Vector3 value;
    [SerializeField] 
    float value1=0.5f;
    
    void Start()
    {
        Add();
        collider = gameObject.GetComponent<Collider>();

        collider.enabled = false;

        

        

    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.localScale.x < 5f)
        {
            gameObject.transform.localScale += value;
        }
        else if(gameObject.transform.localScale.x > 5f)
        {
            gameObject.transform.localScale = Vector3.one;
        }
            gameobject.transform.position = new Vector3(gameobject.transform.position.x + value.x, gameobject.transform.position.y + value.y, gameobject.transform.position.z + value.z);

    }
    public void Add()
    {
        lives = lives + 3;
        Debug.Log(lives);

    }
    public int Add(int x)
    {
        lives = lives * x;
        return lives;
    }

    //Data types
    //Conditions and loops
    //Method and return Statement
    //Mono Behaviour


}
