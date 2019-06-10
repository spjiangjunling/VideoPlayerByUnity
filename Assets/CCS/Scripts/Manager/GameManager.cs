using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SimpleJson;

namespace CCS
{
    public class GameManager : Manager
    {
        void Start()
        {
            StartCoroutine(Init());
        }

        IEnumerator Init()
        {
            DontDestroyOnLoad(gameObject);
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            Application.targetFrameRate = 40;
            Application.runInBackground = true;
            ResManager.Initialize();
            PanManager.OpenPanel<LobbyPanel>(PanelName.LobbyPanel);
            yield return Yielders.EndOfFrame;
        }

//        public void OnApplicationPause(bool pause)
//        {
//#if UNITY_IPHONE || UNITY_ANDROID

//#endif
//        }

//        private double loseFocusTime = 0;
//        public void OnApplicationFocus(bool focus)
//        {
//#if UNITY_IPHONE || UNITY_ANDROID
//            if (!focus)
//            {
//                //失去焦点
//                loseFocusTime = Util.GetTimeStamp();
//            }
//            else
//            {
//                //获得焦点
//                if (loseFocusTime > 0)
//                {
//                    //Util.CallMethod("GlobalListener", "OnApplicationFocusManager", Util.GetTimeStamp() - loseFocusTime);
//                }
//            }
//#endif
//        }

        void OnDestroy()
        {
            if (NetManager != null)
            {
                NetManager.Unload();
            }
        }
    }
}