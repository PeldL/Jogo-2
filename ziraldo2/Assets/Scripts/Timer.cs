using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Timer : MonoBehaviour
{
    public Text texto;
    public float tempo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    private IEnumerator StartCountdown()
    {
        float timeRemaining = tempo;
        Time.timeScale = 0f;

        while (timeRemaining > 0)
        {
            texto.text = Mathf.Ceil(timeRemaining).ToString();
            yield return new WaitForSecondsRealtime(1f);
            timeRemaining -= 1f;
        }

        texto.text = "Gooo!!!";
        yield return new WaitForSecondsRealtime(1f);

        texto.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}