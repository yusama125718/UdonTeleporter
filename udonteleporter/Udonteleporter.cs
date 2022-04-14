
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class Udonteleporter : UdonSharpBehaviour
{
    [Header("テレポート先")]
    [SerializeField] private Transform TereportPosition = null;

    void Interact(VRCPlayerApi player){
        Vector3 teleportVec = TereportPosition.transform.position;
        var target = Networking.LocalPlayer;
        target.TeleportTo(teleportVec, Quaternion.Euler(teleportVec));
    }
}