using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class PenguinAcademy : Academy
{
    // Start is called before the first frame update
    private PenguinArea[] penguinAreas;

    public override void AcademyReset(){
        if(penguinAreas == null){
            penguinAreas.FindObjectsOfType<PenguinArea>();
        }

        foreach(PenguinArea penguinArea in penguinAreas){
            penguinArea.fishSpeed = resetParameters["fish_speed"];
            penguinArea.feedRadius = resetParameters["feed_radius"];
            penguinArea.ResetArea();
        } 
    }
}
