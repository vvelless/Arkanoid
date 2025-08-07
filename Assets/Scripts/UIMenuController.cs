using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMenuController : MonoBehaviour
{
    
    public void LoadGameplayScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
