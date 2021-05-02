using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TeleportGame : MonoBehaviour
{
    public Button yourButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        if (gameObject.CompareTag("emotion"))
        
        {
            SceneManager.LoadScene("Emotion1");

        }
        if (gameObject.CompareTag("recycling"))

        {
            SceneManager.LoadScene("Recycling");

        }
        if (gameObject.CompareTag("story"))

        {
            SceneManager.LoadScene("Story");

        }
        if (gameObject.CompareTag("zoo"))

        {
            SceneManager.LoadScene("PettingZoo");

        }
        if (gameObject.CompareTag("dance"))

        {
            SceneManager.LoadScene("DanceGame");

        }


    }
}
