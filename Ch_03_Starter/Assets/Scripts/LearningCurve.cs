using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LearningCurve : MonoBehaviour
//IM ON SITE 58 IN THE BOOK
{
    private int CurrentAge = 30;
    public int AddedAge = 1;

    public float pi = 3.14f;
    public string firstName = "Harrison";
    public bool isAuthor = true;

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
        Debug.Log($"A string can have variables like {firstName} inserted directly!");
    }

    /// <summary>
    /// A method to compute two variables
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }
}