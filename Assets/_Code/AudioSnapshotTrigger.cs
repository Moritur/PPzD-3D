using FMOD.Studio;
using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSnapshotTrigger : MonoBehaviour
{
    #region set in editor
    [Tooltip("Name of the VCA which should be disabled when wntering this trigger")]
    [SerializeField] string disableVcaName;
    [Tooltip("Name of the VCA which should be enabled when wntering this trigger")]
    [SerializeField] string enableVcaName;
    #endregion

    VCA disableVca;
    VCA enableVca;

    void Awake()
    {
        disableVca = RuntimeManager.GetVCA(disableVcaName);
        enableVca = RuntimeManager.GetVCA(enableVcaName);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            disableVca.setVolume(0f);
            enableVca.setVolume(1f);
        }
    }
}
