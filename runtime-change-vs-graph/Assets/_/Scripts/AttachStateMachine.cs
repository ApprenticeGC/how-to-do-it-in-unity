using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(StateMachine))]

public class AttachStateMachine : MonoBehaviour
{
    public bool isAttached = false;

    public ScriptableObject sgaSo;

    private void Awake()
    {
        var machine = GetComponent<StateMachine>();
        machine.enabled = false;
        // // This is the way to create new one, but not useful in run time
        // var sga = ScriptableObject.CreateInstance<StateGraphAsset>();
        // machine.nest.SwitchToMacro(sga);
        // machine.enabled = true;


        var sga = sgaSo as StateGraphAsset;
        machine.nest.SwitchToMacro(sga);

        machine.enabled = true;
    }

    private void Start()
    {
    }
}
