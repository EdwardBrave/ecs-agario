using Data;
using HSM;
using Unity.Entities;

namespace Core
{
    public class BootState : BaseSubState<BootState, AppHsm>
    {
        protected override void OnEnter(SystemBase system)
        {
            var scenesConfig = system.GetSingleton<ScenesConfig>();
            SetState(new SceneTransitionState(scenesConfig.mainMenuSceneName, new GameState()));
        }
    }
}