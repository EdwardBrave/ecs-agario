using HSM;
using Unity.Entities;
using UnityEngine;

namespace Core
{
    public class SceneTransitionState : BaseSubState<SceneTransitionState, AppHsm>
    {
        private string _sceneName;
        private ISubState<AppHsm> _nextState;
        private AsyncOperation _sceneLoadingOperation;

        public SceneTransitionState(string sceneName, ISubState<AppHsm> nextState)
        {
            _sceneName = sceneName;
            _nextState = nextState;
        }

        protected override void OnEnter(SystemBase system)
        {
            _sceneLoadingOperation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(_sceneName);
            _sceneLoadingOperation.completed += (_) => SetState(_nextState);
        }
    }
}