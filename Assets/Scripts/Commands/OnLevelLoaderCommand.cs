using Interfaces;
using UnityEngine;

namespace Commands
{
    public class OnLevelLoaderCommand : ICommand
    {
        public Transform _levelHolder;

        public OnLevelLoaderCommand(Transform levelHolder)
        {
            _levelHolder = levelHolder;
        }
        public void Execute()
        {
        }
        public void Execute(int levelID)
        {
            Object.Instantiate(Resources.Load<GameObject>($"Prefabs/LevelPrefabs/Level{levelID}"), _levelHolder);
        }
    }
}