using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplaySystem
{
    public class TurnRightCommand : Command
    {
        private BikeController _controller;

        public TurnRightCommand(BikeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(BikeController.Direction.Right);
        }
    }
}
