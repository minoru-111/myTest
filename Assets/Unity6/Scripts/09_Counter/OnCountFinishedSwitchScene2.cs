using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCountFinishedSwitchScene2 : MonoBehaviour
{
    public CounterType2 kind = CounterType2.Keys;
    public int lastCount = 3;
    public string sceneName;

    void Update()
    {
        if (GameCounter2.counters[kind] == lastCount)
        {
            SceneManager.LoadScene (sceneName);
        }
    }
}