using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   private void Start()
   {
	   //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	   
	   //Scene newScene = SceneManager.CreateScene("SceneManager");
	   //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   
   public void StartGame()
   {
	   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   
   public void Exit()
   {
	   Debug.Log("Exit!");
	   Application.Quit();
   }
}