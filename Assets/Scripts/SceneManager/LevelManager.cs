using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    #region SINGLETON
    private static LevelManager instance;
    public static LevelManager Instance { get => instance; }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    public void ChangeLevel(Levels level)
    {
        SceneManager.LoadScene((int)level);
    }

    public void ChangeLevel(int level)
    {
        SceneManager.LoadScene(level);
    }
}
