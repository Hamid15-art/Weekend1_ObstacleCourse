using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class LifeCycleExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //[SerializeField] string playerName = "Abdullah";
    //void Awake()
    //{
    //    Debug.Log("Awake", this);
    //}

    void Start()
    {
        //Debug.Log("Player name: " + playerName, this);
        findindex(cube,value);

    }
    //void OnEnable()
    //{
    //    Debug.Log("On Enable");
    //}
    int[] cube = { 15, 30, 80, 40, 55 };
    int value = 55;
    void findindex(int[] cube, int value)
    {
        if(cube == null || cube.Length == 0)
        {
            Debug.Log("Array is empty");
            return;
        }
        for (int i = 0; i < cube.Length; i++)
        {
            if (cube[i] == value)
            {
                Debug.Log("Found value " + value + " at index: " + i);
                return;
            }
        }
        Debug.Log("Value " + value + " not found (-1)");
    }
    //reverse an array
    //void findminmax(int[] cube)
    //{
    //    if (cube == null || cube.Length == 0)
    //    {
    //        Debug.Log(0);
    //        return;
    //    }
    //    for (int i =0;i<cube.Length/2;i++)
    //    {
    //       int oppositeindex = cube.Length - 1 - i;
    //         int temp = cube[i];
    //        cube[i] = cube[oppositeindex];
    //        cube[oppositeindex] = temp;

    //    }
    //       return;
    //}
    //find minmax
    //     int max = cube[0];
    //     int min = cube[0];
    // for (int i = 1; i<cube.Length; i++)
    //     {
    //         if (cube[i] > max)
    //         {
    //             max = cube[i];
    //         }
    //         else if (cube[i] < min)
    //         {
    //             min = cube[i];
    //         }
    //     }

    //     Debug.Log("Max:" +max + ", Min:"+ min);
    // }

}
