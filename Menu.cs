using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
	void Start()
	{
		Cursor.visible=true;
	}

	public void StartGame()
	{
		Application.LoadLevel(0);
	}





    void OnMouseDown()
    {
        Application.LoadLevel(1);
    }


}
