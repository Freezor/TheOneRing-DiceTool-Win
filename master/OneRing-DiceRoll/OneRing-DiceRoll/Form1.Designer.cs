namespace OneRing_DiceRoll
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bRollDice = new System.Windows.Forms.Button();
            this.bAddDice = new System.Windows.Forms.Button();
            this.bRemoveDice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lDiceCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAchievingValue = new System.Windows.Forms.TextBox();
            this.tbRolledValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTengwa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaxDice = new System.Windows.Forms.TextBox();
            this.lMax = new System.Windows.Forms.Label();
            this.tbRune = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbHeroDice = new System.Windows.Forms.PictureBox();
            this.achievDice4 = new System.Windows.Forms.PictureBox();
            this.achievDice5 = new System.Windows.Forms.PictureBox();
            this.achievDice6 = new System.Windows.Forms.PictureBox();
            this.achievDice3 = new System.Windows.Forms.PictureBox();
            this.achievDice2 = new System.Windows.Forms.PictureBox();
            this.achievDice1 = new System.Windows.Forms.PictureBox();
            this.bInitRandoms = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievDice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievDice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievDice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievDice1)).BeginInit();
            this.SuspendLayout();
            // 
            // bRollDice
            // 
            this.bRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRollDice.Location = new System.Drawing.Point(342, 406);
            this.bRollDice.Name = "bRollDice";
            this.bRollDice.Size = new System.Drawing.Size(233, 100);
            this.bRollDice.TabIndex = 6;
            this.bRollDice.Text = "Roll Dice";
            this.bRollDice.UseVisualStyleBackColor = true;
            this.bRollDice.Click += new System.EventHandler(this.bRollDice_Click);
            // 
            // bAddDice
            // 
            this.bAddDice.Location = new System.Drawing.Point(6, 242);
            this.bAddDice.Name = "bAddDice";
            this.bAddDice.Size = new System.Drawing.Size(100, 48);
            this.bAddDice.TabIndex = 7;
            this.bAddDice.Text = "Add Dice";
            this.bAddDice.UseVisualStyleBackColor = true;
            this.bAddDice.Click += new System.EventHandler(this.bAddDice_Click);
            // 
            // bRemoveDice
            // 
            this.bRemoveDice.Location = new System.Drawing.Point(112, 242);
            this.bRemoveDice.Name = "bRemoveDice";
            this.bRemoveDice.Size = new System.Drawing.Size(100, 48);
            this.bRemoveDice.TabIndex = 8;
            this.bRemoveDice.Text = "Remove Dice";
            this.bRemoveDice.UseVisualStyleBackColor = true;
            this.bRemoveDice.Click += new System.EventHandler(this.bRemoveDice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Achievement Dice";
            // 
            // lDiceCount
            // 
            this.lDiceCount.AutoSize = true;
            this.lDiceCount.BackColor = System.Drawing.Color.Transparent;
            this.lDiceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDiceCount.Location = new System.Drawing.Point(520, 76);
            this.lDiceCount.Name = "lDiceCount";
            this.lDiceCount.Size = new System.Drawing.Size(20, 24);
            this.lDiceCount.TabIndex = 11;
            this.lDiceCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "of 6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Achieving Value:";
            // 
            // tbAchievingValue
            // 
            this.tbAchievingValue.Location = new System.Drawing.Point(469, 242);
            this.tbAchievingValue.Name = "tbAchievingValue";
            this.tbAchievingValue.Size = new System.Drawing.Size(100, 20);
            this.tbAchievingValue.TabIndex = 14;
            // 
            // tbRolledValue
            // 
            this.tbRolledValue.Enabled = false;
            this.tbRolledValue.Location = new System.Drawing.Point(469, 294);
            this.tbRolledValue.Name = "tbRolledValue";
            this.tbRolledValue.Size = new System.Drawing.Size(100, 20);
            this.tbRolledValue.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rolled Value:";
            // 
            // tbTengwa
            // 
            this.tbTengwa.Enabled = false;
            this.tbTengwa.Location = new System.Drawing.Point(469, 320);
            this.tbTengwa.Name = "tbTengwa";
            this.tbTengwa.Size = new System.Drawing.Size(100, 20);
            this.tbTengwa.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tengwa Signs:";
            // 
            // tbMaxDice
            // 
            this.tbMaxDice.Enabled = false;
            this.tbMaxDice.Location = new System.Drawing.Point(469, 268);
            this.tbMaxDice.Name = "tbMaxDice";
            this.tbMaxDice.Size = new System.Drawing.Size(100, 20);
            this.tbMaxDice.TabIndex = 20;
            // 
            // lMax
            // 
            this.lMax.AutoSize = true;
            this.lMax.BackColor = System.Drawing.Color.Transparent;
            this.lMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMax.Location = new System.Drawing.Point(350, 268);
            this.lMax.Name = "lMax";
            this.lMax.Size = new System.Drawing.Size(69, 17);
            this.lMax.TabIndex = 19;
            this.lMax.Text = "Max Dice:";
            // 
            // tbRune
            // 
            this.tbRune.Enabled = false;
            this.tbRune.Location = new System.Drawing.Point(469, 348);
            this.tbRune.Name = "tbRune";
            this.tbRune.Size = new System.Drawing.Size(100, 20);
            this.tbRune.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Rune:";
            // 
            // pbHeroDice
            // 
            this.pbHeroDice.BackColor = System.Drawing.Color.Transparent;
            this.pbHeroDice.Location = new System.Drawing.Point(6, 296);
            this.pbHeroDice.Name = "pbHeroDice";
            this.pbHeroDice.Size = new System.Drawing.Size(200, 200);
            this.pbHeroDice.TabIndex = 9;
            this.pbHeroDice.TabStop = false;
            // 
            // achievDice4
            // 
            this.achievDice4.BackColor = System.Drawing.Color.Transparent;
            this.achievDice4.Location = new System.Drawing.Point(324, 126);
            this.achievDice4.Name = "achievDice4";
            this.achievDice4.Size = new System.Drawing.Size(100, 100);
            this.achievDice4.TabIndex = 5;
            this.achievDice4.TabStop = false;
            this.achievDice4.Visible = false;
            // 
            // achievDice5
            // 
            this.achievDice5.BackColor = System.Drawing.Color.Transparent;
            this.achievDice5.Location = new System.Drawing.Point(430, 126);
            this.achievDice5.Name = "achievDice5";
            this.achievDice5.Size = new System.Drawing.Size(100, 100);
            this.achievDice5.TabIndex = 4;
            this.achievDice5.TabStop = false;
            this.achievDice5.Visible = false;
            // 
            // achievDice6
            // 
            this.achievDice6.BackColor = System.Drawing.Color.Transparent;
            this.achievDice6.Location = new System.Drawing.Point(536, 126);
            this.achievDice6.Name = "achievDice6";
            this.achievDice6.Size = new System.Drawing.Size(100, 100);
            this.achievDice6.TabIndex = 3;
            this.achievDice6.TabStop = false;
            this.achievDice6.Visible = false;
            // 
            // achievDice3
            // 
            this.achievDice3.BackColor = System.Drawing.Color.Transparent;
            this.achievDice3.Location = new System.Drawing.Point(218, 126);
            this.achievDice3.Name = "achievDice3";
            this.achievDice3.Size = new System.Drawing.Size(100, 100);
            this.achievDice3.TabIndex = 2;
            this.achievDice3.TabStop = false;
            this.achievDice3.Visible = false;
            // 
            // achievDice2
            // 
            this.achievDice2.BackColor = System.Drawing.Color.Transparent;
            this.achievDice2.Location = new System.Drawing.Point(112, 126);
            this.achievDice2.Name = "achievDice2";
            this.achievDice2.Size = new System.Drawing.Size(100, 100);
            this.achievDice2.TabIndex = 1;
            this.achievDice2.TabStop = false;
            this.achievDice2.Visible = false;
            // 
            // achievDice1
            // 
            this.achievDice1.BackColor = System.Drawing.Color.Transparent;
            this.achievDice1.ErrorImage = null;
            this.achievDice1.Location = new System.Drawing.Point(6, 126);
            this.achievDice1.Name = "achievDice1";
            this.achievDice1.Size = new System.Drawing.Size(100, 100);
            this.achievDice1.TabIndex = 0;
            this.achievDice1.TabStop = false;
            this.achievDice1.Visible = false;
            // 
            // bInitRandoms
            // 
            this.bInitRandoms.Location = new System.Drawing.Point(218, 242);
            this.bInitRandoms.Name = "bInitRandoms";
            this.bInitRandoms.Size = new System.Drawing.Size(100, 48);
            this.bInitRandoms.TabIndex = 23;
            this.bInitRandoms.Text = "Init Dice";
            this.bInitRandoms.UseVisualStyleBackColor = true;
            this.bInitRandoms.Click += new System.EventHandler(this.bInitRandoms_Click);
            // 
            // tbResult
            // 
            this.tbResult.Enabled = false;
            this.tbResult.Location = new System.Drawing.Point(469, 377);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(100, 20);
            this.tbResult.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Result:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(654, 518);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bInitRandoms);
            this.Controls.Add(this.tbRune);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMaxDice);
            this.Controls.Add(this.lMax);
            this.Controls.Add(this.tbTengwa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRolledValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAchievingValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lDiceCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHeroDice);
            this.Controls.Add(this.bRemoveDice);
            this.Controls.Add(this.bAddDice);
            this.Controls.Add(this.bRollDice);
            this.Controls.Add(this.achievDice4);
            this.Controls.Add(this.achievDice5);
            this.Controls.Add(this.achievDice6);
            this.Controls.Add(this.achievDice3);
            this.Controls.Add(this.achievDice2);
            this.Controls.Add(this.achievDice1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "The One Ring - Dice Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievDice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievDice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievDice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achievDice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox achievDice1;
        private System.Windows.Forms.PictureBox achievDice2;
        private System.Windows.Forms.PictureBox achievDice3;
        private System.Windows.Forms.PictureBox achievDice6;
        private System.Windows.Forms.PictureBox achievDice5;
        private System.Windows.Forms.PictureBox achievDice4;
        private System.Windows.Forms.Button bRollDice;
        private System.Windows.Forms.Button bAddDice;
        private System.Windows.Forms.Button bRemoveDice;
        private System.Windows.Forms.PictureBox pbHeroDice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDiceCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAchievingValue;
        private System.Windows.Forms.TextBox tbRolledValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTengwa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaxDice;
        private System.Windows.Forms.Label lMax;
        private System.Windows.Forms.TextBox tbRune;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bInitRandoms;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label7;
    }
}

