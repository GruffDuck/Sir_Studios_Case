using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startpanel, endpanel;
    private void Start()
    {
        //baþlama ve bitiþ menüsü için kodlar
        int starter = PlayerPrefs.GetInt("start");
        if (starter == 0)
        {
            startpanel.SetActive(true);
            Time.timeScale = 0f;
        }
        else
            startpanel.SetActive(false);
        Time.timeScale = 1f;
        PlayerPrefs.DeleteAll();
    }

    public void StartPanel()
    {
        Time.timeScale = 1f;
        startpanel.SetActive(false);
    } public void EndPanel()
    {
        int started = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        started = 1;
        PlayerPrefs.SetInt("start", started);
        
        endpanel.SetActive(false);
        startpanel.SetActive(false);
    }
}
