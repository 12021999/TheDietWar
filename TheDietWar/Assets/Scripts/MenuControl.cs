using UnityEngine;
using System.Collections;

public class MenuControl : MonoBehaviour {

    public GameObject[] Buttons;
	void Start () 
    {
        
	}

    void ChangeScenes()
    {
        if(!Buttons[0].activeSelf)
        {
            Application.LoadLevel("Game");
        }
    }

	void Update () 
    {
        print(Buttons[0]);
        ChangeScenes();
	}
}
