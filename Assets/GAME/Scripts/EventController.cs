using UnityEngine;
using System;

public static class EventController
{
    public static event Action OnGameStart;

    public static event Action OnVictory;

    public static event Action OnDefeat;

    public static event Action OnPause;

    public static event Action OffPause;

    public static event Action OnLangueChanged;

    public static void InvokeGameStart()
    {
        Debug.Log("Start!");

        OnGameStart?.Invoke();
    }

    public static void InvokeVictory()
    {
        Debug.Log("Victory!");

        OnVictory?.Invoke();
    }

    public static void InvokeDefeat()
    {
        Debug.Log("Defeat!");

        OnDefeat?.Invoke();
    }

    public static void InvokePauseON()
    {
        Debug.Log("PauseON!");

        OnPause?.Invoke();
    }

    public static void InvokePauseOFF()
    {
        Debug.Log("PauseOFF!");

        OffPause?.Invoke();
    }

    public static void InvokeLangueChange()
    {
        Debug.Log("LangieChanged!");

        OnLangueChanged?.Invoke();
    }
}
