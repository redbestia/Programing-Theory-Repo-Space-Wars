using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restarter : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Game");
    }
}