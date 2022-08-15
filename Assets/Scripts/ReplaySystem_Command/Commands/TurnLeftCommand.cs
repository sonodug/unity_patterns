using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplaySystem
{
    public class TurnLeftCommand : Command
    {
        private BikeController _controller;

        public TurnLeftCommand(BikeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.Turn(BikeController.Direction.Left);
        }
    }
}
