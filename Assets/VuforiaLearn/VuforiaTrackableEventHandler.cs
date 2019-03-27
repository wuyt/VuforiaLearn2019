using UnityEngine;

public class VuforiaTrackableEventHandler : DefaultTrackableEventHandler
{
    protected override void Start () {
        base.Start();
	}

    /// <summary>
    /// 发现识别象
    /// </summary>
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        Debug.Log(mTrackableBehaviour.TrackableName + "...>>>");
    }
    /// <summary>
    /// 识别对象丢失
    /// </summary>
    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        Debug.Log(mTrackableBehaviour.TrackableName + "...>>>");
    }
}
