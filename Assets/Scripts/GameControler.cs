using System;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour {

    public GameObject menuOpcoes;
    public GameObject menuSeletor;
    public bool statusMenu { get; private set; }

	// Use this for initialization
	void Start () {
        statusMenu = false;
        menuSeletor.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
		
	}

    public void ativaMenu()
    {
        statusMenu = !statusMenu;
        menuOpcoes.SetActive(statusMenu);
    }

    public void ativaSeletorCores()
    {
        menuSeletor.SetActive(true);
    }

    public void fechaSeletorCores()
    {
        menuSeletor.SetActive(false);
    }
}
