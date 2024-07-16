using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabPlacer : MonoBehaviour
{

    string[,] data;
    public GameObject dotPrefab;
    // Start is called before the first frame update
    void Start()
    {
        data = CSVReader.ReadCSV();
        for (int i = 1; i < data.GetLength(0); i++)
        {
            
            int XPos = XPosCalculator(float.Parse(data[i, 2]));
            GameObject temp = Instantiate(dotPrefab, GameObject.Find("button parent").transform);
            temp.transform.GetComponent<TopicButton>().topic = new Topic(data[i, 0], data[i, 1], float.Parse(data[i, 2]));
            temp.transform.localPosition = new Vector3(XPos, Random.Range(-85, 90), 0);
        }
    }
    //95 to -85
    //x based on partiality
    //make the y random depending on the x axis for now

    //ranking assumes a scale from -1.0 to 1.0
    static int XPosCalculator(float ranking)
    {
        Debug.Log(400 + (ranking * 300));
        return Mathf.RoundToInt((ranking * 300));
    }
}
