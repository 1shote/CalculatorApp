using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalButton : MonoBehaviour
{
    public TextMeshProUGUI label;

    public RectTransform rectTransform
    {
        get
        {
            if (_rectTransform == null)
                _rectTransform = GetComponent<RectTransform>();
            return _rectTransform;
        }
    }
    RectTransform _rectTransform;

    public Manager calcManager
    {
        get
        {
            if (_calcManager == null)
                _calcManager = GetComponentInParent<Manager>();
            return _calcManager;
        }
    }
    static Manager _calcManager;

    // Start is called before the first frame update 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTapped()
    {
        Debug.Log("Tapped : " + label.text);
        calcManager.buttonTapped(label.text[0]);
    }
}
