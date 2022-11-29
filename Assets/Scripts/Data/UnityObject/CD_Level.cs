using System.Collections.Generic;
using Data.ValueObject;
using UnityEngine;

//attributes
namespace Data.UnityObject
{
    [CreateAssetMenu(fileName = "CD_Level", menuName = "Picker3D/CDLevel")]
    public class CD_Level : ScriptableObject
    {
        public List<LevelData> Levels = new List<LevelData>();
    }
}
