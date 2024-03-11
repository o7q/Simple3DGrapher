namespace Simple3DRenderer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RenderPictureBox = new System.Windows.Forms.PictureBox();
            this.OffsetXTrackBar = new System.Windows.Forms.TrackBar();
            this.OffsetYTrackBar = new System.Windows.Forms.TrackBar();
            this.FovTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WorldTranslationXTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WorldTranslationYTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WorldTranslationZTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WorldRotationZTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WorldRotationYTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.WorldRotationXTextBox = new System.Windows.Forms.TextBox();
            this.DrawPointsCheckBox = new System.Windows.Forms.CheckBox();
            this.DrawLinesCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.RenderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetXTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetYTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // RenderPictureBox
            // 
            this.RenderPictureBox.BackColor = System.Drawing.Color.Black;
            this.RenderPictureBox.Location = new System.Drawing.Point(7, 8);
            this.RenderPictureBox.Name = "RenderPictureBox";
            this.RenderPictureBox.Size = new System.Drawing.Size(1295, 564);
            this.RenderPictureBox.TabIndex = 0;
            this.RenderPictureBox.TabStop = false;
            this.RenderPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.RenderPictureBox_Paint);
            this.RenderPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RenderPictureBox_MouseDown);
            this.RenderPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RenderPictureBox_MouseMove);
            this.RenderPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RenderPictureBox_MouseUp);
            // 
            // OffsetXTrackBar
            // 
            this.OffsetXTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.OffsetXTrackBar.Location = new System.Drawing.Point(1310, 157);
            this.OffsetXTrackBar.Maximum = 10000;
            this.OffsetXTrackBar.Minimum = -10000;
            this.OffsetXTrackBar.Name = "OffsetXTrackBar";
            this.OffsetXTrackBar.Size = new System.Drawing.Size(176, 45);
            this.OffsetXTrackBar.TabIndex = 1;
            this.OffsetXTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.OffsetXTrackBar.Scroll += new System.EventHandler(this.OffsetXTrackBar_Scroll);
            // 
            // OffsetYTrackBar
            // 
            this.OffsetYTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.OffsetYTrackBar.Location = new System.Drawing.Point(1310, 180);
            this.OffsetYTrackBar.Maximum = 10000;
            this.OffsetYTrackBar.Minimum = -10000;
            this.OffsetYTrackBar.Name = "OffsetYTrackBar";
            this.OffsetYTrackBar.Size = new System.Drawing.Size(176, 45);
            this.OffsetYTrackBar.TabIndex = 2;
            this.OffsetYTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.OffsetYTrackBar.Scroll += new System.EventHandler(this.OffsetYTrackBar_Scroll);
            // 
            // FovTrackBar
            // 
            this.FovTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.FovTrackBar.Location = new System.Drawing.Point(1309, 114);
            this.FovTrackBar.Maximum = 10000;
            this.FovTrackBar.Minimum = 1;
            this.FovTrackBar.Name = "FovTrackBar";
            this.FovTrackBar.Size = new System.Drawing.Size(176, 45);
            this.FovTrackBar.TabIndex = 3;
            this.FovTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.FovTrackBar.Value = 1000;
            this.FovTrackBar.Scroll += new System.EventHandler(this.FovTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1314, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Viewport Offset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1314, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Camera Focal Length";
            // 
            // WorldTranslationXTextBox
            // 
            this.WorldTranslationXTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.WorldTranslationXTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorldTranslationXTextBox.ForeColor = System.Drawing.Color.White;
            this.WorldTranslationXTextBox.Location = new System.Drawing.Point(1331, 29);
            this.WorldTranslationXTextBox.Name = "WorldTranslationXTextBox";
            this.WorldTranslationXTextBox.Size = new System.Drawing.Size(33, 20);
            this.WorldTranslationXTextBox.TabIndex = 16;
            this.WorldTranslationXTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1313, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "World Translation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1314, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1365, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Y:";
            // 
            // WorldTranslationYTextBox
            // 
            this.WorldTranslationYTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.WorldTranslationYTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorldTranslationYTextBox.ForeColor = System.Drawing.Color.White;
            this.WorldTranslationYTextBox.Location = new System.Drawing.Point(1382, 29);
            this.WorldTranslationYTextBox.Name = "WorldTranslationYTextBox";
            this.WorldTranslationYTextBox.Size = new System.Drawing.Size(33, 20);
            this.WorldTranslationYTextBox.TabIndex = 21;
            this.WorldTranslationYTextBox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1417, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Z:";
            // 
            // WorldTranslationZTextBox
            // 
            this.WorldTranslationZTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.WorldTranslationZTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorldTranslationZTextBox.ForeColor = System.Drawing.Color.White;
            this.WorldTranslationZTextBox.Location = new System.Drawing.Point(1434, 29);
            this.WorldTranslationZTextBox.Name = "WorldTranslationZTextBox";
            this.WorldTranslationZTextBox.Size = new System.Drawing.Size(33, 20);
            this.WorldTranslationZTextBox.TabIndex = 23;
            this.WorldTranslationZTextBox.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1417, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Z:";
            // 
            // WorldRotationZTextBox
            // 
            this.WorldRotationZTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.WorldRotationZTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorldRotationZTextBox.ForeColor = System.Drawing.Color.White;
            this.WorldRotationZTextBox.Location = new System.Drawing.Point(1434, 72);
            this.WorldRotationZTextBox.Name = "WorldRotationZTextBox";
            this.WorldRotationZTextBox.Size = new System.Drawing.Size(33, 20);
            this.WorldRotationZTextBox.TabIndex = 30;
            this.WorldRotationZTextBox.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1365, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Y:";
            // 
            // WorldRotationYTextBox
            // 
            this.WorldRotationYTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.WorldRotationYTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorldRotationYTextBox.ForeColor = System.Drawing.Color.White;
            this.WorldRotationYTextBox.Location = new System.Drawing.Point(1382, 72);
            this.WorldRotationYTextBox.Name = "WorldRotationYTextBox";
            this.WorldRotationYTextBox.Size = new System.Drawing.Size(33, 20);
            this.WorldRotationYTextBox.TabIndex = 28;
            this.WorldRotationYTextBox.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1314, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "X:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1313, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "World Rotation";
            // 
            // WorldRotationXTextBox
            // 
            this.WorldRotationXTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.WorldRotationXTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WorldRotationXTextBox.ForeColor = System.Drawing.Color.White;
            this.WorldRotationXTextBox.Location = new System.Drawing.Point(1331, 72);
            this.WorldRotationXTextBox.Name = "WorldRotationXTextBox";
            this.WorldRotationXTextBox.Size = new System.Drawing.Size(33, 20);
            this.WorldRotationXTextBox.TabIndex = 25;
            this.WorldRotationXTextBox.Text = "0";
            // 
            // DrawPointsCheckBox
            // 
            this.DrawPointsCheckBox.AutoSize = true;
            this.DrawPointsCheckBox.Checked = true;
            this.DrawPointsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DrawPointsCheckBox.ForeColor = System.Drawing.Color.White;
            this.DrawPointsCheckBox.Location = new System.Drawing.Point(1316, 204);
            this.DrawPointsCheckBox.Name = "DrawPointsCheckBox";
            this.DrawPointsCheckBox.Size = new System.Drawing.Size(83, 17);
            this.DrawPointsCheckBox.TabIndex = 32;
            this.DrawPointsCheckBox.Text = "Draw Points";
            this.DrawPointsCheckBox.UseVisualStyleBackColor = true;
            this.DrawPointsCheckBox.CheckedChanged += new System.EventHandler(this.DrawPointsCheckBox_CheckedChanged);
            // 
            // DrawLinesCheckBox
            // 
            this.DrawLinesCheckBox.AutoSize = true;
            this.DrawLinesCheckBox.ForeColor = System.Drawing.Color.White;
            this.DrawLinesCheckBox.Location = new System.Drawing.Point(1316, 222);
            this.DrawLinesCheckBox.Name = "DrawLinesCheckBox";
            this.DrawLinesCheckBox.Size = new System.Drawing.Size(79, 17);
            this.DrawLinesCheckBox.TabIndex = 33;
            this.DrawLinesCheckBox.Text = "Draw Lines";
            this.DrawLinesCheckBox.UseVisualStyleBackColor = true;
            this.DrawLinesCheckBox.CheckedChanged += new System.EventHandler(this.DrawLinesCheckBox_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1492, 584);
            this.Controls.Add(this.DrawLinesCheckBox);
            this.Controls.Add(this.DrawPointsCheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WorldRotationZTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.WorldRotationYTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.WorldRotationXTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WorldTranslationZTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WorldTranslationYTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WorldTranslationXTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FovTrackBar);
            this.Controls.Add(this.OffsetYTrackBar);
            this.Controls.Add(this.OffsetXTrackBar);
            this.Controls.Add(this.RenderPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.Text = "Simple3DRenderer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.RenderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetXTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetYTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RenderPictureBox;
        private System.Windows.Forms.TrackBar OffsetXTrackBar;
        private System.Windows.Forms.TrackBar OffsetYTrackBar;
        private System.Windows.Forms.TrackBar FovTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WorldTranslationXTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WorldTranslationYTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox WorldTranslationZTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WorldRotationZTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox WorldRotationYTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox WorldRotationXTextBox;
        private System.Windows.Forms.CheckBox DrawPointsCheckBox;
        private System.Windows.Forms.CheckBox DrawLinesCheckBox;
    }
}

