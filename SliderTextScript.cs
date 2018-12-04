using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTextScript : MonoBehaviour {

    Text diff;

    private void Start()
    {
        diff = GetComponent<Text>();
    }

    public void diffUpdate (float value)
    {
        if(value == 1)
        {
            diff.text = "EASY";
        }
        else if(value == 2)
        {
            diff.text = "MEDIUM";
        }
        else if(value == 3)
        {
            diff.text = "HARD";
        }
    }
}
