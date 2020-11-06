using UnityEngine;

public class StudentsList : MonoBehaviour {
    private string[] _students = {
        "Vadim Kovalchuk",
        
    };

    private void Start() {
        Debug.LogWarning("Who is breathtaking?");
        foreach (string student in _students) Debug.LogWarning(student + " is breathtaking!");
    }
}
