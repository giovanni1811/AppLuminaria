using System;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour {

    public GameObject mainPanel;
    public GameObject menuOpcoes;
    public GameObject menuSeletor;
    public bool statusMenu { get; private set; }

    public SeletorCores sc;

	// Use this for initialization
	void Start () {
        statusMenu = false;
        menuSeletor.SetActive(false);
        mainPanel.SetActive(true);
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
        mainPanel.SetActive(false);
    }

    public void fechaSeletorCores()
    {
        menuSeletor.SetActive(false);
        mainPanel.SetActive(true);
    }
}
