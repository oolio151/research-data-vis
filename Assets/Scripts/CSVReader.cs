using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class CSVReader : MonoBehaviour
{
    public static string fileName = "Assets/main.csv"; 
    private static string[,] data;

    void Start()
    {
        //make sure that this is delayed later
        ReadCSV();
        PrintData();
    }

    public static void ReadCSV()
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
            Debug.Log(row);
        }
    }
}
