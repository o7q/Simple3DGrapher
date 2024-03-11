using System;
using System.Numerics;
using System.Collections.Generic;

using static Simple3DGrapher.MathTools;

namespace Simple3DGrapher
{
    public static class Shapes
    {
        public static class Geometry
        {
            public static Vector3D[] CreateCube(int locX, int locY, int locZ, int scaleX, int scaleY, int scaleZ)
            {
                Vector3D[] cube = new Vector3D[8];

                cube[0].x = 0;
                cube[0].y = 0;
                cube[0].z = 0;

                cube[1].x = 1;
                cube[1].y = 0;
                cube[1].z = 0;

                cube[2].x = 0;
                cube[2].y = 1;
                cube[2].z = 0;

                cube[3].x = 1;
                cube[3].y = 1;
                cube[3].z = 0;

                cube[4].x = 0;
                cube[4].y = 0;
                cube[4].z = 1;

                cube[5].x = 1;
                cube[5].y = 0;
                cube[5].z = 1;

                cube[6].x = 0;
                cube[6].y = 1;
                cube[6].z = 1;

                cube[7].x = 1;
                cube[7].y = 1;
                cube[7].z = 1;

                for (int i = 0; i < 8; i++)
                {
                    cube[i].x = cube[i].x * scaleX + locX;
                    cube[i].y = cube[i].y * scaleY + locY;
                    cube[i].z = cube[i].z * scaleZ + locZ;
                }

                return cube;
            }
        }

        public static class Graph
        {
            public static Vector3D[] CreateImaginaryCurve(int locX, int locY, int locZ, int scaleX, int scaleY, int length, int step)
            {
                List<Complex> imaginaryCurve = new List<Complex>();

                for (double i = 0; i < length; i += 1 / (double)step)
                {
                    Complex imaginarySqrt = Complex.Pow(-1, i);
                    imaginaryCurve.Add(imaginarySqrt);
                }

                Vector3D[] imaginaryCurvePoints = new Vector3D[imaginaryCurve.Count];

                for (int i = 0; i < imaginaryCurve.Count; i++)
                {
                    imaginaryCurvePoints[i].x = (int)(imaginaryCurve[i].Real * scaleX) + locX;
                    imaginaryCurvePoints[i].y = (int)(imaginaryCurve[i].Imaginary * scaleY) + locY;
                    imaginaryCurvePoints[i].z = i + locZ;
                }

                return imaginaryCurvePoints;
            }

            public static Vector3D[] CreateSineCurve(int locX, int locY, int locZ, int scaleX, int scaleY, int length)
            {
                Vector3D[] sineCurve = new Vector3D[length];

                for (int i = 0; i < sineCurve.Length; i++)
                {
                    sineCurve[i].x = i * scaleX + locX;
                    sineCurve[i].y = (int)(Math.Sin(i) * scaleY) + locY;
                    sineCurve[i].z = locZ;
                }

                return sineCurve;
            }

            public static Vector3D[] CreateTangentCurve(int locX, int locY, int locZ, int scaleX, int scaleY, int length)
            {
                Vector3D[] tangentCurve = new Vector3D[length];

                for (int i = 0; i < tangentCurve.Length; i++)
                {
                    tangentCurve[i].x = i * scaleX + locX;
                    tangentCurve[i].y = (int)(Math.Tan(i) * scaleY) + locY;
                    tangentCurve[i].z = locZ;
                }

                return tangentCurve;
            }
        }
    }
}