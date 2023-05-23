using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    private const string k_Anim_Idle = "Default";
    private const string k_Anim_In = "in";
    private const string k_Anim_Out = "out";
    
    [field: SerializeField]
    private SimpleAnimation Target { get; set; }

    private void PlayImpl(string stateName)
    {
        bool ret = Target.Play(stateName);
        Debug.Log($"Play Result:{ret}");
    }
    
    public void Idle()
    {
        PlayImpl(k_Anim_Idle);
    }
    
    public void In()
    {
        PlayImpl(k_Anim_In);
    }

    public void Out()
    {
        PlayImpl(k_Anim_Out);
    }
}
