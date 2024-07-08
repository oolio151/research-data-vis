using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class CSVReader : MonoBehaviour
{
    public string fileName = "Assets/main.csv"; // Set your CSV file name here
    private string[,] data;

    void Start()
    {
        ReadCSV();
        PrintData();
    }

    void ReadCSV()
    {
        string filePath = Path.Combine(Application.dataPath, fileName);

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                // Get the number of rows and columns
                int numRows = lines.Length;
                int numCols = lines[0].Split(',').Length;

                // Initialize the 2D array
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

    void PrintData()
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
