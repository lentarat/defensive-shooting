using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace DefensiveShooting
{ 
    public class InputActionsInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<InputActions>().AsSingle();
        }
    }
}
