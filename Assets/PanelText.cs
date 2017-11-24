using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelText : MonoBehaviour {

    private Text textComp;

	// Use this for initialization
	void Start () {
        textComp = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetCorrect()
    {
        textComp.text = "Correct!";
        textComp.color = Color.green;
    }

    public void SetWrong()
    {
        textComp.text = "Wrong!";
        textComp.color = Color.red;
    }
}
