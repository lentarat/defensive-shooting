using UnityEngine;
using Zenject;
using Weapons.Guns.Composites;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;

namespace Weapons.Guns
{
    public class Gun
    {
        private bool _hasBulletInChamber;
        private float _cooldownBeforeNextShot;
        private IFireMode _fireMode;

        public Gun(IFireMode fireMode, int cooldownBeforeNextShot)
        { 
            _fireMode = fireMode;
            _cooldownBeforeNextShot = cooldownBeforeNextShot;
        }

        public void PullTrigger()
        {
            if (_hasBulletInChamber)
            {
                Shoot();
                CooldownBeforeNextShot().Forget();
            }
        }

        private void Shoot()
        {
            _hasBulletInChamber = false;
        }

        private async UniTask CooldownBeforeNextShot()
        {
            await UniTask.WaitForSeconds(_cooldownBeforeNextShot);
        }

        private void LoadNextBulletIntoChamber()
        {
            _hasBulletInChamber = true;
        }

        public void ReloadMagazine()
        { 
        
        }

        public void LoadChamber()
        { 
            
        }
    }
}
