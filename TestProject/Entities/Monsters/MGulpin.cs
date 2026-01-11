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
using TestProject.Screens;
using System.Diagnostics;

namespace TestProject.Entities.Monsters
{
    public partial class MGulpin: ICollidable
    {
        /// <summary>
        /// Initialization logic which is executed only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
        private void CustomInitialize()
        {
            this.MovementControllerInstance.CurrentSpeed = MonsterData.Speed;
        }

        private void CustomActivity()
        {
            Vector3 playerPos = Level1.player.Position;

            Vector3 direction = playerPos - this.Position;
            
            if (direction.Length() > 5)
            {
                direction.Normalize();
                MovementControllerInstance.HandleMovementLogic(direction);
            }
            else
            {
                MovementControllerInstance.HandleMovementLogic(Vector3.Zero);

                Velocity *= 0.9f;
            }






            if (this.Position.X < playerPos.X)
            {
                SpriteInstance.FlipHorizontal = true;
            }
            else
            {
                SpriteInstance.FlipHorizontal = false;
            }

        }

        private void CustomDestroy()
        {
            
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {
            
        }
    }
}
