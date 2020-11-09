using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    float space = 0;
    public GameObject spaceBarCounter;

    // Start is called before the first frame update
    void Start()
    {
        spaceBarCounter.GetComponent<Text>().text = "SpaceBar: " + space;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceBarCounter.GetComponent<Text>().text = "SpaceBar: " + ++space;
            MonoBehaviour.print("spaceBarCounter: " + space);
        }
    }
}
