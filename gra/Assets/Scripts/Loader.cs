﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    public enum Scene { 
        GameScene,
        GameScene1,
        GameScene2,
        GameScene3,
        GameScene4,
        GameScene5,
        Loading,
        MainMenu,
        CharSelect,
    }

    private static Scene targetScene;
  public static void Load(Scene scene)
    {
        SceneManager.LoadScene(Scene.Loading.ToString());
        targetScene = scene;
    }

    public static void LoadTargetScene()
    {
        SceneManager.LoadScene(targetScene.ToString());
    }
}
