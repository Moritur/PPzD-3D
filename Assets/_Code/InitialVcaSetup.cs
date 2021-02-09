using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialVcaSetup : MonoBehaviour
{
    #region set in editor
    [Tooltip("Name of VCA which should be initially disabled")]
    [SerializeField] string enableVcaName;
    [Tooltip("Name of VCA which should be initially enabled")]
    [SerializeField] string disableVcaName;
    #endregion

    void Awake()
    {
        RuntimeManager.GetVCA(disableVcaName).setVolume(0f);
        RuntimeManager.GetVCA(enableVcaName).setVolume(1f);
    }
}
