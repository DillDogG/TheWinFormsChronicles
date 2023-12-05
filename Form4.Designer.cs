namespace TheWinFormsChronicles
{
    partial class Form4
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
            conUp = new Button();
            weapUp = new Button();
            dexUp = new Button();
            forUp = new Button();
            charUp = new Button();
            blastUp = new Button();
            textBox1 = new TextBox();
            conDisp = new TextBox();
            dexDisp = new TextBox();
            charDisp = new TextBox();
            weapDisp = new TextBox();
            forceDisp = new TextBox();
            blastDisp = new TextBox();
            SuspendLayout();
            // 
            // conUp
            // 
            conUp.Location = new Point(93, 100);
            conUp.Name = "conUp";
            conUp.Size = new Size(112, 34);
            conUp.TabIndex = 0;
            conUp.Text = "Increase";
            conUp.UseVisualStyleBackColor = true;
            conUp.Click += conUp_Click;
            // 
            // weapUp
            // 
            weapUp.Location = new Point(591, 100);
            weapUp.Name = "weapUp";
            weapUp.Size = new Size(112, 34);
            weapUp.TabIndex = 1;
            weapUp.Text = "Increase";
            weapUp.UseVisualStyleBackColor = true;
            weapUp.Click += weapUp_Click;
            // 
            // dexUp
            // 
            dexUp.Location = new Point(93, 203);
            dexUp.Name = "dexUp";
            dexUp.Size = new Size(112, 34);
            dexUp.TabIndex = 2;
            dexUp.Text = "Increase";
            dexUp.UseVisualStyleBackColor = true;
            dexUp.Click += dexUp_Click;
            // 
            // forUp
            // 
            forUp.Location = new Point(591, 203);
            forUp.Name = "forUp";
            forUp.Size = new Size(112, 34);
            forUp.TabIndex = 3;
            forUp.Text = "Increase";
            forUp.UseVisualStyleBackColor = true;
            forUp.Click += forUp_Click;
            // 
            // charUp
            // 
            charUp.Location = new Point(93, 317);
            charUp.Name = "charUp";
            charUp.Size = new Size(112, 34);
            charUp.TabIndex = 4;
            charUp.Text = "Increase";
            charUp.UseVisualStyleBackColor = true;
            charUp.Click += charUp_Click;
            // 
            // blastUp
            // 
            blastUp.Location = new Point(591, 317);
            blastUp.Name = "blastUp";
            blastUp.Size = new Size(112, 34);
            blastUp.TabIndex = 5;
            blastUp.Text = "Increase";
            blastUp.UseVisualStyleBackColor = true;
            blastUp.Click += blastUp_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 52);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(189, 60);
            textBox1.TabIndex = 6;
            textBox1.Text = "Increase Your Stats. Points Left: 2";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // conDisp
            // 
            conDisp.Location = new Point(73, 63);
            conDisp.Name = "conDisp";
            conDisp.ReadOnly = true;
            conDisp.Size = new Size(150, 31);
            conDisp.TabIndex = 7;
            conDisp.Text = "Constitution: ";
            // 
            // dexDisp
            // 
            dexDisp.Location = new Point(73, 166);
            dexDisp.Name = "dexDisp";
            dexDisp.ReadOnly = true;
            dexDisp.Size = new Size(150, 31);
            dexDisp.TabIndex = 8;
            dexDisp.Text = "Dexterity: ";
            // 
            // charDisp
            // 
            charDisp.Location = new Point(73, 280);
            charDisp.Name = "charDisp";
            charDisp.ReadOnly = true;
            charDisp.Size = new Size(150, 31);
            charDisp.TabIndex = 9;
            charDisp.Text = "Charisma: ";
            // 
            // weapDisp
            // 
            weapDisp.Location = new Point(569, 63);
            weapDisp.Name = "weapDisp";
            weapDisp.ReadOnly = true;
            weapDisp.Size = new Size(150, 31);
            weapDisp.TabIndex = 10;
            weapDisp.Text = "Weapon Power: ";
            // 
            // forceDisp
            // 
            forceDisp.Location = new Point(569, 166);
            forceDisp.Name = "forceDisp";
            forceDisp.ReadOnly = true;
            forceDisp.Size = new Size(150, 31);
            forceDisp.TabIndex = 11;
            forceDisp.Text = "Force Power: ";
            // 
            // blastDisp
            // 
            blastDisp.Location = new Point(569, 280);
            blastDisp.Name = "blastDisp";
            blastDisp.ReadOnly = true;
            blastDisp.Size = new Size(150, 31);
            blastDisp.TabIndex = 12;
            blastDisp.Text = "Blaster Power: ";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(blastDisp);
            Controls.Add(forceDisp);
            Controls.Add(weapDisp);
            Controls.Add(charDisp);
            Controls.Add(dexDisp);
            Controls.Add(conDisp);
            Controls.Add(textBox1);
            Controls.Add(blastUp);
            Controls.Add(charUp);
            Controls.Add(forUp);
            Controls.Add(dexUp);
            Controls.Add(weapUp);
            Controls.Add(conUp);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button conUp;
        private Button weapUp;
        private Button dexUp;
        private Button forUp;
        private Button charUp;
        private Button blastUp;
        private TextBox textBox1;
        private TextBox conDisp;
        private TextBox dexDisp;
        private TextBox charDisp;
        private TextBox weapDisp;
        private TextBox forceDisp;
        private TextBox blastDisp;
    }
}