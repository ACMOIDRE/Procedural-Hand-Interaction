using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class HandContrainScript : MonoBehaviour
// {
    
//      public GameObject mParentCon;

//     private enum Mode
//     {
//         Idle,
//         Hand
//     }

//     private Mode m_Mode;

//     public void Update()
//     {
//         if (m_Mode != Mode.Idle)
//         {
//             var constraint = mParentCon.GetComponent<MultiParentConstraint>();
//             var sourceObjects = constraint.data.sourceObjects;

//             sourceObjects.SetWeight(1, m_Mode == Mode.Hand ? 1f : 0f);
//             constraint.data.sourceObjects = sourceObjects;

//             m_Mode = Mode.Idle;
//         }
//     }

//     public void Start()
//     {
//         m_Mode = Mode.Idle;
//         Debug.Log ("ground");
//     }
//     public void hand()
//     {
//         m_Mode = Mode.Hand;
//         Debug.Log ("hand");
//     }

    
// }
