namespace Encube
{
    partial class GameWindow
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
            this.dicesForRollingDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dicesWithChanceForRollingDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dicesResultDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajGręToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszGręToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zasadyGryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oGrzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dicesForRollingDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dicesWithChanceForRollingDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dicesResultDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dicesForRollingDataGridView
            // 
            this.dicesForRollingDataGridView.AllowUserToAddRows = false;
            this.dicesForRollingDataGridView.AllowUserToDeleteRows = false;
            this.dicesForRollingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dicesForRollingDataGridView.Location = new System.Drawing.Point(6, 33);
            this.dicesForRollingDataGridView.Name = "dicesForRollingDataGridView";
            this.dicesForRollingDataGridView.ReadOnly = true;
            this.dicesForRollingDataGridView.RowTemplate.Height = 24;
            this.dicesForRollingDataGridView.Size = new System.Drawing.Size(257, 196);
            this.dicesForRollingDataGridView.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dicesForRollingDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(18, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 235);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pula kostek rzucanych:";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(269, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "Wybieram!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(269, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wybierz numer:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(269, 146);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(252, 34);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Rzuć kostkami";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dicesWithChanceForRollingDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(18, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 235);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pula szans na rzuty:";
            // 
            // dicesWithChanceForRollingDataGridView
            // 
            this.dicesWithChanceForRollingDataGridView.AllowUserToAddRows = false;
            this.dicesWithChanceForRollingDataGridView.AllowUserToDeleteRows = false;
            this.dicesWithChanceForRollingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dicesWithChanceForRollingDataGridView.Location = new System.Drawing.Point(6, 33);
            this.dicesWithChanceForRollingDataGridView.Name = "dicesWithChanceForRollingDataGridView";
            this.dicesWithChanceForRollingDataGridView.ReadOnly = true;
            this.dicesWithChanceForRollingDataGridView.RowTemplate.Height = 24;
            this.dicesWithChanceForRollingDataGridView.Size = new System.Drawing.Size(251, 196);
            this.dicesWithChanceForRollingDataGridView.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dicesResultDataGridView);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(287, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 235);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pula wyniku:";
            // 
            // dicesResultDataGridView
            // 
            this.dicesResultDataGridView.AllowUserToAddRows = false;
            this.dicesResultDataGridView.AllowUserToDeleteRows = false;
            this.dicesResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dicesResultDataGridView.Location = new System.Drawing.Point(6, 33);
            this.dicesResultDataGridView.Name = "dicesResultDataGridView";
            this.dicesResultDataGridView.ReadOnly = true;
            this.dicesResultDataGridView.RowTemplate.Height = 24;
            this.dicesResultDataGridView.Size = new System.Drawing.Size(251, 196);
            this.dicesResultDataGridView.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajGręToolStripMenuItem,
            this.zapiszGręToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.graToolStripMenuItem.Text = "Gra";
            // 
            // wczytajGręToolStripMenuItem
            // 
            this.wczytajGręToolStripMenuItem.Name = "wczytajGręToolStripMenuItem";
            this.wczytajGręToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.wczytajGręToolStripMenuItem.Text = "Wczytaj grę...";
            // 
            // zapiszGręToolStripMenuItem
            // 
            this.zapiszGręToolStripMenuItem.Name = "zapiszGręToolStripMenuItem";
            this.zapiszGręToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.zapiszGręToolStripMenuItem.Text = "Zapisz grę...";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zasadyGryToolStripMenuItem,
            this.oGrzeToolStripMenuItem,
            this.autorzyToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // zasadyGryToolStripMenuItem
            // 
            this.zasadyGryToolStripMenuItem.Name = "zasadyGryToolStripMenuItem";
            this.zasadyGryToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.zasadyGryToolStripMenuItem.Text = "Zasady gry";
            this.zasadyGryToolStripMenuItem.Click += new System.EventHandler(this.zasadyGryToolStripMenuItem_Click);
            // 
            // oGrzeToolStripMenuItem
            // 
            this.oGrzeToolStripMenuItem.Name = "oGrzeToolStripMenuItem";
            this.oGrzeToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.oGrzeToolStripMenuItem.Text = "O grze";
            this.oGrzeToolStripMenuItem.Click += new System.EventHandler(this.oGrzeToolStripMenuItem_Click);
            // 
            // autorzyToolStripMenuItem
            // 
            this.autorzyToolStripMenuItem.Name = "autorzyToolStripMenuItem";
            this.autorzyToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.autorzyToolStripMenuItem.Text = "Autorzy";
            this.autorzyToolStripMenuItem.Click += new System.EventHandler(this.autorzyToolStripMenuItem_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 592);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameWindow";
            this.Text = "Gra";
            ((System.ComponentModel.ISupportInitialize)(this.dicesForRollingDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dicesWithChanceForRollingDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dicesResultDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dicesForRollingDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dicesWithChanceForRollingDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dicesResultDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajGręToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszGręToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zasadyGryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oGrzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorzyToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}