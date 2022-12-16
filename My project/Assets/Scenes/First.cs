using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour
{
    // Start is called before the first frame update
    int i = 0;
    void Start()
    {
        Debug.Log("hello world");
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(i);
    }
}
