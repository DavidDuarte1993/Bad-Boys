using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuPanel : MonoBehaviour,IPointerClickHandler
{
    
    public GameObject panel;

    public void OpenPanel()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
    public void ClosePanel()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!panel.activeInHierarchy)
        {
            OpenPanel();
        }
        else
        {
            ClosePanel();
        }
    }
  
}
