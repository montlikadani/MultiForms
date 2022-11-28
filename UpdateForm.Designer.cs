namespace MultiForms {
    partial class UpdateForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.modifyFruit = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.egysegar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gyumolcsNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egysegar)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyFruit
            // 
            this.modifyFruit.Enabled = false;
            this.modifyFruit.Location = new System.Drawing.Point(89, 339);
            this.modifyFruit.Name = "modifyFruit";
            this.modifyFruit.Size = new System.Drawing.Size(161, 46);
            this.modifyFruit.TabIndex = 29;
            this.modifyFruit.Text = "Gyümölcs módosítás alkalmazása";
            this.modifyFruit.UseVisualStyleBackColor = true;
            this.modifyFruit.Click += new System.EventHandler(this.modifyFruit_Click);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(89, 275);
            this.amountBox.Margin = new System.Windows.Forms.Padding(4);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(292, 22);
            this.amountBox.TabIndex = 28;
            this.amountBox.ThousandsSeparator = true;
            this.amountBox.ValueChanged += new System.EventHandler(this.gyumolcsData_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mennyiség";
            // 
            // egysegar
            // 
            this.egysegar.DecimalPlaces = 2;
            this.egysegar.Location = new System.Drawing.Point(89, 210);
            this.egysegar.Margin = new System.Windows.Forms.Padding(4);
            this.egysegar.Name = "egysegar";
            this.egysegar.Size = new System.Drawing.Size(292, 22);
            this.egysegar.TabIndex = 26;
            this.egysegar.ThousandsSeparator = true;
            this.egysegar.ValueChanged += new System.EventHandler(this.gyumolcsData_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Egységár";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Név";
            // 
            // gyumolcsNev
            // 
            this.gyumolcsNev.Location = new System.Drawing.Point(89, 145);
            this.gyumolcsNev.Margin = new System.Windows.Forms.Padding(4);
            this.gyumolcsNev.Name = "gyumolcsNev";
            this.gyumolcsNev.Size = new System.Drawing.Size(291, 22);
            this.gyumolcsNev.TabIndex = 23;
            this.gyumolcsNev.WordWrap = false;
            this.gyumolcsNev.TextChanged += new System.EventHandler(this.gyumolcsData_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Id";
            // 
            // IdBox
            // 
            this.IdBox.Enabled = false;
            this.IdBox.Location = new System.Drawing.Point(89, 80);
            this.IdBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.Size = new System.Drawing.Size(291, 22);
            this.IdBox.TabIndex = 21;
            this.IdBox.WordWrap = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(256, 339);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(124, 46);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Mégse";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 469);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.modifyFruit);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.egysegar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gyumolcsNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "UpdateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gyümölcs adatainak módosítása";
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egysegar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyFruit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown amountBox;
        public System.Windows.Forms.NumericUpDown egysegar;
        public System.Windows.Forms.TextBox gyumolcsNev;
        public System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Button cancelButton;
    }
}