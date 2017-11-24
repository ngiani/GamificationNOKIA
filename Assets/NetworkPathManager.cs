using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkPathManager : MonoBehaviour {

    public List<NetworkElement> path;
    private int currentStep;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Check if the chosen destination on the panel is the correct one. If it is, tell the player to move
    public void CheckChosenDestination(string ID)
    {
        PlayerController playerController = FindObjectOfType<PlayerController>();

        if (!playerController.moving)
        {
            if (ID == path[currentStep].ID)
            {

                playerController.SetUpTravel();

                PanelText panelText = FindObjectOfType<PanelText>();
                panelText.SetCorrect();
                currentStep++;
            }

            else
            {
                PanelText panelText = FindObjectOfType<PanelText>();
                panelText.SetWrong();
            }
        }
    }

}
