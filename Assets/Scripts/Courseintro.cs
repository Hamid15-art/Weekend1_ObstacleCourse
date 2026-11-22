using UnityEngine;

public class Courseintro : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public FirstScript firstscript;
    void Start()
    {
        int y = firstscript.Add(2);
        Debug.Log(y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
