using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StateMessages")]
public class StateMessages : ScriptableObject
{
    [SerializeField][TextArea(5,10)] private string stateMsg;

}
