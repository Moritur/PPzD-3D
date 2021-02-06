using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSnapshotTrigger : MonoBehaviour
{
    #region set in editor
    [Tooltip("Snapshot to trigger when entering this trigger")]
    [SerializeField] AudioMixerSnapshot snapshot;
    [Tooltip("Snapshot transition time in seconds")]
    [SerializeField] float transitionTime;
    [Tooltip("Should player bypass reverb zones after entering this trigger?")]
    [SerializeField] bool bypassReverbZones;
    #endregion

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            snapshot.TransitionTo(transitionTime);

            if (other.TryGetComponent<AudioSource>(out AudioSource audioSource))
            {
                audioSource.bypassReverbZones = bypassReverbZones;
            }
        }
    }
}
