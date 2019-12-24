using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// UI页面的动画类-lua使用
/// 1.Lua中页面的打开和关闭的动画事件回调
/// 2.页面需要绑定Animator组件和该脚本
/// 3.动画需要绑定动画帧事件，并绑定该类函数
/// </summary>
[RequireComponent(typeof(Animator))]
public class UIBaseAnimation : MonoBehaviour
{
    public UnityEvent onOpen = new UnityEvent();
    public UnityEvent onClose = new UnityEvent();

    public void OnPageOpend()
    {
        onOpen.Invoke();
    }

    public void OnPageClosed()
    {
        onClose.Invoke();
    }
}
