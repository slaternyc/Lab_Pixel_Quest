using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // Variables
public class geo : MonoBehaviour
{
    private int varOne = 1;

    private string Shinken = "Wassup";

    // Start is called before the first frame update
    void Start()
    {
        int varTwo = 2;
        Debug.Log("Hello World!");
        string Kenshin = "Dude";
        Debug.Log(Shinken+Kenshin);

    }
    int var = 3;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(var);
        var++;
    }
}