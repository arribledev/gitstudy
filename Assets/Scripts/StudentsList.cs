using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentsList : MonoBehaviour {
    private string[] _students = {
        "Vadim Kovalchuk",
        
    };

    private void Start() {
        foreach (string student in _students) Debug.LogWarning("Student: " + student);
    }

}
