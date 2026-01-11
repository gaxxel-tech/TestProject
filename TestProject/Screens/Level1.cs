using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Gui;
using FlatRedBall.Math;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Localization;
using Microsoft.Xna.Framework;

using TestProject.Entities;
using TestProject.Entities.Components;


namespace TestProject.Screens
{
    public partial class Level1
    {

        public static Player player = null;
        public static int currentLevel = 1;
        private void CustomInitialize()
        {
            player = Player1;
            float nivelDeZoom = 1.0f;

            // Accedemos a la cámara global
            var camara = Camera.Main;

            // Ajustamos el ancho y alto ortogonal dividiendo por el zoom

        }

        private void CustomActivity(bool firstTimeCalled)
        {
            FlatRedBall.Debugging.Debugger.Write("ActualActivesEnemies: " + (BaseMonsterList.Count()));   
        }

        private void CustomDestroy()
        {
            
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {
            
        }
    }
}
