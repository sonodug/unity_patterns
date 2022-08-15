using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplaySystem
{
    public class ToggleTurboCommand : Command
    {
        private BikeController _controller;

        public ToggleTurboCommand(BikeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.ToggleTurbo();
        }
    }
}
