using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetLodingBarScript : MonoBehaviour
{
    private Image fillImg;
    // Use this for initialization
    void Start()
    {
        fillImg = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (RayCastScript.rayColliderName == "Target")
            fillImg.fillAmount += Time.deltaTime;
        else
            fillImg.fillAmount = 0;
    }
}
