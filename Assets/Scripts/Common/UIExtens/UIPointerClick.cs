using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

/// <summary>
/// UI的点击事件
/// </summary>
public class UIPointerClick : MonoBehaviour,IPointerClickHandler
{
    public UIPointerEvent onClick = new UIPointerEvent();

    public void OnPointerClick(PointerEventData eventData)
    {
        onClick.Invoke(eventData);
    }
}
