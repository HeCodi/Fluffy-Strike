using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowValue : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Slider _slider;

    public void ShowSliderValue()
    {
        _text.text = _slider.value.ToString();
    }
}
