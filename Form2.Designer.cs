namespace TheWinFormsChronicles
{
    partial class Form2
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
            label1 = new Label();
            NPCResponse = new TextBox();
            Option1 = new Button();
            Option2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(636, 137);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 0;
            label1.Text = "Bob Robert Son of Bobert";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // NPCResponse
            // 
            NPCResponse.Location = new Point(402, 186);
            NPCResponse.Name = "NPCResponse";
            NPCResponse.ReadOnly = true;
            NPCResponse.Size = new Size(688, 31);
            NPCResponse.TabIndex = 1;
            NPCResponse.Text = "'ello mate!";
            NPCResponse.TextAlign = HorizontalAlignment.Center;
            // 
            // Option1
            // 
            Option1.Location = new Point(402, 223);
            Option1.Name = "Option1";
            Option1.Size = new Size(688, 34);
            Option1.TabIndex = 2;
            Option1.Text = "How Dare You? (Attack)";
            Option1.UseVisualStyleBackColor = true;
            Option1.Click += Option1_Click;
            // 
            // Option2
            // 
            Option2.Location = new Point(402, 263);
            Option2.Name = "Option2";
            Option2.Size = new Size(688, 34);
            Option2.TabIndex = 3;
            Option2.Text = "Hello There!";
            Option2.UseVisualStyleBackColor = true;
            Option2.Click += Option2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 680);
            Controls.Add(Option2);
            Controls.Add(Option1);
            Controls.Add(NPCResponse);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NPCResponse;
        private Button Option1;
        private Button Option2;
    }
}