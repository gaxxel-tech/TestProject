using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework;
using TestProject.Entities.Monsters;
using System.Linq;
using TestProject.Screens;

namespace TestProject.Entities.Managers
{
    public partial class SpawnManager
    {

        List<BaseMonsterVariant> ActiveEnemiesToSpawn;
        int MaxEnemiesToSpawn = 1;
        double LastTimeSpawned;


        private void CustomInitialize()
        {
            ActiveEnemiesToSpawn = BaseMonsterVariant.All
                .Where(m => m.MonsterData.Level == Level1.currentLevel)
                .ToList();
            LastTimeSpawned = TimeManager.CurrentScreenTime;
        }

        private void CustomActivity()
        {
            double tiempoActual = TimeManager.CurrentScreenTime;

            if (tiempoActual - LastTimeSpawned > 2.0)
            {

                SpawnRandomEnemy();
                LastTimeSpawned = tiempoActual;
            }
        }

        private void CustomDestroy()
        {
            
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {
            
        }


        private void SpawnRandomEnemy()
        {
            if (ActiveEnemiesToSpawn == null || ActiveEnemiesToSpawn.Count == 0) return;

            var EnemySelected = FlatRedBall.FlatRedBallServices.Random.In(ActiveEnemiesToSpawn);

            var monsterSelected = EnemySelected.CreateNew() as BaseMonster;

            if (monsterSelected != null)
            {
                
                SetPositionOutsideOfScreen(monsterSelected);
                monsterSelected.MovementControllerInstance.CurrentSpeed = monsterSelected.MonsterData.Speed;
            }


        }

        private void SetPositionOutsideOfScreen(BaseMonster enemy)
        {
            float margen = 150f;
            float radio = (Camera.Main.OrthogonalWidth / 2) + margen;
            float angle = FlatRedBall.FlatRedBallServices.Random.AngleRadians();

            enemy.Position.X = Camera.Main.X + (float)MathF.Cos(angle) * radio;
            enemy.Position.Y = Camera.Main.Y + (float)MathF.Sin(angle) * radio;
            enemy.Position.Z = 0;
        }

    }
}
