using UnityEngine;

public class ButtonWire : MonoBehaviour
{
    public GameObject TargetObj;
    public Transform positionButton;
    public void ButtonWireClicked() {
        TargetObj.GetComponent<ConnectScript>().ApplyObj(positionButton);
    }
}