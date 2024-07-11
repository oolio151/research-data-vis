using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topic
{
    public string name;
    public string description;
    public int rating;

    public Topic(string name, string description, int rating)
    {
        this.name = name;
        this.description = description;
        this.rating = rating;
        if (this.rating > 1) this.rating = 1;
        else if (this.rating < -1) this.rating = -1;
    }
}
