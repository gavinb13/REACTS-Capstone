using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string sceneNameLowStress;
    public string sceneNameMediumStress;
    public string sceneNameHighStress;
    public string sceneNameHomeScreen;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
