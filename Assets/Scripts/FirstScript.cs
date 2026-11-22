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

       gameobject.transform.localScale =new Vector3(gameobject.transform.localScale.x + value.x, gameobject.transform.localScale.y + value.y, gameobject.transform.localScale.z + value.z);
        gameobject.transform.position = new Vector3(gameobject.transform.position.x + value.x, gameobject.transform.position.y + value.y, gameobject.transform.position.z + value.z);

    }
    public void Add()
    {
        int live = lives + 3;
        Debug.Log(live);

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
