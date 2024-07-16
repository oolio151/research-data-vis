using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class CSVReader : MonoBehaviour
{
    public static string fileName = "f1data.csv"; 
    private static string[,] data;
    public Topic[] topics;

    void Start()
    {
        //make sure that this is delayed later
        ReadCSV();
        //PrintData();
    }

    public static string[,] ReadCSV()
    {
        string filePath = Path.Combine(Application.dataPath, fileName);

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                int numRows = lines.Length;
                int numCols = lines[0].Split(',').Length;
                
                data = new string[numRows, numCols];
                for (int i = 0; i < numRows; i++)
                {
                    string[] values = lines[i].Split(',');

                    for (int j = 0; j < numCols; j++)
                    {
                        data[i, j] = values[j];
                    }
                }
                return data;
            }
            else
            {
                Debug.LogError("CSV file is empty.");
            }
        }
        else
        {
            Debug.LogError("CSV file not found.");
        }
        return new string[0,0];
    }

    //take the data and spit it into the unity console.
    static void PrintData()
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            string row = "";
            for (int j = 0; j < data.GetLength(1); j++)
            {
                row += data[i, j] + " ";
            }

        }
    }

    void CreateTopics()
    {

    }
}
