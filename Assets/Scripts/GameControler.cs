using System;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour {

    public GameObject menuOpcoes;
    public bool status { get; private set; }

	// Use this for initialization
	void Start () {
        status = false;
	}

	// Update is called once per frame
	void Update () {
		
	}

    public void ativaMenu()
    {
        status = !status;
        menuOpcoes.SetActive(status);
    }
}
