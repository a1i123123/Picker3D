using Interfaces;
using UnityEngine;

namespace Commands
{

    public class OnLevelDestroyerCommand : ICommand
    {
        private Transform _LevelHolder;

        public OnLevelDestroyerCommand(Transform levelHolder)
        {
            _LevelHolder = levelHolder;

        }

        public void Execute(int value)
        {
        }

        public void Execute()
        {
            Object.Destroy(obj:_LevelHolder.GetChild(0).gameObject);

        }


    }
}