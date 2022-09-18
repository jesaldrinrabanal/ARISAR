using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChickenButtonAnimation : MonoBehaviour
{
   public void ChickenClick()
    {
        string Chlick = EventSystem.current.currentSelectedGameObject.name;
    }
}
