using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class WatchSelect : MonoBehaviour
{
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    public GameObject w1Window;
    public GameObject w2Window;
    public GameObject w3Window;

    Animation w1WindowAnimation;
    Animation w2WindowAnimation;
    Animation w3WindowAnimation;


    // Start is called before the first frame update
    void Start()
    {
        w1WindowAnimation = w1Window.GetComponent<Animation>();
        w2WindowAnimation = w2Window.GetComponent<Animation>();
        w3WindowAnimation = w3Window.GetComponent<Animation>();
    }

    public void watchOneButtonClicked()
    {
        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);

        w1WindowAnimation["w1animation"].speed = 1;
        w1WindowAnimation.Play();

    }

    public void watchTwoButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);

        w2WindowAnimation["w2animation"].speed = 1;
        w2WindowAnimation.Play();

    }

    public void watchThreeButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);

        w3WindowAnimation["w3animation"].speed = 1;
        w3WindowAnimation.Play();
    }

    public void CloseButtonClicked()
        {
            string buttonName = EventSystem.current.currentSelectedGameObject.name;
            Debug.Log(buttonName);

            if (buttonName == "w1close")
            {
                w1WindowAnimation["w1animation"].speed = -1;
                w1WindowAnimation["w1animation"].time = w1WindowAnimation["w1animation"].length;
                w1WindowAnimation.Play();
            }

             if (buttonName == "w2close")
            {
                w2WindowAnimation["w2animation"].speed = -1;
                w2WindowAnimation["w2animation"].time = w2WindowAnimation["w2animation"].length;
                w2WindowAnimation.Play();
            }


             if (buttonName == "w3close")
            {
                w3WindowAnimation["w3animation"].speed = -1;
                w3WindowAnimation["w3animation"].time = w3WindowAnimation["w3animation"].length;
                w3WindowAnimation.Play();
            }
        }

    public void closeBtn2Clicked()
    {
        w2WindowAnimation["w2animation"].speed = -1;
        w2WindowAnimation["w2animation"].time = w2WindowAnimation["w2animation"].length;
        w2WindowAnimation.Play();
        
    }

    public void closeBtn3Clicked()
    {
        w3WindowAnimation["w3animation"].speed = -1;
        w3WindowAnimation["w3animation"].time = w3WindowAnimation["w3animation"].length;
        w3WindowAnimation.Play();
    }

    }




