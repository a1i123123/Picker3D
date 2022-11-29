using System;
using System.Collections.Generic;

namespace Data.ValueObject
{
    [Serializable]
    public class LevelData
    {
        public List<PoolData> PoolList = new List<PoolData>();
    }

    [Serializable]
    public struct PoolData
    {
        public sbyte RequiredObjectCount;
    }
}