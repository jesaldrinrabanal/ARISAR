using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectStorybook : MonoBehaviour
{

    public GameObject Subtitlewindow;
 
    public void SelectManok()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      
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
    }
}
