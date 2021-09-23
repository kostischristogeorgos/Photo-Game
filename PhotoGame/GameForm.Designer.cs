
namespace Thema1
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.welcome_label = new System.Windows.Forms.Label();
            this.tries_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.end_game_panel = new System.Windows.Forms.Panel();
            this.return_button = new System.Windows.Forms.Button();
            this.end_game_time = new System.Windows.Forms.Label();
            this.end_game_tries = new System.Windows.Forms.Label();
            this.end_game_username = new System.Windows.Forms.Label();
            this.addpic_panel = new System.Windows.Forms.Panel();
            this.no_button = new System.Windows.Forms.Button();
            this.yes_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_picturebox = new System.Windows.Forms.PictureBox();
            this.Freeze_picture_timer = new System.Windows.Forms.Timer(this.components);
            this.pic_panel = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.temp_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.end_game_panel.SuspendLayout();
            this.addpic_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picturebox)).BeginInit();
            this.pic_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temp_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_label.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.welcome_label.Location = new System.Drawing.Point(511, 9);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(213, 33);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome Player !";
            // 
            // tries_label
            // 
            this.tries_label.AutoSize = true;
            this.tries_label.BackColor = System.Drawing.Color.Transparent;
            this.tries_label.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tries_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tries_label.Location = new System.Drawing.Point(74, 9);
            this.tries_label.Name = "tries_label";
            this.tries_label.Size = new System.Drawing.Size(76, 33);
            this.tries_label.TabIndex = 1;
            this.tries_label.Text = "Tries:";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.Color.Transparent;
            this.time_label.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.time_label.Location = new System.Drawing.Point(1072, 9);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(84, 33);
            this.time_label.TabIndex = 2;
            this.time_label.Text = "Time: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Thema1.Properties.Resources.questionmark1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Thema1.Properties.Resources.questionmark1;
            this.pictureBox2.Location = new System.Drawing.Point(168, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Thema1.Properties.Resources.questionmark1;
            this.pictureBox3.Location = new System.Drawing.Point(333, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Thema1.Properties.Resources.questionmark1;
            this.pictureBox4.Location = new System.Drawing.Point(496, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 130);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Thema1.Properties.Resources.questionmark1;
            this.pictureBox5.Location = new System.Drawing.Point(655, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(120, 130);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Thema1.Properties.Resources.questionmark1;
            this.pictureBox6.Location = new System.Drawing.Point(3, 168);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(120, 130);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Thema1.Properties.Resources.questionmark1;
            this.pictureBox7.Location = new System.Drawing.Point(168, 168);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(120, 130);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Thema1.Properties.Resources.questionmark1;
            this.pictureBox8.Location = new System.Drawing.Point(496, 168);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(120, 130);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::Thema1.Properties.Resources.questionmark1;
            this.pictureBox9.Location = new System.Drawing.Point(335, 168);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(120, 130);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 12;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::Thema1.Properties.Resources.questionmark1;
            this.pictureBox10.Location = new System.Drawing.Point(655, 168);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(120, 130);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 13;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // end_game_panel
            // 
            this.end_game_panel.BackColor = System.Drawing.Color.Transparent;
            this.end_game_panel.Controls.Add(this.return_button);
            this.end_game_panel.Controls.Add(this.end_game_time);
            this.end_game_panel.Controls.Add(this.end_game_tries);
            this.end_game_panel.Controls.Add(this.end_game_username);
            this.end_game_panel.Location = new System.Drawing.Point(223, 73);
            this.end_game_panel.Name = "end_game_panel";
            this.end_game_panel.Size = new System.Drawing.Size(576, 165);
            this.end_game_panel.TabIndex = 14;
            // 
            // return_button
            // 
            this.return_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.return_button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_button.Location = new System.Drawing.Point(118, 139);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(112, 23);
            this.return_button.TabIndex = 16;
            this.return_button.Text = "Return To Menu";
            this.return_button.UseVisualStyleBackColor = false;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // end_game_time
            // 
            this.end_game_time.AutoSize = true;
            this.end_game_time.BackColor = System.Drawing.Color.Transparent;
            this.end_game_time.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_game_time.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.end_game_time.Location = new System.Drawing.Point(73, 93);
            this.end_game_time.Name = "end_game_time";
            this.end_game_time.Size = new System.Drawing.Size(84, 33);
            this.end_game_time.TabIndex = 15;
            this.end_game_time.Text = "Time: ";
            // 
            // end_game_tries
            // 
            this.end_game_tries.AutoSize = true;
            this.end_game_tries.BackColor = System.Drawing.Color.Transparent;
            this.end_game_tries.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_game_tries.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.end_game_tries.Location = new System.Drawing.Point(73, 46);
            this.end_game_tries.Name = "end_game_tries";
            this.end_game_tries.Size = new System.Drawing.Size(76, 33);
            this.end_game_tries.TabIndex = 15;
            this.end_game_tries.Text = "Tries:";
            // 
            // end_game_username
            // 
            this.end_game_username.AutoSize = true;
            this.end_game_username.BackColor = System.Drawing.Color.Transparent;
            this.end_game_username.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_game_username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.end_game_username.Location = new System.Drawing.Point(73, 0);
            this.end_game_username.Name = "end_game_username";
            this.end_game_username.Size = new System.Drawing.Size(284, 33);
            this.end_game_username.TabIndex = 1;
            this.end_game_username.Text = "Congratulations Player !";
            // 
            // addpic_panel
            // 
            this.addpic_panel.BackColor = System.Drawing.Color.Transparent;
            this.addpic_panel.Controls.Add(this.no_button);
            this.addpic_panel.Controls.Add(this.yes_button);
            this.addpic_panel.Controls.Add(this.label1);
            this.addpic_panel.Location = new System.Drawing.Point(448, 160);
            this.addpic_panel.Name = "addpic_panel";
            this.addpic_panel.Size = new System.Drawing.Size(365, 100);
            this.addpic_panel.TabIndex = 16;
            // 
            // no_button
            // 
            this.no_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.no_button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_button.Location = new System.Drawing.Point(192, 74);
            this.no_button.Name = "no_button";
            this.no_button.Size = new System.Drawing.Size(65, 23);
            this.no_button.TabIndex = 18;
            this.no_button.Text = "No";
            this.no_button.UseVisualStyleBackColor = false;
            this.no_button.Click += new System.EventHandler(this.no_button_Click);
            // 
            // yes_button
            // 
            this.yes_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.yes_button.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_button.Location = new System.Drawing.Point(94, 74);
            this.yes_button.Name = "yes_button";
            this.yes_button.Size = new System.Drawing.Size(65, 23);
            this.yes_button.TabIndex = 17;
            this.yes_button.Text = "Yes";
            this.yes_button.UseVisualStyleBackColor = false;
            this.yes_button.Click += new System.EventHandler(this.yes_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Do you want to add a Picture?";
            // 
            // exit_picturebox
            // 
            this.exit_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.exit_picturebox.Image = global::Thema1.Properties.Resources.exit3;
            this.exit_picturebox.Location = new System.Drawing.Point(587, 570);
            this.exit_picturebox.Name = "exit_picturebox";
            this.exit_picturebox.Size = new System.Drawing.Size(48, 50);
            this.exit_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit_picturebox.TabIndex = 15;
            this.exit_picturebox.TabStop = false;
            this.exit_picturebox.Click += new System.EventHandler(this.exit_picturebox_Click);
            // 
            // Freeze_picture_timer
            // 
            this.Freeze_picture_timer.Interval = 400;
            this.Freeze_picture_timer.Tick += new System.EventHandler(this.Freeze_picture_timer_Tick);
            // 
            // pic_panel
            // 
            this.pic_panel.BackColor = System.Drawing.Color.Transparent;
            this.pic_panel.Controls.Add(this.pictureBox1);
            this.pic_panel.Controls.Add(this.pictureBox2);
            this.pic_panel.Controls.Add(this.pictureBox3);
            this.pic_panel.Controls.Add(this.end_game_panel);
            this.pic_panel.Controls.Add(this.pictureBox4);
            this.pic_panel.Controls.Add(this.pictureBox10);
            this.pic_panel.Controls.Add(this.pictureBox5);
            this.pic_panel.Controls.Add(this.pictureBox9);
            this.pic_panel.Controls.Add(this.pictureBox6);
            this.pic_panel.Controls.Add(this.pictureBox8);
            this.pic_panel.Controls.Add(this.pictureBox7);
            this.pic_panel.Location = new System.Drawing.Point(222, 177);
            this.pic_panel.Name = "pic_panel";
            this.pic_panel.Size = new System.Drawing.Size(815, 317);
            this.pic_panel.TabIndex = 17;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            // 
            // temp_pictureBox
            // 
            this.temp_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.temp_pictureBox.Location = new System.Drawing.Point(31, 177);
            this.temp_pictureBox.Name = "temp_pictureBox";
            this.temp_pictureBox.Size = new System.Drawing.Size(100, 50);
            this.temp_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.temp_pictureBox.TabIndex = 18;
            this.temp_pictureBox.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thema1.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1300, 652);
            this.Controls.Add(this.temp_pictureBox);
            this.Controls.Add(this.pic_panel);
            this.Controls.Add(this.addpic_panel);
            this.Controls.Add(this.exit_picturebox);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.tries_label);
            this.Controls.Add(this.welcome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.end_game_panel.ResumeLayout(false);
            this.end_game_panel.PerformLayout();
            this.addpic_panel.ResumeLayout(false);
            this.addpic_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picturebox)).EndInit();
            this.pic_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.temp_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label tries_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel end_game_panel;
        private System.Windows.Forms.Label end_game_time;
        private System.Windows.Forms.Label end_game_tries;
        private System.Windows.Forms.Label end_game_username;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.PictureBox exit_picturebox;
        private System.Windows.Forms.Timer Freeze_picture_timer;
        private System.Windows.Forms.Panel addpic_panel;
        private System.Windows.Forms.Button no_button;
        private System.Windows.Forms.Button yes_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pic_panel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox temp_pictureBox;
    }
}