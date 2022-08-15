using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplaySystem
{
    public class InputHandler : MonoBehaviour
    {
        private Invoker _invoker;
        private bool _isReplaying;
        private bool _isRecording;
        private BikeController _bikeController;
        private Command _buttonA, _buttonD, _buttonW;

        void Start()
        {
            _invoker = gameObject.AddComponent<Invoker>();
            _bikeController = FindObjectOfType<BikeController>();

            _buttonA = new TurnLeftCommand(_bikeController);
            _buttonD = new TurnRightCommand(_bikeController);
            _buttonW = new ToggleTurboCommand(_bikeController);
        }

        void Update()
        {
            if (!_isReplaying && _isRecording)
            {
                if (Input.GetKeyUp(KeyCode.A))
                    _invoker.ExecuteCommand(_buttonA);

                if (Input.GetKeyUp(KeyCode.D))
                    _invoker.ExecuteCommand(_buttonD);

                if (Input.GetKeyUp(KeyCode.W))
                    _invoker.ExecuteCommand(_buttonW);
            }
        }

        /// <summary>
        /// Test replay system
        /// </summary>
        void OnGUI()
        {
            if (GUILayout.Button("Start Recording"))
            {
                _bikeController.ResetPosition();
                _isReplaying = false;
                _isRecording = true;
                _invoker.Record();
            }

            if (GUILayout.Button("Stop Recording"))
            {
                _bikeController.ResetPosition();
                _isRecording = false;
            }

            if (!_isRecording)
            {
                if (GUILayout.Button("Start Replay"))
                {
                    _bikeController.ResetPosition();
                    _isRecording = false;
                    _isReplaying = true;
                    _invoker.Replay();
                }
            }
        }
    }
}
