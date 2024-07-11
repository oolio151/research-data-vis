using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabPlacer : MonoBehaviour
{

    string[,] data;
    GameObject dotPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //x based on partiality
    //make the y random depending on the x axis for now

    //ranking assumes a scale from -1.0 to 1.0
    static int XPosCalculator(int ranking)
    {
        return 400 + (ranking * 300);
    }
}
