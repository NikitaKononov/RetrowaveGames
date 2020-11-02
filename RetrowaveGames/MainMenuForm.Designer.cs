namespace RetrowaveGames {
    partial class MainMenuForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.tetrisBut = new System.Windows.Forms.Button();
            this.snakeBut = new System.Windows.Forms.Button();
            this.raceBut = new System.Windows.Forms.Button();
            this.aboutBut = new System.Windows.Forms.Button();
            this.exitBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tetrisBut
            // 
            this.tetrisBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tetrisBut.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tetrisBut.Location = new System.Drawing.Point(159, 66);
            this.tetrisBut.Name = "tetrisBut";
            this.tetrisBut.Size = new System.Drawing.Size(248, 51);
            this.tetrisBut.TabIndex = 0;
            this.tetrisBut.Text = "Tetris";
            this.tetrisBut.UseVisualStyleBackColor = false;
            this.tetrisBut.Click += new System.EventHandler(this.tetrisBut_Click);
            // 
            // snakeBut
            // 
            this.snakeBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.snakeBut.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.snakeBut.Location = new System.Drawing.Point(159, 123);
            this.snakeBut.Name = "snakeBut";
            this.snakeBut.Size = new System.Drawing.Size(248, 51);
            this.snakeBut.TabIndex = 1;
            this.snakeBut.Text = "Snake";
            this.snakeBut.UseVisualStyleBackColor = false;
            this.snakeBut.Click += new System.EventHandler(this.snakeBut_Click);
            // 
            // raceBut
            // 
            this.raceBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.raceBut.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.raceBut.Location = new System.Drawing.Point(159, 180);
            this.raceBut.Name = "raceBut";
            this.raceBut.Size = new System.Drawing.Size(248, 51);
            this.raceBut.TabIndex = 2;
            this.raceBut.Text = "Race";
            this.raceBut.UseVisualStyleBackColor = false;
            this.raceBut.Click += new System.EventHandler(this.raceBut_Click);
            // 
            // aboutBut
            // 
            this.aboutBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutBut.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.aboutBut.Location = new System.Drawing.Point(159, 237);
            this.aboutBut.Name = "aboutBut";
            this.aboutBut.Size = new System.Drawing.Size(248, 51);
            this.aboutBut.TabIndex = 3;
            this.aboutBut.Text = "About";
            this.aboutBut.UseVisualStyleBackColor = false;
            this.aboutBut.Click += new System.EventHandler(this.aboutBut_Click);
            // 
            // exitBut
            // 
            this.exitBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBut.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.exitBut.Location = new System.Drawing.Point(159, 294);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(248, 51);
            this.exitBut.TabIndex = 4;
            this.exitBut.Text = "Exit";
            this.exitBut.UseVisualStyleBackColor = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::RetrowaveGames.Properties.Resources.menubg;
            this.ClientSize = new System.Drawing.Size(574, 419);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.aboutBut);
            this.Controls.Add(this.raceBut);
            this.Controls.Add(this.snakeBut);
            this.Controls.Add(this.tetrisBut);
            this.Name = "MainMenuForm";
            this.Text = "RetroWave Games";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tetrisBut;
        private System.Windows.Forms.Button snakeBut;
        private System.Windows.Forms.Button raceBut;
        private System.Windows.Forms.Button aboutBut;
        private System.Windows.Forms.Button exitBut;
    }
}

