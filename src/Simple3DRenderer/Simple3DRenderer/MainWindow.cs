using System;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

using static Simple3DRenderer.Shapes;
using static Simple3DRenderer.MathTools;

namespace Simple3DRenderer
{
    public partial class MainWindow : Form
    {
        private static int viewportOffsetX, viewportOffsetY;
        private static int worldTranslateX, worldTranslateY, worldTranslateZ;
        private static int worldRotateX, worldRotateY, worldRotateZ;
        private static int cameraFocalLength = 1000;

        bool isDragging = false;
        bool isDragging_rotation = false;

        int lastWorldRotation_x = 0;
        int lastWorldRotation_y = 0;

        int initalMouse_x = 0;
        int initalMouse_y = 0;

        private static readonly List<Vector3D> globalPoints = new List<Vector3D>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            moveTimer.Elapsed += new ElapsedEventHandler(MoveForward);
            moveTimer.Interval = 5;

            Vector3D[] imaginaryCurve = Graph.CreateImaginaryCurve(0, 0, 0, 10, 10, 100, 100);
            AddObjectToWorld(imaginaryCurve);

            // 10x10x10 cubes
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    for (int z = 0; z < 10; z++)
                    {
                        Vector3D[] cube = Geometry.CreateCube(x * 50, y * 50, z * 50, 20, 20, 20);
                        AddObjectToWorld(cube);
                    }
                }
            }
        }

        private void AddObjectToWorld(Vector3D[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                globalPoints.Add(points[i]);
            }
        }

        private void RenderPictureBox_Paint(object sender, PaintEventArgs e)
        {
            // get the picturebox graphics object
            Graphics g = e.Graphics;

            // draw 2d grid
            {
                Pen gridPen = new Pen(Color.FromArgb(255, 100, 100, 100));

                for (int y = -100; y < 100; y++)
                {
                    Vector3D point = new Vector3D
                    {
                        x = 0,
                        y = y * -10,
                        z = 0
                    };

                    Vector3D point2 = new Vector3D
                    {
                        x = 0,
                        y = y * -10,
                        z = 10 * 100 * 2 - 10
                    };

                    Point point1_proj = Process3DPoint(point, -worldTranslateX, worldTranslateY, -worldTranslateZ, worldRotateX, worldRotateY, worldRotateZ, cameraFocalLength);
                    Point point2_proj = Process3DPoint(point2, -worldTranslateX, worldTranslateY, -worldTranslateZ, worldRotateX, worldRotateY, worldRotateZ, cameraFocalLength);

                    int point1_projX = point1_proj.X + viewportOffsetX;
                    int point1_projY = point1_proj.Y + viewportOffsetY;

                    int point2_projX = point2_proj.X + viewportOffsetX;
                    int point2_projY = point2_proj.Y + viewportOffsetY;

                    try
                    {
                        g.DrawLine(gridPen, point1_projX, point1_projY, point2_projX, point2_projY);
                    }
                    catch
                    {

                    }
                }

                for (int z = 0; z < 200; z++)
                {
                    Vector3D point = new Vector3D
                    {
                        x = 0,
                        y = 100 * 10,
                        z = z * 10
                    };

                    Vector3D point2 = new Vector3D
                    {
                        x = 0,
                        y = 10 + -100 * 10,
                        z = z * 10
                    };

                    Point point1_proj = Process3DPoint(point, -worldTranslateX, worldTranslateY, -worldTranslateZ, worldRotateX, worldRotateY, worldRotateZ, cameraFocalLength);
                    Point point2_proj = Process3DPoint(point2, -worldTranslateX, worldTranslateY, -worldTranslateZ, worldRotateX, worldRotateY, worldRotateZ, cameraFocalLength);

                    int point1_projX = point1_proj.X + viewportOffsetX;
                    int point1_projY = point1_proj.Y + viewportOffsetY;

                    int point2_projX = point2_proj.X + viewportOffsetX;
                    int point2_projY = point2_proj.Y + viewportOffsetY;

                    try
                    {
                        g.DrawLine(gridPen, point1_projX, point1_projY, point2_projX, point2_projY);
                    }
                    catch
                    {

                    }
                }
            }

            // draw axis
            {
                Vector3D originPoint = new Vector3D
                {
                    x = 0,
                    y = 0,
                    z = 0
                };

                Point originPoint_rot_projected = Process3DPoint(originPoint, -worldTranslateX, worldTranslateY, -worldTranslateZ, worldRotateX, worldRotateY, worldRotateZ, cameraFocalLength);

                int originPointX = originPoint_rot_projected.X + viewportOffsetX;
                int originPointY = originPoint_rot_projected.Y + viewportOffsetY;

                Vector3D xAxisPoint = new Vector3D
                {
                    x = 10000,
                    y = 0,
                    z = 0
                };

                Point xAxisPoint_rot_projected = Process3DPoint(xAxisPoint, -worldTranslateX, worldTranslateY, -worldTranslateZ, worldRotateX, worldRotateY, worldRotateZ, cameraFocalLength);

                Vector3D yAxisPoint = new Vector3D
                {
                    x = 0,
                    y = 10000,
                    z = 0
                };

                Point yAxisPoint_rot_projected = Process3DPoint(yAxisPoint, -worldTranslateX, worldTranslateY, -worldTranslateZ, worldRotateX, worldRotateY, worldRotateZ, cameraFocalLength);

                Vector3D zAxisPoint = new Vector3D
                {
                    x = 0,
                    y = 0,
                    z = 10000
                };

                Point zAxisPoint_rot_projected = Process3DPoint(zAxisPoint, -worldTranslateX, worldTranslateY, -worldTranslateZ, worldRotateX, worldRotateY, worldRotateZ, cameraFocalLength);

                Pen xAxisPen = new Pen(Color.FromArgb(255, 255, 255, 100));
                try
                {
                    int pointX = xAxisPoint_rot_projected.X + viewportOffsetX;
                    int pointY = xAxisPoint_rot_projected.Y + viewportOffsetY;
                    g.DrawLine(xAxisPen, originPointX, originPointY, pointX, pointY);
                }
                catch
                {

                }

                Pen yAxisPen = new Pen(Color.FromArgb(255, 255, 255, 255));
                try
                {
                    int pointX = yAxisPoint_rot_projected.X + viewportOffsetX;
                    int pointY = yAxisPoint_rot_projected.Y + viewportOffsetY;
                    g.DrawLine(yAxisPen, originPointX, originPointY, pointX, pointY);
                }
                catch
                {

                }

                Pen zAxisPen = new Pen(Color.FromArgb(255, 255, 255, 255));
                try
                {
                    int pointX = zAxisPoint_rot_projected.X + viewportOffsetX;
                    int pointY = zAxisPoint_rot_projected.Y + viewportOffsetY;
                    g.DrawLine(zAxisPen, originPointX, originPointY, pointX, pointY);
                }
                catch
                {

                }
            }

            Point lastPoint = new Point(0, 0);

            for (int i = 0; i < globalPoints.Count; i++)
            {
                // calculate each point transformation and then project
                // 1: rotation, 2: translation, 3: project to 2D screen
                Vector3D rawGlobalPoint = globalPoints[i];
                Vector3D rotatedGlobalPoint = Rotate3DPoint(rawGlobalPoint, worldRotateX, worldRotateY, worldRotateZ);
                Vector3D translatedGlobalPoint = Translate3DPoint(rotatedGlobalPoint, -worldTranslateX, worldTranslateY, -worldTranslateZ);
                Point projectedGlobalPoint = Project3DPoint(translatedGlobalPoint, cameraFocalLength);

                // calculate point distance to simulated camera
                double distance = Math.Sqrt(
                        Math.Pow(worldTranslateX - rotatedGlobalPoint.x, 2) +
                        Math.Pow(-worldTranslateY - rotatedGlobalPoint.y, 2) +
                        Math.Pow(worldTranslateZ - rotatedGlobalPoint.z, 2)
                    );

                // calculate lightFalloff using the distance
                double lightFalloff = 500 / (distance + 1);

                int lightValue = (int)(255 * lightFalloff);

                if (lightValue > 255)
                    lightValue = 255;

                // make the graph a greenish color
                Pen graphPen = new Pen(Color.FromArgb(255, lightValue / 3, lightValue, lightValue / 2));

                // add viewport offsets
                int pointX = projectedGlobalPoint.X + viewportOffsetX;
                int pointY = projectedGlobalPoint.Y + viewportOffsetY;

                if (pointX >= int.MaxValue || pointX <= int.MinValue || pointY >= int.MaxValue || pointY <= int.MinValue)
                    return;

                try
                {
                    if (DrawPointsCheckBox.Checked)
                    {
                        int size = 2;
                        if (rawGlobalPoint.x == 0)
                        {
                            size = 5;
                            graphPen = new Pen(Color.FromArgb(255, lightValue, lightValue / 4, lightValue));
                        }
                        g.DrawEllipse(graphPen, pointX, pointY, size, size);
                    }

                    if (DrawLinesCheckBox.Checked)
                        g.DrawLine(graphPen, pointX, pointY, lastPoint.X, lastPoint.Y);
                }
                catch
                {

                }

                lastPoint = projectedGlobalPoint;
            }
        }

        private void OffsetXTrackBar_Scroll(object sender, EventArgs e)
        {
            viewportOffsetX = OffsetXTrackBar.Value;

            UpdateUI();
        }

        private void RenderPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle && (ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                isDragging = true;

                initalMouse_x = Cursor.Position.X + worldTranslateX;
                initalMouse_y = Cursor.Position.Y - worldTranslateY;
            }
            else if (e.Button == MouseButtons.Middle)
            {
                isDragging_rotation = true;

                initalMouse_x = Cursor.Position.X;
                initalMouse_y = Cursor.Position.Y;
            }
        }

        private static readonly System.Timers.Timer moveTimer = new System.Timers.Timer();

        bool wPressed = false;
        bool sPressed = false;
        bool aPressed = false;
        bool dPressed = false;

        bool ctrlPressed = false; // for moving faster

        bool zPressed = false; // for going up
        bool xPressed = false; // for going down

        bool qPressed = false; // for rotating counter-clockwise
        bool ePressed = false; // for rotating clockwise

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            bool shouldMove = false;

            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    shouldMove = true;
                    break;

                case Keys.S:
                    sPressed = true;
                    shouldMove = true;
                    break;

                case Keys.A:
                    aPressed = true;
                    shouldMove = true;
                    break;

                case Keys.D:
                    dPressed = true;
                    shouldMove = true;
                    break;

                case Keys.Z:
                    zPressed = true;
                    shouldMove = true;
                    break;

                case Keys.X:
                    xPressed = true;
                    shouldMove = true;
                    break;

                case Keys.Q:
                    qPressed = true;
                    shouldMove = true;
                    break;

                case Keys.E:
                    ePressed = true;
                    shouldMove = true;
                    break;
            }

            if (shouldMove)
                moveTimer.Enabled = true;
        }

        private void MoveForward(object source, ElapsedEventArgs e)
        {
            int moveSpeed = 5;

            if (ctrlPressed)
                moveSpeed *= 5;

            if (wPressed)
            {
                worldTranslateZ += moveSpeed;
            }
            if (sPressed)
            {
                worldTranslateZ -= moveSpeed;
            }
            if (aPressed)
            {
                worldTranslateX -= moveSpeed;
            }
            if (dPressed)
            {
                worldTranslateX += moveSpeed;
            }

            if (zPressed)
            {
                worldTranslateY += moveSpeed;
            }
            if (xPressed)
            {
                worldTranslateY -= moveSpeed;
            }

            if (qPressed)
            {
                worldRotateZ -= moveSpeed / 2;
            }
            if (ePressed)
            {
                worldRotateZ += moveSpeed / 2;
            }

            UpdateUI();
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;

                case Keys.S:
                    sPressed = false;
                    break;

                case Keys.A:
                    aPressed = false;
                    break;

                case Keys.D:
                    dPressed = false;
                    break;

                case Keys.Z:
                    zPressed = false;
                    break;

                case Keys.X:
                    xPressed = false;
                    break;

                case Keys.Q:
                    qPressed = false;
                    break;

                case Keys.E:
                    ePressed = false;
                    break;
            }

            if (!wPressed && !sPressed && !aPressed && !dPressed)
                moveTimer.Enabled = false;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((keyData & Keys.Control) == Keys.Control)
            {
                ctrlPressed = true;
            }
            else if ((keyData & Keys.Control) == Keys.None)
            {
                ctrlPressed = false;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void DrawPointsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void DrawLinesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void RenderPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            isDragging_rotation = false;

            lastWorldRotation_x = worldRotateX;
            lastWorldRotation_y = worldRotateY;
        }

        private void RenderPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                worldTranslateX = (initalMouse_x - Cursor.Position.X);
                worldTranslateY = -(initalMouse_y - Cursor.Position.Y);

                UpdateUI();
            }

            if (isDragging_rotation)
            {
                worldRotateX = (initalMouse_y - Cursor.Position.Y) + lastWorldRotation_x;
                worldRotateY = -(initalMouse_x - Cursor.Position.X) + lastWorldRotation_y;

                UpdateUI();
            }
        }

        private void OffsetYTrackBar_Scroll(object sender, EventArgs e)
        {
            viewportOffsetY = OffsetYTrackBar.Value;

            UpdateUI();
        }

        private void FovTrackBar_Scroll(object sender, EventArgs e)
        {
            cameraFocalLength = FovTrackBar.Value;

            UpdateUI();
        }

        private void UpdateUI()
        {
            RenderPictureBox.Invalidate();

            Invoke((MethodInvoker)delegate
            {
                // this code will run on the UI thread
                WorldTranslationXTextBox.Text = worldTranslateX.ToString();
                WorldTranslationYTextBox.Text = worldTranslateY.ToString();
                WorldTranslationZTextBox.Text = worldTranslateZ.ToString();

                WorldRotationXTextBox.Text = worldRotateX.ToString();
                WorldRotationYTextBox.Text = worldRotateY.ToString();
                WorldRotationZTextBox.Text = worldRotateZ.ToString();
            });
        }
    }
}