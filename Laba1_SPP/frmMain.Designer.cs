namespace Laba1_SPP
{
    partial class frmMain
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
            this.btnMatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCities = new System.Windows.Forms.ComboBox();
            this.lbPressure = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbTemperature = new System.Windows.Forms.Label();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.lbHumadity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMatch
            // 
            this.btnMatch.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMatch.Location = new System.Drawing.Point(191, 270);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(75, 23);
            this.btnMatch.TabIndex = 0;
            this.btnMatch.Text = "Ок";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Погода";
            // 
            // cbCities
            // 
            this.cbCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCities.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCities.FormattingEnabled = true;
            this.cbCities.Items.AddRange(new object[] {
            "Minsk",
            "Moscow",
            "London"});
            this.cbCities.Location = new System.Drawing.Point(293, 22);
            this.cbCities.Name = "cbCities";
            this.cbCities.Size = new System.Drawing.Size(121, 26);
            this.cbCities.TabIndex = 2;
            this.cbCities.SelectedIndexChanged += new System.EventHandler(this.cbCities_SelectedIndexChanged);
            // 
            // lbPressure
            // 
            this.lbPressure.AutoSize = true;
            this.lbPressure.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPressure.Location = new System.Drawing.Point(21, 178);
            this.lbPressure.Name = "lbPressure";
            this.lbPressure.Size = new System.Drawing.Size(92, 25);
            this.lbPressure.TabIndex = 6;
            this.lbPressure.Text = "Давление:";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbData.Location = new System.Drawing.Point(21, 219);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(105, 25);
            this.lbData.TabIndex = 7;
            this.lbData.Text = "Данные на:";
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTemperature.Location = new System.Drawing.Point(21, 46);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(70, 25);
            this.lbTemperature.TabIndex = 8;
            this.lbTemperature.Text = "Сейчас:";
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSpeed.Location = new System.Drawing.Point(21, 87);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(66, 25);
            this.lbSpeed.TabIndex = 9;
            this.lbSpeed.Text = "Ветер:";
            // 
            // lbHumadity
            // 
            this.lbHumadity.AutoSize = true;
            this.lbHumadity.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHumadity.Location = new System.Drawing.Point(21, 128);
            this.lbHumadity.Name = "lbHumadity";
            this.lbHumadity.Size = new System.Drawing.Size(109, 25);
            this.lbHumadity.TabIndex = 10;
            this.lbHumadity.Text = "Влажность:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 324);
            this.Controls.Add(this.lbHumadity);
            this.Controls.Add(this.lbSpeed);
            this.Controls.Add(this.lbTemperature);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbPressure);
            this.Controls.Add(this.cbCities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMatch);
            this.Name = "frmMain";
            this.Text = "Первая лаба";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCities;
        private System.Windows.Forms.Label lbPressure;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.Label lbHumadity;
    }
}

