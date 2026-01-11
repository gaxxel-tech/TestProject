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
    public partial class InputController
    {
      
        public I2DInput i2DInput {  get; set; }

        

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


        public Vector3  HandleInputLogic()
        {
            I2DInput input = InputManager.Keyboard.Get2DInput(Microsoft.Xna.Framework.Input.Keys.Left,
                Microsoft.Xna.Framework.Input.Keys.Right,
                Microsoft.Xna.Framework.Input.Keys.Up,
                Microsoft.Xna.Framework.Input.Keys.Down);

            if (input == null) return Vector3.Zero;

            Vector3 inputVector = Vector3.Zero;

            inputVector = new Vector3(input.X, input.Y, 0);

            if (inputVector.LengthSquared() > 0)
            {
                inputVector.Normalized();
            }
            return inputVector;
        }
    }
}
