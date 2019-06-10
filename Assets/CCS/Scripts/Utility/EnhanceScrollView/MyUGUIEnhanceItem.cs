using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
using UnityEngine.EventSystems;

public class MyUGUIEnhanceItem : EnhanceItem
{
    private Button uButton;
    private RawImage rawImage;
    //private LuaFunction itemSetDataFunc = null;
    public void AddItemSetDataFunc()
    {
        //itemSetDataFunc = luac;
    }

    protected override void OnStart()
    {
        rawImage = GetComponent<RawImage>();
        uButton = GetComponent<Button>();
        uButton.onClick.AddListener(OnClickUGUIButton);
    }

    private void OnClickUGUIButton()
    {
        OnClickEnhanceItem();
    }

    // Set the item "depth" 2d or 3d
    protected override void SetItemDepth(float depthCurveValue, int depthFactor, float itemCount)
    {
        int newDepth = (int)(depthCurveValue * itemCount);
        this.transform.SetSiblingIndex(newDepth);
    }

    public override void SetSelectState(bool isCenter)
    {
        //if (null != itemSetDataFunc)
        //{
        //    itemSetDataFunc.Call(isCenter);
        //}
        //if (rawImage == null)
        //    rawImage = GetComponent<RawImage>();
        //rawImage.color = isCenter ? Color.white : Color.gray;
    }
    void Destroy()
    {
        //if (itemSetDataFunc != null)
        //{
        //    itemSetDataFunc.EndPCall();
        //    itemSetDataFunc = null;
        //}
    }
}
