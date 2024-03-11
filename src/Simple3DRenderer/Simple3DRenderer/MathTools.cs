using System;
using System.Drawing;

namespace Simple3DRenderer
{
    public static class MathTools
    {
/*        public struct Point3D
        {
            public int x, y, z;
        }
*/
        public struct Vector3D
        {
            public double x, y, z;
        }

/*        public static Vector3D PointToVector3D(Point3D point)
        {
            Vector3D vector = new Vector3D();
            vector.x = point.x;
            vector.y = point.y;
            vector.z = point.z;
            return vector;
        }

        public static Point3D Vector3DToPoint(Vector3D vector)
        {
            Point3D point = new Point3D();
            point.x = (int)vector.x;
            point.y = (int)vector.y;
            point.z = (int)vector.z;
            return point;
        }*/

        public static Vector3D Rotate3DPoint(Vector3D point, double rotationX, double rotationY, double rotationZ)
        {
            double radiansX = DegreesToRadians(rotationX);
            double radiansY = DegreesToRadians(rotationY);
            double radiansZ = DegreesToRadians(rotationZ);

            // camera x rotation
            double tempRotationY_1 = point.y * Math.Cos(radiansX) + point.z * Math.Sin(radiansX);
            double tempRotationZ_1 = -point.y * Math.Sin(radiansX) + point.z * Math.Cos(radiansX);

            // camera y rotation
            double tempRotationX_1 = point.x * Math.Cos(radiansY) - tempRotationZ_1 * Math.Sin(radiansY);
            double tempRotationZ_2 = point.x * Math.Sin(radiansY) + tempRotationZ_1 * Math.Cos(radiansY);

            // camera z rotation
			Vector3D rotatedPoint = new Vector3D();
            rotatedPoint.x = tempRotationX_1 * Math.Cos(radiansZ) + tempRotationY_1 * Math.Sin(radiansZ);
            rotatedPoint.y = -tempRotationX_1 * Math.Sin(radiansZ) + tempRotationY_1 * Math.Cos(radiansZ);
            rotatedPoint.z = tempRotationZ_2;

            return rotatedPoint;
        }

        public static Vector3D Translate3DPoint(Vector3D point, double x, double y, double z)
        {
            Vector3D translatedPoint = new Vector3D();

            translatedPoint.x = point.x + x;
            translatedPoint.y = point.y + y;
            translatedPoint.z = point.z + z;

            return translatedPoint;
        }

        public static Point Project3DPoint(Vector3D inputPoint, double focalLength)
        {
            Point projectedPoint = new Point();

            // projects 3d points to 2d
            // FORMULA: PX = (X * FOV) / (Z + FOV)
            projectedPoint.X = (int)((inputPoint.x * focalLength) / (inputPoint.z + focalLength));
            projectedPoint.Y = (int)((inputPoint.y * focalLength) / (inputPoint.z + focalLength));

            return projectedPoint;
        }

        public static Point Process3DPoint(Vector3D point, double cameraX, double cameraY, double cameraZ, double rotationX, double rotationY, double rotationZ, double focalLength)
        {
            Vector3D rotatedPoint = Rotate3DPoint(point, rotationX, rotationY, rotationZ);
            Vector3D translatedPoint = Translate3DPoint(rotatedPoint, cameraX, cameraY, cameraZ);

            return Project3DPoint(translatedPoint, focalLength);
        }

        public static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
    }
}