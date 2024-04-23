using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public string sceneNameLowStress;
    public string sceneNameMediumStress;
    public string sceneNameHighStress;
    public string sceneNameHomeScreen;
    public TMP_Text   hudText;

    public void ChangeSceneLow()
    {
        hudText.text = "Changing scene...";
        SceneManager.LoadScene(sceneNameLowStress);
        hudText.text = "";

    }
    public void ChangeSceneMedium()
    {
        hudText.text = "Changing scene...";
        SceneManager.LoadScene(sceneNameMediumStress);
        hudText.text = "";

    }
    public void ChangeSceneHigh()
    {
        hudText.text = "Changing scene...";
        SceneManager.LoadScene(sceneNameHighStress);
        hudText.text = "";

    }
    public void ChangeSceneHomeScreen()
    {
        hudText.text = "Returning to main screen...";
        SceneManager.LoadScene(sceneNameHomeScreen);
        hudText.text = "";
    } 
  
}
