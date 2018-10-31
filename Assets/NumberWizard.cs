using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Use this for initialization
    void Start () {

        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick ye numberrrr ");
        Debug.Log("The higher Number is " + max);
        Debug.Log("The lower number is " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push up = higher, Push down equals lower, Push enter = correct");
        max = max + 1;

	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.UpArrow)){
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than... " + guess);
        } 
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than... " + guess);
        }
        else if(Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("I am a genius");
        }

	}
}
