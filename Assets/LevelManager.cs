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
    public TMP_Text hudText;

    public void ChangeSceneLow()
    
    {

       
        SceneManager.LoadScene(sceneNameLowStress);
 

    }
    public void ChangeSceneMedium()
    {
       
        SceneManager.LoadScene(sceneNameMediumStress);
       

    }
    public void ChangeSceneHigh()
    {
       
        SceneManager.LoadScene(sceneNameHighStress);
     

    }
    public void ChangeSceneHomeScreen()
    {
       
        SceneManager.LoadScene(sceneNameHomeScreen);
        
    } 
  
}
