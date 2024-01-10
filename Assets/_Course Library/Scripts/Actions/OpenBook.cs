using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject notebook;
    public HingeJoint joint;
    void Start()
    {
        var joint = notebook.GetComponent<HingeJoint>();
        joint.useMotor = false;
    }

    public void openBook()
    {
        joint.useMotor = true;
    }
}
