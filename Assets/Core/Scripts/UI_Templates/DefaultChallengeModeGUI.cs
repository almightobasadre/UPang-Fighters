using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UFE3D;

public class DefaultChallengeModeGUI : ChallengeMode
{
    public void OnGUI()
    {
        if (!complete && !UFE.config.lockInputs && !UFE.config.lockMovements)
        {
            GUI.skin.label.fontSize = 30;
            // GUI.Box(new Rect(70, 170, 320, 170), UFE.GetChallenge(currentChallenge).challengeName);
            GUI.BeginGroup(new Rect(90, 230, 320, 400));
            {
                if (UFE.GetChallenge(currentChallenge).description == "%list%")
                {
                    string newDesc = "";
                    int currAction = 0;
                    foreach (ActionSequence actionSeq in challengeActions)
                    {
                        string moveName = actionSeq.specialMove.moveName;
                        if (currentAction > currAction) moveName += " (DONE)";

                        newDesc += moveName + "\n";
                        currAction++;
                    }
                    GUILayout.Label(newDesc);
                }
                else
                {
                    GUILayout.Label(UFE.GetChallenge(currentChallenge).description);
                }
            }
            GUI.EndGroup();

            GUI.skin.button.fontSize = 30;
            if (GUI.Button(new Rect(Screen.width - 220, 950, 140, 60), "Skip"))
            {
                currentAction = challengeActions.Count;
                testChallenge();
            }
        }
    }
}
