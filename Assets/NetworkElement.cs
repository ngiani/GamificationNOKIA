using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkElement : MonoBehaviour {

    [SerializeField] private string _id;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string ID
    {
        get
        {
            return _id;
        }
    }
}
