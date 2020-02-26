namespace Taps
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TapsLbl = new System.Windows.Forms.Label();
            this.DmgLbl = new System.Windows.Forms.Label();
            this.DPSLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mob = new System.Windows.Forms.Label();
            this.GoldLbl = new System.Windows.Forms.Label();
            this.DMGUL = new System.Windows.Forms.Label();
            this.DPSUL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TapsLbl
            // 
            this.TapsLbl.AutoSize = true;
            this.TapsLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TapsLbl.Location = new System.Drawing.Point(11, 176);
            this.TapsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TapsLbl.Name = "TapsLbl";
            this.TapsLbl.Size = new System.Drawing.Size(63, 15);
            this.TapsLbl.TabIndex = 1;
            this.TapsLbl.Text = "Taps: 0";
            // 
            // DmgLbl
            // 
            this.DmgLbl.AutoSize = true;
            this.DmgLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DmgLbl.Location = new System.Drawing.Point(11, 213);
            this.DmgLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DmgLbl.Name = "DmgLbl";
            this.DmgLbl.Size = new System.Drawing.Size(79, 15);
            this.DmgLbl.TabIndex = 2;
            this.DmgLbl.Text = "Damage: 1";
            // 
            // DPSLbl
            // 
            this.DPSLbl.AutoSize = true;
            this.DPSLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DPSLbl.Location = new System.Drawing.Point(120, 213);
            this.DPSLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DPSLbl.Name = "DPSLbl";
            this.DPSLbl.Size = new System.Drawing.Size(55, 15);
            this.DPSLbl.TabIndex = 3;
            this.DPSLbl.Text = "DPS: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(258, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(233, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(228, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 46);
            this.label6.TabIndex = 6;
            this.label6.Text = "Activates after first tap";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mob
            // 
            this.mob.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mob.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mob.Location = new System.Drawing.Point(113, 32);
            this.mob.Name = "mob";
            this.mob.Size = new System.Drawing.Size(119, 93);
            this.mob.TabIndex = 7;
            this.mob.Text = "b";
            this.mob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mob.Click += new System.EventHandler(this.panel1_Click);
            // 
            // GoldLbl
            // 
            this.GoldLbl.AutoSize = true;
            this.GoldLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoldLbl.Location = new System.Drawing.Point(120, 176);
            this.GoldLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GoldLbl.Name = "GoldLbl";
            this.GoldLbl.Size = new System.Drawing.Size(63, 15);
            this.GoldLbl.TabIndex = 8;
            this.GoldLbl.Text = "Gold: 0";
            this.GoldLbl.TextChanged += new System.EventHandler(this.GoldEnough);
            // 
            // DMGUL
            // 
            this.DMGUL.AutoSize = true;
            this.DMGUL.Font = new System.Drawing.Font("Droid Sans Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DMGUL.ForeColor = System.Drawing.Color.Gray;
            this.DMGUL.Location = new System.Drawing.Point(11, 254);
            this.DMGUL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DMGUL.Name = "DMGUL";
            this.DMGUL.Size = new System.Drawing.Size(63, 15);
            this.DMGUL.TabIndex = 9;
            this.DMGUL.Text = "Upgrade";
            this.DMGUL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DMGUL.Click += new System.EventHandler(this.DMGUL_Click);
            // 
            // DPSUL
            // 
            this.DPSUL.AutoSize = true;
            this.DPSUL.Font = new System.Drawing.Font("Droid Sans Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DPSUL.ForeColor = System.Drawing.Color.Gray;
            this.DPSUL.Location = new System.Drawing.Point(120, 254);
            this.DPSUL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DPSUL.Name = "DPSUL";
            this.DPSUL.Size = new System.Drawing.Size(63, 15);
            this.DPSUL.TabIndex = 10;
            this.DPSUL.Text = "Upgrade";
            this.DPSUL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DPSUL.Click += new System.EventHandler(this.DPSUL_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Droid Sans Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(136, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "0/0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(331, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DPSUL);
            this.Controls.Add(this.DMGUL);
            this.Controls.Add(this.GoldLbl);
            this.Controls.Add(this.mob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DPSLbl);
            this.Controls.Add(this.DmgLbl);
            this.Controls.Add(this.TapsLbl);
            this.Font = new System.Drawing.Font("Droid Sans Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Invaders!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TapsLbl;
        private System.Windows.Forms.Label DmgLbl;
        private System.Windows.Forms.Label DPSLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label mob;
        private System.Windows.Forms.Label GoldLbl;
        private System.Windows.Forms.Label DMGUL;
        private System.Windows.Forms.Label DPSUL;
        private System.Windows.Forms.Label label1;
    }
}

