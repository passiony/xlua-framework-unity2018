
using UnityEngine;
using UnityEngine.UI;

public class UILauncher : Singleton<UILauncher>
{
    private GameObject go;
    private Text statusText;
    private Slider slider;

    public GameObject UIGameObject
    {
        get
        {
            return go;
        }
        set
        {
            if (value != go)
            {
                go = value;
                InitGo(go);
            }
        }
    }

    public void InitGo(GameObject go)
    {
        statusText = go.transform.Find("ContentRoot/LoadingDesc").GetComponent<Text>();
        slider = go.transform.Find("ContentRoot/SliderBar").GetComponent<Slider>();
        slider.gameObject.SetActive(false);
    }
    
    public void SetSatus(string status)
    {
        statusText.text = status;
    }

    public void SetValue(float progress, bool active = true)
    {
        slider.gameObject.SetActive(active);
        slider.normalizedValue = progress;
    }

    public void HidLauncher()
    {
        go.SetActive(false);
        SetValue(0, false);
    }

    public override void Dispose()
    {
        if (go != null)
        {
            Object.Destroy(go);
        }
    }
}
