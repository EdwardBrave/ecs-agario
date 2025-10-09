using System;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace Data
{
    [Serializable]
    public class ScenesConfig : IComponentData
    {
        public string gameSceneName;
        public string mainMenuSceneName;
    }
}