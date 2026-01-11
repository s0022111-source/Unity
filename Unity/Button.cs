using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject my_Button;

    public void OnClick()
    {
        my_Button.GetComponent<Button>().interactable = false;
        Debug.Log("Button Clicked");
        //Application.LoadLevel("SampleScene");
        gameObject.SetActive(false);
        if (gameObject.activeSelf == false)
        {
            Debug.Log("Button is now inactive");
            Application.LoadLevel("SampleScene");
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

