using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TopicButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Topic topic;
    public void ButtonAction()
    {
        Debug.Log("fdsfa");
        if (GameObject.Find("panel parent").transform.GetChild(0).gameObject.activeSelf != true)
        {            Debug.Log("fdsfa");
            GameObject.Find("panel parent").transform.GetChild(0).gameObject.SetActive(true);
            GameObject.Find("Title Text").GetComponent<TextMeshProUGUI>().text = topic.name;
            GameObject.Find("Description").GetComponent<TextMeshProUGUI>().text = topic.description;
        }
        
    }

    public void CloseMenu()
    {
        GameObject.Find("panel parent").transform.GetChild(0).gameObject.SetActive(false);
    }
}
