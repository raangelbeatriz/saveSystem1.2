using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string cenaDestino;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Changescene()
    {
        //Add Fade in and Fade out 
        SceneManager.LoadScene(cenaDestino);
    }


}