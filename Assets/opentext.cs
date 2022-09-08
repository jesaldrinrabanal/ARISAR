using UnityEngine;
using UnityEngine.UI;

public class opentext : MonoBehaviour
{
    public GameObject gameObject;
    bool active;
    public void OpenPanel()
    {
       if (gameObject.activeInHierarchy == true)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
