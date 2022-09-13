using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    internal class MaxFloat
    {

        public double maxfloat()
        {

            Console.WriteLine("Enter First float number");
            double float1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second float number");
            double float2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Third float number");
            double float3 = Convert.ToDouble(Console.ReadLine());

            if (float1.CompareTo(float2) > 0 && float1.CompareTo(float3) > 0 ||
               float1.CompareTo(float2) >= 0 && float1.CompareTo(float3) > 0 ||
               float1.CompareTo(float2) > 0 && float1.CompareTo(float3) >= 0)
            {
                return float1;
            }


            if (float2.CompareTo(float1) > 0 && float2.CompareTo(float3) > 0 ||
               float2.CompareTo(float1) >= 0 && float2.CompareTo(float3) > 0 ||
               float2.CompareTo(float1) > 0 && float2.CompareTo(float3) >= 0)
            {
                return float2;
            }

            if (float3.CompareTo(float1) > 0 && float3.CompareTo(float2) > 0 ||
                 float3.CompareTo(float1) >= 0 && float3.CompareTo(float2) > 0 ||
                float3.CompareTo(float1) > 0 && float3.CompareTo(float2) >= 0)
            {
                return float3;
            }
            return float1 ;
        }

        }
    }
