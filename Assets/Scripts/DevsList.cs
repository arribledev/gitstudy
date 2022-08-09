using UnityEngine;
using Debug = UnityEngine.Debug;

public class DevsList : MonoBehaviour {
    private string[] _developers = {
        "Vadim Kovalchuk",
        "Olesia Pashko",
        
        "Ekaterina Lenskaya",
        "Alexander Tkachenko",
        "Vlad Hryhorashchenko",
    };

    private void Start() {
        Debug.LogWarning("Who is breathtaking?");
        foreach (string dev in _developers) Debug.LogWarning(dev + " is breathtaking!");
    }

    private void Update() {
        Debug.LogWarning("All is ok!");
    }

}
