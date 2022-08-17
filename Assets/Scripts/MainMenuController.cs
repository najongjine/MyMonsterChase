using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        var clickedObj = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        var splitStringarr=clickedObj.Split("__");
        var index = int.Parse(splitStringarr[splitStringarr.Length - 1]);
        GameManager.instance.CharIndex = index;
        SceneManager.LoadScene(1);
    }

}
