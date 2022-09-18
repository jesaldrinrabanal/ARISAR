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
    }
    public void SelectBack()
    {
        Select.SetActive(false);
        Menu.SetActive(true);
        canvaseffect.SetActive(true);
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
    }
    public void Manok()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
