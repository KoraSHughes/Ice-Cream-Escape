using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newLevel : MonoBehaviour
{
	public string levelName = "Level2";

    private void OnTriggerEnter(Collider other){
    	// Debug.Log("Collidede with " + other.ToString());
    	if (other.CompareTag("Player")){  // other.tag == "Player"
    		Debug.Log("Yay, you did it! Moving to " + levelName);
    		SceneManager.LoadScene(levelName);
    	}
    }
}
