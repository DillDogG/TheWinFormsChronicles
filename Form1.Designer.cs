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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        constitutionDisp = new NumericUpDown();
        dexterityDisp = new NumericUpDown();
        weaponSkillDisp = new NumericUpDown();
        forcePowerDisp = new NumericUpDown();
        blasterSkillDisp = new NumericUpDown();
        pointsLeft = new TextBox();
        charCreate = new Button();
        charismaDisp = new NumericUpDown();
        conTell = new TextBox();
        dexTell = new TextBox();
        weapTell = new TextBox();
        forTell = new TextBox();
        blastTell = new TextBox();
        charTell = new TextBox();
        Descriptions = new TextBox();
        textBox1 = new TextBox();
        currWeapon = new TextBox();
        currForceAbilities = new TextBox();
        currBlast = new TextBox();
        lvlDisp = new TextBox();
        hpDisp = new TextBox();
        currWeapAbilities = new TextBox();
        ((System.ComponentModel.ISupportInitialize)constitutionDisp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dexterityDisp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)weaponSkillDisp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)forcePowerDisp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)blasterSkillDisp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)charismaDisp).BeginInit();
        SuspendLayout();
        // 
        // constitutionDisp
        // 
        constitutionDisp.Location = new Point(1330, 30);
        constitutionDisp.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        constitutionDisp.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
        constitutionDisp.Name = "constitutionDisp";
        constitutionDisp.ReadOnly = true;
        constitutionDisp.Size = new Size(90, 31);
        constitutionDisp.TabIndex = 0;
        constitutionDisp.Value = new decimal(new int[] { 8, 0, 0, 0 });
        constitutionDisp.ValueChanged += constitutionDisp_ValueChanged;
        // 
        // dexterityDisp
        // 
        dexterityDisp.Location = new Point(1330, 70);
        dexterityDisp.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        dexterityDisp.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
        dexterityDisp.Name = "dexterityDisp";
        dexterityDisp.ReadOnly = true;
        dexterityDisp.Size = new Size(90, 31);
        dexterityDisp.TabIndex = 1;
        dexterityDisp.Value = new decimal(new int[] { 8, 0, 0, 0 });
        dexterityDisp.ValueChanged += dexterityDisp_ValueChanged;
        // 
        // weaponSkillDisp
        // 
        weaponSkillDisp.Location = new Point(1330, 150);
        weaponSkillDisp.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        weaponSkillDisp.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
        weaponSkillDisp.Name = "weaponSkillDisp";
        weaponSkillDisp.ReadOnly = true;
        weaponSkillDisp.Size = new Size(90, 31);
        weaponSkillDisp.TabIndex = 2;
        weaponSkillDisp.Value = new decimal(new int[] { 8, 0, 0, 0 });
        weaponSkillDisp.ValueChanged += weaponSkillDisp_ValueChanged;
        // 
        // forcePowerDisp
        // 
        forcePowerDisp.Location = new Point(1330, 190);
        forcePowerDisp.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        forcePowerDisp.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
        forcePowerDisp.Name = "forcePowerDisp";
        forcePowerDisp.ReadOnly = true;
        forcePowerDisp.Size = new Size(90, 31);
        forcePowerDisp.TabIndex = 3;
        forcePowerDisp.Value = new decimal(new int[] { 8, 0, 0, 0 });
        forcePowerDisp.ValueChanged += forcePowerDisp_ValueChanged;
        // 
        // blasterSkillDisp
        // 
        blasterSkillDisp.Location = new Point(1330, 230);
        blasterSkillDisp.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        blasterSkillDisp.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
        blasterSkillDisp.Name = "blasterSkillDisp";
        blasterSkillDisp.ReadOnly = true;
        blasterSkillDisp.Size = new Size(90, 31);
        blasterSkillDisp.TabIndex = 4;
        blasterSkillDisp.Value = new decimal(new int[] { 8, 0, 0, 0 });
        blasterSkillDisp.ValueChanged += blasterSkillDisp_ValueChanged;
        // 
        // pointsLeft
        // 
        pointsLeft.Location = new Point(762, 75);
        pointsLeft.Name = "pointsLeft";
        pointsLeft.ReadOnly = true;
        pointsLeft.Size = new Size(372, 31);
        pointsLeft.TabIndex = 5;
        pointsLeft.Text = "Points Left: 27";
        pointsLeft.TextAlign = HorizontalAlignment.Right;
        // 
        // charCreate
        // 
        charCreate.Location = new Point(1023, 115);
        charCreate.Name = "charCreate";
        charCreate.Size = new Size(111, 33);
        charCreate.TabIndex = 6;
        charCreate.Text = "Create";
        charCreate.UseVisualStyleBackColor = true;
        charCreate.Click += charCreate_Click;
        // 
        // charismaDisp
        // 
        charismaDisp.Location = new Point(1330, 110);
        charismaDisp.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        charismaDisp.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
        charismaDisp.Name = "charismaDisp";
        charismaDisp.ReadOnly = true;
        charismaDisp.Size = new Size(90, 31);
        charismaDisp.TabIndex = 7;
        charismaDisp.Value = new decimal(new int[] { 8, 0, 0, 0 });
        charismaDisp.ValueChanged += charismaDisp_ValueChanged;
        // 
        // conTell
        // 
        conTell.Location = new Point(1174, 30);
        conTell.Name = "conTell";
        conTell.ReadOnly = true;
        conTell.Size = new Size(150, 31);
        conTell.TabIndex = 8;
        conTell.Text = "Constitution: ";
        conTell.TextAlign = HorizontalAlignment.Right;
        // 
        // dexTell
        // 
        dexTell.Location = new Point(1174, 70);
        dexTell.Name = "dexTell";
        dexTell.ReadOnly = true;
        dexTell.Size = new Size(150, 31);
        dexTell.TabIndex = 9;
        dexTell.Text = "Dexterity: ";
        dexTell.TextAlign = HorizontalAlignment.Right;
        // 
        // weapTell
        // 
        weapTell.Location = new Point(1174, 150);
        weapTell.Name = "weapTell";
        weapTell.ReadOnly = true;
        weapTell.Size = new Size(150, 31);
        weapTell.TabIndex = 10;
        weapTell.Text = "Weapon Skill: ";
        weapTell.TextAlign = HorizontalAlignment.Right;
        // 
        // forTell
        // 
        forTell.Location = new Point(1174, 190);
        forTell.Name = "forTell";
        forTell.ReadOnly = true;
        forTell.Size = new Size(150, 31);
        forTell.TabIndex = 11;
        forTell.Text = "Force Power: ";
        forTell.TextAlign = HorizontalAlignment.Right;
        // 
        // blastTell
        // 
        blastTell.Location = new Point(1174, 230);
        blastTell.Name = "blastTell";
        blastTell.ReadOnly = true;
        blastTell.Size = new Size(150, 31);
        blastTell.TabIndex = 12;
        blastTell.Text = "Blaster Skill: ";
        blastTell.TextAlign = HorizontalAlignment.Right;
        // 
        // charTell
        // 
        charTell.Location = new Point(1174, 110);
        charTell.Name = "charTell";
        charTell.ReadOnly = true;
        charTell.Size = new Size(150, 31);
        charTell.TabIndex = 13;
        charTell.Text = "Charisma: ";
        charTell.TextAlign = HorizontalAlignment.Right;
        // 
        // Descriptions
        // 
        Descriptions.Location = new Point(12, 12);
        Descriptions.Multiline = true;
        Descriptions.Name = "Descriptions";
        Descriptions.ReadOnly = true;
        Descriptions.Size = new Size(651, 189);
        Descriptions.TabIndex = 15;
        Descriptions.Text = resources.GetString("Descriptions.Text");
        // 
        // textBox1
        // 
        textBox1.Location = new Point(33, 227);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(150, 31);
        textBox1.TabIndex = 16;
        textBox1.Text = "Character Info:";
        // 
        // currWeapon
        // 
        currWeapon.Location = new Point(33, 347);
        currWeapon.Multiline = true;
        currWeapon.Name = "currWeapon";
        currWeapon.ReadOnly = true;
        currWeapon.Size = new Size(630, 31);
        currWeapon.TabIndex = 22;
        currWeapon.Text = "Weapon: Baton";
        // 
        // currForceAbilities
        // 
        currForceAbilities.Location = new Point(33, 427);
        currForceAbilities.Multiline = true;
        currForceAbilities.Name = "currForceAbilities";
        currForceAbilities.ReadOnly = true;
        currForceAbilities.Size = new Size(630, 31);
        currForceAbilities.TabIndex = 21;
        currForceAbilities.Text = "Force Abilities: Grab Object";
        // 
        // currBlast
        // 
        currBlast.Location = new Point(33, 387);
        currBlast.Multiline = true;
        currBlast.Name = "currBlast";
        currBlast.ReadOnly = true;
        currBlast.Size = new Size(630, 31);
        currBlast.TabIndex = 19;
        currBlast.Text = "Blaster: Old Blaster";
        // 
        // lvlDisp
        // 
        lvlDisp.Location = new Point(33, 307);
        lvlDisp.Multiline = true;
        lvlDisp.Name = "lvlDisp";
        lvlDisp.ReadOnly = true;
        lvlDisp.Size = new Size(630, 31);
        lvlDisp.TabIndex = 18;
        lvlDisp.Text = "Level: 1";
        // 
        // hpDisp
        // 
        hpDisp.Location = new Point(33, 267);
        hpDisp.Multiline = true;
        hpDisp.Name = "hpDisp";
        hpDisp.ReadOnly = true;
        hpDisp.Size = new Size(630, 31);
        hpDisp.TabIndex = 17;
        hpDisp.Text = "Health: 13";
        // 
        // currWeapAbilities
        // 
        currWeapAbilities.Location = new Point(33, 467);
        currWeapAbilities.Multiline = true;
        currWeapAbilities.Name = "currWeapAbilities";
        currWeapAbilities.ReadOnly = true;
        currWeapAbilities.Size = new Size(630, 31);
        currWeapAbilities.TabIndex = 23;
        currWeapAbilities.Text = "Weapon Abilities: ";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1454, 529);
        Controls.Add(currWeapAbilities);
        Controls.Add(currWeapon);
        Controls.Add(currForceAbilities);
        Controls.Add(currBlast);
        Controls.Add(lvlDisp);
        Controls.Add(hpDisp);
        Controls.Add(textBox1);
        Controls.Add(Descriptions);
        Controls.Add(charTell);
        Controls.Add(blastTell);
        Controls.Add(forTell);
        Controls.Add(weapTell);
        Controls.Add(dexTell);
        Controls.Add(conTell);
        Controls.Add(charismaDisp);
        Controls.Add(charCreate);
        Controls.Add(pointsLeft);
        Controls.Add(blasterSkillDisp);
        Controls.Add(forcePowerDisp);
        Controls.Add(weaponSkillDisp);
        Controls.Add(dexterityDisp);
        Controls.Add(constitutionDisp);
        Name = "Form1";
        Text = "Character Stats";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)constitutionDisp).EndInit();
        ((System.ComponentModel.ISupportInitialize)dexterityDisp).EndInit();
        ((System.ComponentModel.ISupportInitialize)weaponSkillDisp).EndInit();
        ((System.ComponentModel.ISupportInitialize)forcePowerDisp).EndInit();
        ((System.ComponentModel.ISupportInitialize)blasterSkillDisp).EndInit();
        ((System.ComponentModel.ISupportInitialize)charismaDisp).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private NumericUpDown constitutionDisp;
    private NumericUpDown dexterityDisp;
    private NumericUpDown weaponSkillDisp;
    private NumericUpDown forcePowerDisp;
    private NumericUpDown blasterSkillDisp;
    private TextBox pointsLeft;
    private Button charCreate;
    private NumericUpDown charismaDisp;
    private TextBox conTell;
    private TextBox dexTell;
    private TextBox weapTell;
    private TextBox forTell;
    private TextBox blastTell;
    private TextBox charTell;
    private TextBox Descriptions;
    private TextBox textBox1;
    private TextBox currWeapon;
    private TextBox currForceAbilities;
    private TextBox currBlast;
    private TextBox lvlDisp;
    private TextBox hpDisp;
    private TextBox currWeapAbilities;
}
