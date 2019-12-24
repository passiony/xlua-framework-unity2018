using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


/// <summary>
/// UI的按下和抬起事件
/// </summary>
public class UIPointerDownUp : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public UIPointerEvent onPressDown = new UIPointerEvent();
    public UIPointerEvent onPressUp = new UIPointerEvent();

    public void OnPointerDown(PointerEventData eventData)
    {
        onPressDown.Invoke(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        onPressUp.Invoke(eventData);
    }
}

namespace UnityEngine.Events
{
    [System.Serializable]
    public class UIPointerEvent : UnityEvent<PointerEventData> { }
}