using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUIController : MonoBehaviour
{
    public void ToHome()
    {
        SceneManager.LoadScene(0);
    }
    public void RestartGameplay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
