using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public int score;
    public Text text;
    public Text endtext;
    public GameObject endpanel;
    private void OnTriggerEnter(Collider other)//objeleri toplama ve puan arttýrma
    {
        if (other.gameObject.tag == "Collected")
        {
            Destroy(other.gameObject);
            score += 10;
            Spawnert.instance.count--;
            Spawnert.instance.spawnobjects.Remove(other.gameObject);
            PlayerPrefs.SetInt("Score", score);
            text.text = score.ToString();
            StartCoroutine(Spawnert.instance.Spawns());

            if (score == 100)
            {
                Time.timeScale = 0;
                endpanel.SetActive(true);
                endtext.text = score.ToString();

            }
        }
    }
}
