namespace TheWinFormsChronicles;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        constitution = new NumericUpDown();
        dexterity = new NumericUpDown();
        weaponSkill = new NumericUpDown();
        forcePower = new NumericUpDown();
        blasterPower = new NumericUpDown();
        pointsLeft = new TextBox();
        charCreate = new Button();
        ((System.ComponentModel.ISupportInitialize)constitution).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dexterity).BeginInit();
        ((System.ComponentModel.ISupportInitialize)weaponSkill).BeginInit();
        ((System.ComponentModel.ISupportInitialize)forcePower).BeginInit();
        ((System.ComponentModel.ISupportInitialize)blasterPower).BeginInit();
        SuspendLayout();
        // 
        // constitution
        // 
        constitution.Location = new Point(1246, 30);
        constitution.Name = "constitution";
        constitution.Size = new Size(180, 31);
        constitution.TabIndex = 0;
        // 
        // dexterity
        // 
        dexterity.Location = new Point(1246, 70);
        dexterity.Name = "dexterity";
        dexterity.Size = new Size(180, 31);
        dexterity.TabIndex = 1;
        // 
        // weaponSkill
        // 
        weaponSkill.Location = new Point(1246, 110);
        weaponSkill.Name = "weaponSkill";
        weaponSkill.Size = new Size(180, 31);
        weaponSkill.TabIndex = 2;
        // 
        // forcePower
        // 
        forcePower.Location = new Point(1246, 150);
        forcePower.Name = "forcePower";
        forcePower.Size = new Size(180, 31);
        forcePower.TabIndex = 3;
        // 
        // blasterPower
        // 
        blasterPower.Location = new Point(1246, 190);
        blasterPower.Name = "blasterPower";
        blasterPower.Size = new Size(180, 31);
        blasterPower.TabIndex = 4;
        // 
        // pointsLeft
        // 
        pointsLeft.Location = new Point(1011, 70);
        pointsLeft.Name = "pointsLeft";
        pointsLeft.ReadOnly = true;
        pointsLeft.Size = new Size(150, 31);
        pointsLeft.TabIndex = 5;
        pointsLeft.Text = "Points Left: 0";
        // 
        // charCreate
        // 
        charCreate.Location = new Point(1049, 122);
        charCreate.Name = "charCreate";
        charCreate.Size = new Size(112, 34);
        charCreate.TabIndex = 6;
        charCreate.Text = "Create";
        charCreate.UseVisualStyleBackColor = true;
        charCreate.Click += charCreate_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1455, 680);
        Controls.Add(charCreate);
        Controls.Add(pointsLeft);
        Controls.Add(blasterPower);
        Controls.Add(forcePower);
        Controls.Add(weaponSkill);
        Controls.Add(dexterity);
        Controls.Add(constitution);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)constitution).EndInit();
        ((System.ComponentModel.ISupportInitialize)dexterity).EndInit();
        ((System.ComponentModel.ISupportInitialize)weaponSkill).EndInit();
        ((System.ComponentModel.ISupportInitialize)forcePower).EndInit();
        ((System.ComponentModel.ISupportInitialize)blasterPower).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private NumericUpDown constitution;
    private NumericUpDown dexterity;
    private NumericUpDown weaponSkill;
    private NumericUpDown forcePower;
    private NumericUpDown blasterPower;
    private TextBox pointsLeft;
    private Button charCreate;
}
