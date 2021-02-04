//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Nav
{
    public class GetPlanRequest : Message
    {
        public const string RosMessageName = "nav_msgs/GetPlan";

        //  Get a plan from the current position to the goal Pose 
        //  The start pose for the plan
        public Geometry.PoseStamped start;
        //  The final pose of the goal position
        public Geometry.PoseStamped goal;
        //  If the goal is obstructed, how many meters the planner can 
        //  relax the constraint in x and y before failing. 
        public float tolerance;

        public GetPlanRequest()
        {
            this.start = new Geometry.PoseStamped();
            this.goal = new Geometry.PoseStamped();
            this.tolerance = 0.0f;
        }

        public GetPlanRequest(Geometry.PoseStamped start, Geometry.PoseStamped goal, float tolerance)
        {
            this.start = start;
            this.goal = goal;
            this.tolerance = tolerance;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(start.SerializationStatements());
            listOfSerializations.AddRange(goal.SerializationStatements());
            listOfSerializations.Add(BitConverter.GetBytes(this.tolerance));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.start.Deserialize(data, offset);
            offset = this.goal.Deserialize(data, offset);
            this.tolerance = BitConverter.ToSingle(data, offset);
            offset += 4;

            return offset;
        }

        public override string ToString()
        {
            return "GetPlanRequest: " +
            "\nstart: " + start.ToString() +
            "\ngoal: " + goal.ToString() +
            "\ntolerance: " + tolerance.ToString();
        }
    }
}