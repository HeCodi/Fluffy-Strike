using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPMenu : MonoBehaviourPunCallbacks
{
    private void Awake()
    {
        PhotonNetwork.ConnectUsingSettings();

#if UNITY_EDITOR
        PhotonNetwork.ConnectToRegion("ru");
#endif


    }
}
