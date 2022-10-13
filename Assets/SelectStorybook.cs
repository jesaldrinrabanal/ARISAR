using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectStorybook : MonoBehaviour
{

    public GameObject Subtitlewindow;
    public AudioSource home;
    public AudioSource reload;

    public void SelectManok()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      
    }
    public void ManokBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        home.Play();

    }
    public void OldBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        home.Play();

    }
    public void OldBackEng()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        home.Play();

    }
    public void ManokBackEng()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        home.Play();
    }
    public void SelectBack()
    {
        Subtitlewindow.gameObject.SetActive(false);

    }
    public void SelectSubtitle()
    {
        Subtitlewindow.gameObject.SetActive(true);
    }
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        reload.Play();
    }
}
