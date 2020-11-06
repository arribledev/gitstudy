using UnityEngine;

public class DevsList : MonoBehaviour {
    private string[] _developers = {
        "Vadim Kovalchuk",
        
    };

    private void Start() {
        Debug.LogWarning("Who is breathtaking?");
        foreach (string dev in _developers) Debug.LogWarning(dev + " is breathtaking!");
    }

    private void Update() {
        
    }

}
