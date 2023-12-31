﻿namespace GameLogic
{
    partial class Form3
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            charDisp = new Button();
            Attack = new Button();
            Shoot = new Button();
            Defend = new Button();
            Move1 = new Button();
            Move2 = new Button();
            Move3 = new Button();
            Move6 = new Button();
            Move5 = new Button();
            Move4 = new Button();
            WeapSkill = new Button();
            forcePush = new Button();
            phpDisp = new TextBox();
            ehpDisp = new TextBox();
            description = new TextBox();
            forcePull = new Button();
            fChoke = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.PlayerCharacterWinFormChronicles;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(100, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(350, 185);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(201, 200);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(850, 185);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(201, 200);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(600, 185);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(201, 200);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Location = new Point(1350, 185);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(201, 200);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(1100, 185);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(201, 200);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // charDisp
            // 
            charDisp.Location = new Point(627, 620);
            charDisp.Name = "charDisp";
            charDisp.Size = new Size(149, 33);
            charDisp.TabIndex = 6;
            charDisp.Text = "View Character";
            charDisp.UseVisualStyleBackColor = true;
            charDisp.Click += charDisp_Click;
            // 
            // Attack
            // 
            Attack.Location = new Point(644, 428);
            Attack.Name = "Attack";
            Attack.Size = new Size(111, 33);
            Attack.TabIndex = 7;
            Attack.Text = "Attack";
            Attack.UseVisualStyleBackColor = true;
            Attack.Click += Attack_Click;
            // 
            // Shoot
            // 
            Shoot.Location = new Point(894, 428);
            Shoot.Name = "Shoot";
            Shoot.Size = new Size(111, 33);
            Shoot.TabIndex = 8;
            Shoot.Text = "Shoot";
            Shoot.UseVisualStyleBackColor = true;
            Shoot.Click += Shoot_Click;
            // 
            // Defend
            // 
            Defend.Location = new Point(644, 478);
            Defend.Name = "Defend";
            Defend.Size = new Size(111, 33);
            Defend.TabIndex = 9;
            Defend.Text = "Defend";
            Defend.UseVisualStyleBackColor = true;
            Defend.Click += Defend_Click;
            // 
            // Move1
            // 
            Move1.Enabled = false;
            Move1.Location = new Point(150, 125);
            Move1.Name = "Move1";
            Move1.Size = new Size(111, 33);
            Move1.TabIndex = 11;
            Move1.Text = "Move Here";
            Move1.UseVisualStyleBackColor = true;
            Move1.Click += Move1_Click;
            // 
            // Move2
            // 
            Move2.Location = new Point(400, 125);
            Move2.Name = "Move2";
            Move2.Size = new Size(111, 33);
            Move2.TabIndex = 12;
            Move2.Text = "Move Here";
            Move2.UseVisualStyleBackColor = true;
            Move2.Click += Move2_Click;
            // 
            // Move3
            // 
            Move3.Enabled = false;
            Move3.Location = new Point(650, 125);
            Move3.Name = "Move3";
            Move3.Size = new Size(111, 33);
            Move3.TabIndex = 13;
            Move3.Text = "Move Here";
            Move3.UseVisualStyleBackColor = true;
            Move3.Click += Move3_Click;
            // 
            // Move6
            // 
            Move6.Enabled = false;
            Move6.Location = new Point(1394, 125);
            Move6.Name = "Move6";
            Move6.Size = new Size(111, 33);
            Move6.TabIndex = 16;
            Move6.Text = "Move Here";
            Move6.UseVisualStyleBackColor = true;
            Move6.Click += Move6_Click;
            // 
            // Move5
            // 
            Move5.Enabled = false;
            Move5.Location = new Point(1144, 125);
            Move5.Name = "Move5";
            Move5.Size = new Size(111, 33);
            Move5.TabIndex = 15;
            Move5.Text = "Move Here";
            Move5.UseVisualStyleBackColor = true;
            Move5.Click += Move5_Click;
            // 
            // Move4
            // 
            Move4.Enabled = false;
            Move4.Location = new Point(894, 125);
            Move4.Name = "Move4";
            Move4.Size = new Size(111, 33);
            Move4.TabIndex = 14;
            Move4.Text = "Move Here";
            Move4.UseVisualStyleBackColor = true;
            Move4.Click += Move4_Click;
            // 
            // WeapSkill
            // 
            WeapSkill.Location = new Point(875, 620);
            WeapSkill.Name = "WeapSkill";
            WeapSkill.Size = new Size(155, 33);
            WeapSkill.TabIndex = 18;
            WeapSkill.Text = "Stunning Strike";
            WeapSkill.UseVisualStyleBackColor = true;
            WeapSkill.Click += WeapSkill_Click;
            // 
            // forcePush
            // 
            forcePush.Location = new Point(644, 538);
            forcePush.Name = "forcePush";
            forcePush.Size = new Size(111, 33);
            forcePush.TabIndex = 17;
            forcePush.Text = "Force Push";
            forcePush.UseVisualStyleBackColor = true;
            forcePush.Click += forcePush_Click;
            // 
            // phpDisp
            // 
            phpDisp.Location = new Point(350, 428);
            phpDisp.Name = "phpDisp";
            phpDisp.ReadOnly = true;
            phpDisp.Size = new Size(201, 31);
            phpDisp.TabIndex = 19;
            phpDisp.Text = "Health: ";
            phpDisp.TextAlign = HorizontalAlignment.Center;
            // 
            // ehpDisp
            // 
            ehpDisp.Location = new Point(1100, 428);
            ehpDisp.Name = "ehpDisp";
            ehpDisp.ReadOnly = true;
            ehpDisp.Size = new Size(201, 31);
            ehpDisp.TabIndex = 20;
            ehpDisp.Text = "Enemy Health: ";
            ehpDisp.TextAlign = HorizontalAlignment.Center;
            // 
            // description
            // 
            description.Location = new Point(600, 12);
            description.Multiline = true;
            description.Name = "description";
            description.ReadOnly = true;
            description.Size = new Size(451, 91);
            description.TabIndex = 21;
            description.Text = "Started Combat with an enemy";
            description.TextAlign = HorizontalAlignment.Center;
            // 
            // forcePull
            // 
            forcePull.Location = new Point(901, 537);
            forcePull.Name = "forcePull";
            forcePull.Size = new Size(112, 34);
            forcePull.TabIndex = 22;
            forcePull.Text = "Force Pull";
            forcePull.UseVisualStyleBackColor = true;
            forcePull.Click += forcePull_Click;
            // 
            // fChoke
            // 
            fChoke.Location = new Point(894, 478);
            fChoke.Name = "fChoke";
            fChoke.Size = new Size(119, 34);
            fChoke.TabIndex = 23;
            fChoke.Text = "Force Choke";
            fChoke.UseVisualStyleBackColor = true;
            fChoke.Click += fChoke_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1679, 763);
            Controls.Add(fChoke);
            Controls.Add(forcePull);
            Controls.Add(description);
            Controls.Add(ehpDisp);
            Controls.Add(phpDisp);
            Controls.Add(WeapSkill);
            Controls.Add(forcePush);
            Controls.Add(Move6);
            Controls.Add(Move5);
            Controls.Add(Move4);
            Controls.Add(Move3);
            Controls.Add(Move2);
            Controls.Add(Move1);
            Controls.Add(Defend);
            Controls.Add(Shoot);
            Controls.Add(Attack);
            Controls.Add(charDisp);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Button charDisp;
        private Button Attack;
        private Button Shoot;
        private Button Defend;
        private Button Move1;
        private Button Move2;
        private Button Move3;
        private Button Move6;
        private Button Move5;
        private Button Move4;
        private Button WeapSkill;
        private Button forcePush;
        private TextBox phpDisp;
        private TextBox ehpDisp;
        private TextBox description;
        private Button forcePull;
        private Button fChoke;
    }
}