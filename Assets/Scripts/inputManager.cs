using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inputManager : MonoBehaviour
{
    PlayerInput playerInput;
    public bool one;
    public bool two;
    public bool three;
    public bool four;
    public bool five;
    public bool six;
    public bool seven;
    public bool eight;
    public bool nine;
    public bool zero;
    public bool plus;
    public bool minus;
    public bool multiply;
    public bool divide;
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        playerInput.enabled = true;
    }
    void Update()
    {
    }
}
