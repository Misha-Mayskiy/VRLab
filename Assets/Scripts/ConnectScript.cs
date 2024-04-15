using UnityEngine;

public class ConnectScript : MonoBehaviour
{
    public int countClicked = 0;
    Transform obj1;
    Transform obj2;
    [SerializeField]
    private Transform cylinderPrefab;

    private GameObject leftSphere;
    private GameObject rightSphere;
    private GameObject cylinder;

    public void Update() {
        if (countClicked == 2) {
            CreateLine(obj1, obj2);
            countClicked = 0;
        }
    }

    public void ApplyObj(Transform obj) {
        
        if (countClicked == 0) {
            obj1 = obj;
        }
        else if (countClicked == 1) {
            obj2 = obj;
        }
        countClicked += 1;
    }

    public void CreateLine(Transform obj1, Transform obj2) {
        // leftSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        // rightSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        // leftSphere.transform.position = obj1.position;
        // rightSphere.transform.position = obj2.position;

        InstantiateCylinder(cylinderPrefab, obj1.position, obj2.position);
    }

    private void UpdateCylinderPosition(GameObject cylinder, Vector3 beginPoint, Vector3 endPoint)
    {
        Vector3 offset = endPoint - beginPoint;
        Vector3 position = beginPoint + (offset / 2.0f);

        cylinder.transform.position = position;
        cylinder.transform.LookAt(beginPoint);
        Vector3 localScale = cylinder.transform.localScale;
        localScale.z = (endPoint - beginPoint).magnitude;
        cylinder.transform.localScale = localScale;
    }

    private void InstantiateCylinder(Transform cylinderPrefab, Vector3 beginPoint, Vector3 endPoint)
    {
        cylinder = Instantiate<GameObject>(cylinderPrefab.gameObject, Vector3.zero, Quaternion.identity);
        UpdateCylinderPosition(cylinder, beginPoint, endPoint);
    }
}
