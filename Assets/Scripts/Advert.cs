using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class Advert : MonoBehaviour
{
    public Text logger;

    private SwiftForUnity instanse;

    private void Start()
    {
        instanse = SwiftForUnity.Instance;
    }

    public void StartAd()
    {
        string response = instanse.HiFromSwift();
        logger.text = response;
    }
}
