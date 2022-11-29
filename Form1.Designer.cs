namespace MultiForms {
    partial class NyitoForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanulókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFruit = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyumolcsList = new System.Windows.Forms.ListBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gyumolcsNev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.egysegar = new System.Windows.Forms.NumericUpDown();
            this.amountBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.addNewFruit = new System.Windows.Forms.Button();
            this.updateFruit = new System.Windows.Forms.Button();
            this.removeFruit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.egysegar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(195, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gyümölcsök";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanulókToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanulókToolStripMenuItem
            // 
            this.tanulókToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFruit,
            this.módosításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.tanulókToolStripMenuItem.Name = "tanulókToolStripMenuItem";
            this.tanulókToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.tanulókToolStripMenuItem.Text = "Szerkesztés";
            // 
            // newFruit
            // 
            this.newFruit.Name = "newFruit";
            this.newFruit.Size = new System.Drawing.Size(180, 22);
            this.newFruit.Text = "Új";
            this.newFruit.Click += new System.EventHandler(this.newFruit_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.updateFruit_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.removeFruit_Click);
            // 
            // gyumolcsList
            // 
            this.gyumolcsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.gyumolcsList.FormattingEnabled = true;
            this.gyumolcsList.ItemHeight = 16;
            this.gyumolcsList.Location = new System.Drawing.Point(0, 24);
            this.gyumolcsList.Name = "gyumolcsList";
            this.gyumolcsList.Size = new System.Drawing.Size(120, 530);
            this.gyumolcsList.TabIndex = 2;
            this.gyumolcsList.SelectedIndexChanged += new System.EventHandler(this.gyumolcsList_SelectedIndexChanged);
            // 
            // IdBox
            // 
            this.IdBox.Enabled = false;
            this.IdBox.Location = new System.Drawing.Point(200, 91);
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.Size = new System.Drawing.Size(219, 22);
            this.IdBox.TabIndex = 3;
            this.IdBox.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Név";
            // 
            // gyumolcsNev
            // 
            this.gyumolcsNev.Enabled = false;
            this.gyumolcsNev.Location = new System.Drawing.Point(200, 144);
            this.gyumolcsNev.Name = "gyumolcsNev";
            this.gyumolcsNev.ReadOnly = true;
            this.gyumolcsNev.Size = new System.Drawing.Size(219, 22);
            this.gyumolcsNev.TabIndex = 5;
            this.gyumolcsNev.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Egységár";
            // 
            // egysegar
            // 
            this.egysegar.DecimalPlaces = 2;
            this.egysegar.Enabled = false;
            this.egysegar.Location = new System.Drawing.Point(200, 197);
            this.egysegar.Name = "egysegar";
            this.egysegar.ReadOnly = true;
            this.egysegar.Size = new System.Drawing.Size(219, 22);
            this.egysegar.TabIndex = 9;
            this.egysegar.ThousandsSeparator = true;
            // 
            // amountBox
            // 
            this.amountBox.Enabled = false;
            this.amountBox.Location = new System.Drawing.Point(200, 250);
            this.amountBox.Name = "amountBox";
            this.amountBox.ReadOnly = true;
            this.amountBox.Size = new System.Drawing.Size(219, 22);
            this.amountBox.TabIndex = 11;
            this.amountBox.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mennyiség";
            // 
            // addNewFruit
            // 
            this.addNewFruit.Location = new System.Drawing.Point(200, 317);
            this.addNewFruit.Name = "addNewFruit";
            this.addNewFruit.Size = new System.Drawing.Size(219, 40);
            this.addNewFruit.TabIndex = 12;
            this.addNewFruit.Text = "Új gyümölcs hozzáadása";
            this.addNewFruit.UseVisualStyleBackColor = true;
            this.addNewFruit.Click += new System.EventHandler(this.newFruit_Click);
            // 
            // updateFruit
            // 
            this.updateFruit.Enabled = false;
            this.updateFruit.Location = new System.Drawing.Point(200, 378);
            this.updateFruit.Name = "updateFruit";
            this.updateFruit.Size = new System.Drawing.Size(219, 40);
            this.updateFruit.TabIndex = 13;
            this.updateFruit.Text = "Gyümölcs módosítása";
            this.updateFruit.UseVisualStyleBackColor = true;
            this.updateFruit.Click += new System.EventHandler(this.updateFruit_Click);
            // 
            // removeFruit
            // 
            this.removeFruit.BackColor = System.Drawing.Color.Red;
            this.removeFruit.Enabled = false;
            this.removeFruit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeFruit.ForeColor = System.Drawing.Color.White;
            this.removeFruit.Location = new System.Drawing.Point(200, 443);
            this.removeFruit.Name = "removeFruit";
            this.removeFruit.Size = new System.Drawing.Size(219, 40);
            this.removeFruit.TabIndex = 14;
            this.removeFruit.Text = "Gyümölcs eltávolítása";
            this.removeFruit.UseVisualStyleBackColor = false;
            this.removeFruit.Click += new System.EventHandler(this.removeFruit_Click);
            // 
            // NyitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 554);
            this.Controls.Add(this.removeFruit);
            this.Controls.Add(this.updateFruit);
            this.Controls.Add(this.addNewFruit);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.egysegar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gyumolcsNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.gyumolcsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NyitoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gyümölcsök";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.egysegar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanulókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFruit;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gyumolcsNev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown egysegar;
        private System.Windows.Forms.NumericUpDown amountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addNewFruit;
        private System.Windows.Forms.Button updateFruit;
        private System.Windows.Forms.Button removeFruit;
        public System.Windows.Forms.ListBox gyumolcsList;
    }
}

