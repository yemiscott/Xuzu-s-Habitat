using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class XRGUIExample : MonoBehaviour
{
    [SerializeField]
    public RawImage background;

    [SerializeField]
    public Slider lightSlider;

    [SerializeField]
    public TextMeshProUGUI fontText;

    [SerializeField]
    public ScrollRect gameInfo;

    [SerializeField]
    public TextMeshProUGUI gameInfoDetails;

    [SerializeField]
    public Toggle alphaToggle;

    void Start()
    {      
        alphaToggle.onValueChanged.AddListener((value) =>
        {
            Color currColor = background.color;
            currColor.a = value ? 0.7f : 0;
            background.color = currColor;
        });

        lightSlider.onValueChanged.AddListener((value) =>
        {
            gameInfoDetails.fontSize = value;
            fontText.text = $"FONT SIZE: {value}";
        });
    }
}
