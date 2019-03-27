using UnityEngine;
using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour,IVirtualButtonEventHandler {

    /// <summary>
    /// 虚拟按钮行为类
    /// </summary>
    VirtualButtonBehaviour virtualButtonBehaviour;

    void Start()
    {
        virtualButtonBehaviour = GetComponent<VirtualButtonBehaviour>();
        virtualButtonBehaviour.RegisterEventHandler(this);  //注册事件
    }
    /// <summary>
    /// 当虚拟按钮被挡住
    /// </summary>
    /// <param name="vb">虚拟按钮行为类</param>
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);
    }
    /// <summary>
    /// 当虚拟按钮遮挡离开
    /// </summary>
    /// <param name="vb">虚拟按钮行为类</param>
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);
    }
}
