using Interfaces;
using UnityEngine;

namespace Commands
{

    public class OnLevelLoaderCommand : ICommand
    {
        private Transform _levelHolder;

        public OnLevelLoaderCommand(Transform levelHolder)
        {
            _levelHolder = levelHolder;

        }

        public void Execute()
        {
        }

        public void Execute(int levelID)
        {
            Object.Instantiate(Resources.Load<GameObject>(path:$"Prefabs/LevelPrefabs/level{levelID}"), _levelHolder);
        }

    }
}