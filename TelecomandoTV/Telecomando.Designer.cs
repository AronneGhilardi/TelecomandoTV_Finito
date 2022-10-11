namespace TelecomandoTV
{
    partial class Telecomando
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.powerButton = new System.Windows.Forms.Button();
            this.produttoreBox = new System.Windows.Forms.TextBox();
            this.modelloBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.infrButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.wifiButton = new System.Windows.Forms.Button();
            this.volupButton = new System.Windows.Forms.Button();
            this.voldownButton = new System.Windows.Forms.Button();
            this.chupButton = new System.Windows.Forms.Button();
            this.chdownButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.powerLed = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.muteButton = new System.Windows.Forms.Button();
            this.infrLed = new System.Windows.Forms.PictureBox();
            this.blueLed = new System.Windows.Forms.PictureBox();
            this.wifiLed = new System.Windows.Forms.PictureBox();
            this.volLabel = new System.Windows.Forms.Label();
            this.chLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.powerLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infrLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wifiLed)).BeginInit();
            this.SuspendLayout();
            // 
            // powerButton
            // 
            this.powerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.powerButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerButton.ForeColor = System.Drawing.Color.Black;
            this.powerButton.Location = new System.Drawing.Point(12, 16);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(104, 30);
            this.powerButton.TabIndex = 2;
            this.powerButton.Text = "Power";
            this.powerButton.UseVisualStyleBackColor = false;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // produttoreBox
            // 
            this.produttoreBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.produttoreBox.Location = new System.Drawing.Point(12, 489);
            this.produttoreBox.Name = "produttoreBox";
            this.produttoreBox.Size = new System.Drawing.Size(160, 20);
            this.produttoreBox.TabIndex = 3;
            this.produttoreBox.TextChanged += new System.EventHandler(this.produttureBox_TextChanged);
            // 
            // modelloBox
            // 
            this.modelloBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.modelloBox.Location = new System.Drawing.Point(12, 529);
            this.modelloBox.Name = "modelloBox";
            this.modelloBox.Size = new System.Drawing.Size(160, 20);
            this.modelloBox.TabIndex = 4;
            this.modelloBox.TextChanged += new System.EventHandler(this.modelloBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Produttore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modello";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infrButton
            // 
            this.infrButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.infrButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infrButton.ForeColor = System.Drawing.Color.Black;
            this.infrButton.Location = new System.Drawing.Point(12, 53);
            this.infrButton.Name = "infrButton";
            this.infrButton.Size = new System.Drawing.Size(49, 30);
            this.infrButton.TabIndex = 8;
            this.infrButton.Text = "Infr";
            this.infrButton.UseVisualStyleBackColor = false;
            this.infrButton.Click += new System.EventHandler(this.infrButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.blueButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueButton.ForeColor = System.Drawing.Color.Black;
            this.blueButton.Location = new System.Drawing.Point(67, 53);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(49, 30);
            this.blueButton.TabIndex = 10;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // wifiButton
            // 
            this.wifiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wifiButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wifiButton.ForeColor = System.Drawing.Color.Black;
            this.wifiButton.Location = new System.Drawing.Point(123, 53);
            this.wifiButton.Name = "wifiButton";
            this.wifiButton.Size = new System.Drawing.Size(49, 30);
            this.wifiButton.TabIndex = 12;
            this.wifiButton.Text = "Wi-Fi";
            this.wifiButton.UseVisualStyleBackColor = false;
            this.wifiButton.Click += new System.EventHandler(this.wifiButton_Click);
            // 
            // volupButton
            // 
            this.volupButton.AutoSize = true;
            this.volupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.volupButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volupButton.ForeColor = System.Drawing.Color.Black;
            this.volupButton.Location = new System.Drawing.Point(11, 226);
            this.volupButton.Name = "volupButton";
            this.volupButton.Size = new System.Drawing.Size(31, 50);
            this.volupButton.TabIndex = 13;
            this.volupButton.Text = "+";
            this.volupButton.UseVisualStyleBackColor = false;
            this.volupButton.Click += new System.EventHandler(this.volupButton_Click);
            // 
            // voldownButton
            // 
            this.voldownButton.AutoSize = true;
            this.voldownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.voldownButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voldownButton.ForeColor = System.Drawing.Color.Black;
            this.voldownButton.Location = new System.Drawing.Point(12, 297);
            this.voldownButton.Name = "voldownButton";
            this.voldownButton.Size = new System.Drawing.Size(30, 50);
            this.voldownButton.TabIndex = 14;
            this.voldownButton.Text = "-";
            this.voldownButton.UseVisualStyleBackColor = false;
            this.voldownButton.Click += new System.EventHandler(this.voldownButton_Click);
            // 
            // chupButton
            // 
            this.chupButton.AutoSize = true;
            this.chupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chupButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chupButton.ForeColor = System.Drawing.Color.Black;
            this.chupButton.Location = new System.Drawing.Point(138, 226);
            this.chupButton.Name = "chupButton";
            this.chupButton.Size = new System.Drawing.Size(31, 50);
            this.chupButton.TabIndex = 15;
            this.chupButton.Text = "+";
            this.chupButton.UseVisualStyleBackColor = false;
            this.chupButton.Click += new System.EventHandler(this.chupButton_Click);
            // 
            // chdownButton
            // 
            this.chdownButton.AutoSize = true;
            this.chdownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chdownButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chdownButton.ForeColor = System.Drawing.Color.Black;
            this.chdownButton.Location = new System.Drawing.Point(138, 297);
            this.chdownButton.Name = "chdownButton";
            this.chdownButton.Size = new System.Drawing.Size(30, 50);
            this.chdownButton.TabIndex = 16;
            this.chdownButton.Text = "-";
            this.chdownButton.UseVisualStyleBackColor = false;
            this.chdownButton.Click += new System.EventHandler(this.chdownButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Vol";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ch";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // powerLed
            // 
            this.powerLed.Location = new System.Drawing.Point(42, 0);
            this.powerLed.Name = "powerLed";
            this.powerLed.Size = new System.Drawing.Size(100, 10);
            this.powerLed.TabIndex = 19;
            this.powerLed.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resetButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(123, 16);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(49, 30);
            this.resetButton.TabIndex = 21;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // muteButton
            // 
            this.muteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.muteButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muteButton.ForeColor = System.Drawing.Color.Black;
            this.muteButton.Location = new System.Drawing.Point(67, 271);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(49, 30);
            this.muteButton.TabIndex = 24;
            this.muteButton.Text = "Mute";
            this.muteButton.UseVisualStyleBackColor = false;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // infrLed
            // 
            this.infrLed.Location = new System.Drawing.Point(12, 89);
            this.infrLed.Name = "infrLed";
            this.infrLed.Size = new System.Drawing.Size(49, 10);
            this.infrLed.TabIndex = 25;
            this.infrLed.TabStop = false;
            // 
            // blueLed
            // 
            this.blueLed.Location = new System.Drawing.Point(67, 89);
            this.blueLed.Name = "blueLed";
            this.blueLed.Size = new System.Drawing.Size(49, 10);
            this.blueLed.TabIndex = 26;
            this.blueLed.TabStop = false;
            // 
            // wifiLed
            // 
            this.wifiLed.Location = new System.Drawing.Point(123, 89);
            this.wifiLed.Name = "wifiLed";
            this.wifiLed.Size = new System.Drawing.Size(49, 10);
            this.wifiLed.TabIndex = 27;
            this.wifiLed.TabStop = false;
            // 
            // volLabel
            // 
            this.volLabel.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volLabel.Location = new System.Drawing.Point(12, 279);
            this.volLabel.Name = "volLabel";
            this.volLabel.Size = new System.Drawing.Size(30, 15);
            this.volLabel.TabIndex = 28;
            this.volLabel.Text = "0";
            this.volLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chLabel
            // 
            this.chLabel.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chLabel.Location = new System.Drawing.Point(138, 279);
            this.chLabel.Name = "chLabel";
            this.chLabel.Size = new System.Drawing.Size(30, 15);
            this.chLabel.TabIndex = 29;
            this.chLabel.Text = "0";
            this.chLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Telecomando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(184, 561);
            this.Controls.Add(this.chLabel);
            this.Controls.Add(this.volLabel);
            this.Controls.Add(this.wifiLed);
            this.Controls.Add(this.blueLed);
            this.Controls.Add(this.infrLed);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.powerLed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chdownButton);
            this.Controls.Add(this.chupButton);
            this.Controls.Add(this.voldownButton);
            this.Controls.Add(this.volupButton);
            this.Controls.Add(this.wifiButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.infrButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modelloBox);
            this.Controls.Add(this.produttoreBox);
            this.Controls.Add(this.powerButton);
            this.Name = "Telecomando";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.powerLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infrLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wifiLed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.TextBox produttoreBox;
        private System.Windows.Forms.TextBox modelloBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button infrButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button wifiButton;
        private System.Windows.Forms.Button volupButton;
        private System.Windows.Forms.Button voldownButton;
        private System.Windows.Forms.Button chupButton;
        private System.Windows.Forms.Button chdownButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox powerLed;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button muteButton;
        private System.Windows.Forms.PictureBox infrLed;
        private System.Windows.Forms.PictureBox blueLed;
        private System.Windows.Forms.PictureBox wifiLed;
        private System.Windows.Forms.Label volLabel;
        private System.Windows.Forms.Label chLabel;
    }
}

