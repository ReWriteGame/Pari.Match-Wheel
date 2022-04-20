using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
   [SerializeField] private SideCube[] sideCubes;
   public SideCube currentSideAbove;

   public SideCube[] SideCubes => sideCubes;

   private void Start()
   {
      sideCubes = GetComponentsInChildren<SideCube>();
   }


  
}
