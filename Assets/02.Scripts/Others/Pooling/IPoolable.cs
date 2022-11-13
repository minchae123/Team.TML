using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPoolable 
{
    public string NAME { get; set; }   
    public void OnPool();
    public void PushObj();
}
