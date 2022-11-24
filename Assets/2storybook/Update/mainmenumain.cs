using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenumain : MonoBehaviour
{
    public GameObject Select;
    public GameObject Menu;
    public GameObject canvaseffect;
    public GameObject Setting;
    public GameObject Helps;
    public GameObject Language;
    public GameObject Language2;
    public AudioSource closeSound;
    public GameObject canvasX;
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;

    public Animator transition;
    public float transitionTime = 1f;
    public void StartApp()
    {
        Select.SetActive(true);
        Menu.SetActive(false);
        canvaseffect.SetActive(false);
    }
   

    public void Settings()
    {
        Setting.SetActive(true);
        Menu.SetActive(false);
        canvaseffect.SetActive(false);
    }
    public void SettingBack()
    {
        Setting.SetActive(false);
        Menu.SetActive(true);
        canvaseffect.SetActive(true);
        closeSound.Play();
    }
    public void SelectBack()
    {
       
        Select.SetActive(false);
        Menu.SetActive(true);
        canvaseffect.SetActive(true);
        closeSound.Play();
        
    }
    public void Help()
    {
        Helps.SetActive(true);
        Menu.SetActive(false);
        canvaseffect.SetActive(false);
    }
    public void HelpBack()
    {
        Helps.SetActive(false);
        Menu.SetActive(true);
        canvaseffect.SetActive(true);
        closeSound.Play();
        page1.gameObject.SetActive(true);
        page2.gameObject.SetActive(false);
        page3.gameObject.SetActive(false);
        page4.gameObject.SetActive(false);
    }
    public void LangBack()
    {
        Language.SetActive(false);
        Language2.SetActive(false);
        canvasX.gameObject.SetActive(true);
        closeSound.Play();
    }
    public void Manok()
    {
        Language.SetActive(true);
        canvasX.gameObject.SetActive(false);
    }
    public void ManokTagalog()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void ManokEnglish()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));
    }
    public void Matanda()
    {
        Language2.SetActive(true);
        canvasX.gameObject.SetActive(false);
    }
    public void MatandaTagalog()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 3));
    }
    public void MatandaEnglish()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 4));
    }

    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }


    

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
