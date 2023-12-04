namespace GMap_Control
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.active_mouse_click = new System.Windows.Forms.Button();
            this.activate_drag = new System.Windows.Forms.Button();
            this.change_zoom = new System.Windows.Forms.Button();
            this.zoom_level = new System.Windows.Forms.TextBox();
            this.longitude = new System.Windows.Forms.TextBox();
            this.latitude = new System.Windows.Forms.TextBox();
            this.go_Coordinate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.active_mouse_click);
            this.splitContainer1.Panel1.Controls.Add(this.activate_drag);
            this.splitContainer1.Panel1.Controls.Add(this.change_zoom);
            this.splitContainer1.Panel1.Controls.Add(this.zoom_level);
            this.splitContainer1.Panel1.Controls.Add(this.longitude);
            this.splitContainer1.Panel1.Controls.Add(this.latitude);
            this.splitContainer1.Panel1.Controls.Add(this.go_Coordinate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(776, 512);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(94, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 47);
            this.button4.TabIndex = 9;
            this.button4.Text = "Active Drag";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(94, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 47);
            this.button3.TabIndex = 8;
            this.button3.Text = "Inactive mouse click";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(93, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 0;
            this.button2.Text = "Delete Marker";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coordinates";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(15, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Marker";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // active_mouse_click
            // 
            this.active_mouse_click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.active_mouse_click.Location = new System.Drawing.Point(15, 299);
            this.active_mouse_click.Name = "active_mouse_click";
            this.active_mouse_click.Size = new System.Drawing.Size(71, 47);
            this.active_mouse_click.TabIndex = 6;
            this.active_mouse_click.Text = "Active mouse click";
            this.active_mouse_click.UseVisualStyleBackColor = false;
            this.active_mouse_click.Click += new System.EventHandler(this.active_mouse_click_Click);
            // 
            // activate_drag
            // 
            this.activate_drag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.activate_drag.Location = new System.Drawing.Point(15, 246);
            this.activate_drag.Name = "activate_drag";
            this.activate_drag.Size = new System.Drawing.Size(71, 47);
            this.activate_drag.TabIndex = 5;
            this.activate_drag.Text = "Active Drag";
            this.activate_drag.UseVisualStyleBackColor = false;
            this.activate_drag.Click += new System.EventHandler(this.activate_drag_Click);
            // 
            // change_zoom
            // 
            this.change_zoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.change_zoom.Location = new System.Drawing.Point(93, 178);
            this.change_zoom.Name = "change_zoom";
            this.change_zoom.Size = new System.Drawing.Size(74, 32);
            this.change_zoom.TabIndex = 4;
            this.change_zoom.Text = "Change Zoom Level";
            this.change_zoom.UseVisualStyleBackColor = false;
            this.change_zoom.Click += new System.EventHandler(this.change_zoom_Click);
            // 
            // zoom_level
            // 
            this.zoom_level.BackColor = System.Drawing.SystemColors.Info;
            this.zoom_level.Location = new System.Drawing.Point(15, 178);
            this.zoom_level.Multiline = true;
            this.zoom_level.Name = "zoom_level";
            this.zoom_level.Size = new System.Drawing.Size(71, 32);
            this.zoom_level.TabIndex = 3;
            this.zoom_level.Text = "12";
            this.zoom_level.TextChanged += new System.EventHandler(this.zoom_level_TextChanged);
            // 
            // longitude
            // 
            this.longitude.BackColor = System.Drawing.SystemColors.Info;
            this.longitude.Location = new System.Drawing.Point(53, 57);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(114, 20);
            this.longitude.TabIndex = 2;
            this.longitude.Text = "74.582748";
            // 
            // latitude
            // 
            this.latitude.BackColor = System.Drawing.SystemColors.Info;
            this.latitude.Location = new System.Drawing.Point(53, 31);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(114, 20);
            this.latitude.TabIndex = 1;
            this.latitude.Text = "42.882004";
            // 
            // go_Coordinate
            // 
            this.go_Coordinate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.go_Coordinate.Location = new System.Drawing.Point(53, 83);
            this.go_Coordinate.Name = "go_Coordinate";
            this.go_Coordinate.Size = new System.Drawing.Size(75, 23);
            this.go_Coordinate.TabIndex = 0;
            this.go_Coordinate.Text = "Go To Coordinate";
            this.go_Coordinate.UseVisualStyleBackColor = false;
            this.go_Coordinate.Click += new System.EventHandler(this.go_Coordinate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Long";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 512);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox longitude;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.Button go_Coordinate;
        private System.Windows.Forms.Button change_zoom;
        private System.Windows.Forms.TextBox zoom_level;
        private System.Windows.Forms.Button activate_drag;
        private System.Windows.Forms.Button active_mouse_click;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

