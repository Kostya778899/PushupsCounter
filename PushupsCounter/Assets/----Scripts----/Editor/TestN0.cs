using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class TestN0 : MonoBehaviour
{
    [TableList, SerializeField] private List<GameObject> _objects = new List<GameObject>();
}
