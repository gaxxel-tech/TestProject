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

namespace TestProject.Entities.Components
{
    public partial class MovementController
    {
        /// <summary>
        /// Initialization logic which is executed only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
        /// 

        
        private void CustomInitialize()
        {
            
        }

        private void CustomActivity()
        {


        }

        private void CustomDestroy()
        {
            
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {
            
        }

        public void HandleMovementLogic(Vector3 direction)
        {
            this.Parent.Drag = 10f;
            if(this.Parent == null) return;
            if (direction == Vector3.Zero)
            {
                this.Parent.Acceleration = Vector3.Zero;
                return;
            }



            float accel = 500f;
            this.Parent.Acceleration = direction * accel;
            
        }
    }
}
