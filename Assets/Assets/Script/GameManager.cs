using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void SceneToGamePlay() => SceneManager.LoadScene("GamePlay");
    public void QuitGame() => Application.Quit();
}