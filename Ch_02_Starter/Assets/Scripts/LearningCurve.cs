using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{ 
    [SerializeField] private int currentAge;
    [SerializeField] private int addedAge;
    
    // Start is called before the first frame update
    private void Start()
    {
        ComputeAge();
    }

    /// <summary>
    /// Computes a modified age by adding two variables together
    /// </summary>
    private void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }
    
    // Update is called once per frame
    void Update()
    {
     
    }
}