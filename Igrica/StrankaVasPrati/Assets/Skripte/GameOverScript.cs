﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

    public Text score;
	// Use this for initialization
	void Start () {
        score.GetComponent<Text>();
        score.text = JumpingScript.S.Score.ToString();
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void izlaz()
    {
        Application.Quit();
    }
    public void Ponovi()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
