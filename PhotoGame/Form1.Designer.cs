
namespace Thema1
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
            this.label1 = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.play_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.top3_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.username_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(452, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memory Game";
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(138, 15);
            this.username_textbox.MaxLength = 15;
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(192, 33);
            this.username_textbox.TabIndex = 1;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.BackColor = System.Drawing.Color.Transparent;
            this.username_label.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.username_label.Location = new System.Drawing.Point(3, 15);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(131, 33);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "Username";
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.play_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_button.Location = new System.Drawing.Point(72, 68);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(90, 23);
            this.play_button.TabIndex = 3;
            this.play_button.Text = "Play !";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(427, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 4);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(427, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 4);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(427, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 177);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(803, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 177);
            this.panel4.TabIndex = 7;
            // 
            // top3_button
            // 
            this.top3_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.top3_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top3_button.Location = new System.Drawing.Point(184, 68);
            this.top3_button.Name = "top3_button";
            this.top3_button.Size = new System.Drawing.Size(93, 23);
            this.top3_button.TabIndex = 14;
            this.top3_button.Text = "Leaderboard ";
            this.top3_button.UseVisualStyleBackColor = false;
            this.top3_button.Click += new System.EventHandler(this.top3_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Thema1.Properties.Resources.exit3;
            this.pictureBox2.Location = new System.Drawing.Point(1218, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Thema1.Properties.Resources.brands;
            this.pictureBox3.Location = new System.Drawing.Point(38, 295);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(135, 115);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Thema1.Properties.Resources.brain;
            this.pictureBox1.Location = new System.Drawing.Point(938, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // username_panel
            // 
            this.username_panel.BackColor = System.Drawing.Color.Transparent;
            this.username_panel.Controls.Add(this.username_label);
            this.username_panel.Controls.Add(this.username_textbox);
            this.username_panel.Controls.Add(this.top3_button);
            this.username_panel.Controls.Add(this.play_button);
            this.username_panel.Location = new System.Drawing.Point(450, 268);
            this.username_panel.Name = "username_panel";
            this.username_panel.Size = new System.Drawing.Size(347, 114);
            this.username_panel.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = global::Thema1.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.username_panel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.username_panel.ResumeLayout(false);
            this.username_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button top3_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel username_panel;
    }
}

