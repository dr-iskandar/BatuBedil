using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindahmenu : MonoBehaviour
{



    public string informasi;
    


    public void informasiScene()
    {
        SceneManager.LoadScene(informasi);
    }
}
