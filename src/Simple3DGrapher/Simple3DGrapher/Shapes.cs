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
            public static Vector3D[] CreateImaginaryCurve(double locX, double locY, double locZ, double scaleX, double scaleY, double scaleZ, int length, double step)
            {
                List<Complex> imaginaryCurve = new List<Complex>();

                for (double i = 0; i < length; i += step)
                {
                    Complex imaginarySqrt = Complex.Pow(-1, i);
                    imaginaryCurve.Add(imaginarySqrt);
                }

                Vector3D[] imaginaryCurvePoints = new Vector3D[length];

                for (int i = 0; i < length; i++)
                {
                    imaginaryCurvePoints[i].x = i * step * scaleX + locX;
                    imaginaryCurvePoints[i].y = imaginaryCurve[i].Real * scaleY + locY;
                    imaginaryCurvePoints[i].z = imaginaryCurve[i].Imaginary * scaleZ + locZ;
                }

                return imaginaryCurvePoints;
            }

            public static Vector3D[] CreateSineCurve(double locX, double locY, double locZ, double scaleX, double scaleY, int length, double step)
            {
                List<double> sineCurve = new List<double>();

                for (double i = 0; i < length; i += step)
                {
                    double sine = Math.Sin(i);
                    sineCurve.Add(sine);
                }

                Vector3D[] sineCurvePoints = new Vector3D[length];

                for (int i = 0; i < length; i++)
                {
                    sineCurvePoints[i].x = i * step * scaleX + locX;
                    sineCurvePoints[i].y = sineCurve[i] * scaleY + locY;
                    sineCurvePoints[i].z = locZ;
                }

                return sineCurvePoints;
            }

            public static Vector3D[] CreateTangentCurve(double locX, double locY, double locZ, double scaleX, double scaleY, int length, double step)
            {
                List<double> tangetCurve = new List<double>();

                for (double i = 0; i < length; i += step)
                {
                    double sine = Math.Tan(i);
                    tangetCurve.Add(sine);
                }

                Vector3D[] tangetCurvePoints = new Vector3D[length];

                for (int i = 0; i < length; i++)
                {
                    tangetCurvePoints[i].x = i * step * scaleX + locX;
                    tangetCurvePoints[i].y = tangetCurve[i] * scaleY + locY;
                    tangetCurvePoints[i].z = locZ;
                }

                return tangetCurvePoints;
            }
        }
    }
}