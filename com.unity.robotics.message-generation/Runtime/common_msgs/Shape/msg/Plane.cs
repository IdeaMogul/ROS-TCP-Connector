//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Shape
{
    public class Plane : Message
    {
        public const string RosMessageName = "shape_msgs/Plane";

        //  Representation of a plane, using the plane equation ax + by + cz + d = 0
        //  a := coef[0]
        //  b := coef[1]
        //  c := coef[2]
        //  d := coef[3]
        public double[] coef;

        public Plane()
        {
            this.coef = new double[4];
        }

        public Plane(double[] coef)
        {
            this.coef = coef;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            
            Array.Resize(ref coef, 4);
            foreach(var entry in coef)
                listOfSerializations.Add(BitConverter.GetBytes(entry));

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            
            this.coef= new double[4];
            for(var i = 0; i < 4; i++)
            {
                this.coef[i] = BitConverter.ToDouble(data, offset);
                offset += 8;
            }

            return offset;
        }

        public override string ToString()
        {
            return "Plane: " +
            "\ncoef: " + System.String.Join(", ", coef.ToList());
        }
    }
}