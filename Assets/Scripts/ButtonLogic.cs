using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonLogic : MonoBehaviour
{
    [SerializeField] public int value;

    [SerializeField] public bool isPlus;
    [SerializeField] public bool isMinus;
    [SerializeField] public bool isTimes;
    [SerializeField] public bool isDivide;
    [SerializeField] public bool isEquals;
    [SerializeField] public bool isClear;
}
