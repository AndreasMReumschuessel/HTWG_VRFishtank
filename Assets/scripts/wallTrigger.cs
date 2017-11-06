using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class wallTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var chaperone = OpenVR.Chaperone;
        HmdQuad_t pRect = new HmdQuad_t();
        bool success = (chaperone != null) && chaperone.GetPlayAreaRect(ref pRect);
        if (!success)
            Debug.LogWarning("Failed to get Calibrated Play Area bounds!  Make sure you have tracking first, and that your space is calibrated.");

        //todo dynamic sizing
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
