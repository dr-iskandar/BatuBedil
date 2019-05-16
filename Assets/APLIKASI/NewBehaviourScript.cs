using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour

	{


    public string informasi;
    public string  panduan;
    public string mulaiAR;
    public string menu;
    public string panduanhome;
    public string splash1;
    public string fungsitombol;


    public void informasiScene()
    {
        SceneManager.LoadScene(informasi);
    }
    public void panduanScene()
    {
        SceneManager.LoadScene(panduan);
    }
    public void mulaiARScene()
    {
        SceneManager.LoadScene(mulaiAR);
    }
    public void menuScene()
    {
        SceneManager.LoadScene(menu);
    }
    public void splash1Scene()
    {
        SceneManager.LoadScene(splash1);
    }
    public void fungsitombolScene()
    {
        SceneManager.LoadScene(fungsitombol);
    }
    public void QuitApps()
    {
        Application.Quit();
    }
}

