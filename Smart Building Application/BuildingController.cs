using System;
using System.Linq;

namespace Smart_Building
{
    public class BuildingController
    {
        private string buildingID;
        private string currentState;

        public BuildingController(string buildingID)
        {
            // Constructor initializes the building ID to lowercase and sets the initial state to "out of hours"
            currentState = "out of hours";
            buildingID = buildingID.ToLower();
            this.buildingID = buildingID;
        }

        public BuildingController(string id, string startState)
        {
            // Constructor initializes the building ID to lowercase and validates the start state
            buildingID = id.ToLower();
            currentState = IsValidState(startState) ? startState : throw new ArgumentException("Argument Exception: BuildingController can only be initialised to the following states 'open', 'closed', 'out of hours'");
        }

        public string GetBuildingID()
        {
            // Getter for building ID
            return buildingID;
        }

        public string GetCurrentState()
        {
            // Getter for current state
            return currentState;
        }

        public void SetBuildingID(string id)
        {
            // Setter for building ID
            buildingID = id.ToLower();
        }

        public bool SetCurrentState(string state)
        {
            // Setter for current state, validates the state before setting
            if (IsValidState(state))
            {
                if (state != currentState)
                {
                    currentState = state;
                }
                return true;
            }
            return false;
        }

        private bool IsValidState(string state)
        {
            // Checks if the provided state is valid
            string[] validStates = { "closed", "open", "out of hours", "fire drill", "fire alarm" };
            return validStates.Contains(state.ToLower());
        }
    }
}
