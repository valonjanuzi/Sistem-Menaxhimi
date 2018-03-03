namespace Econtact
{
    partial class Terminet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terminet));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.terminetidtext = new System.Windows.Forms.TextBox();
            this.emritext = new System.Windows.Forms.TextBox();
            this.mbiemritext = new System.Windows.Forms.TextBox();
            this.datatext = new System.Windows.Forms.TextBox();
            this.kohatext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.terminetDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminetDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1214, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Terminet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Terminet ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Emri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mbiemri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Koha";
            // 
            // terminetidtext
            // 
            this.terminetidtext.Location = new System.Drawing.Point(211, 125);
            this.terminetidtext.Name = "terminetidtext";
            this.terminetidtext.ReadOnly = true;
            this.terminetidtext.Size = new System.Drawing.Size(100, 22);
            this.terminetidtext.TabIndex = 9;
            // 
            // emritext
            // 
            this.emritext.Location = new System.Drawing.Point(211, 170);
            this.emritext.Name = "emritext";
            this.emritext.Size = new System.Drawing.Size(100, 22);
            this.emritext.TabIndex = 9;
            // 
            // mbiemritext
            // 
            this.mbiemritext.Location = new System.Drawing.Point(211, 220);
            this.mbiemritext.Name = "mbiemritext";
            this.mbiemritext.Size = new System.Drawing.Size(100, 22);
            this.mbiemritext.TabIndex = 9;
            // 
            // datatext
            // 
            this.datatext.Location = new System.Drawing.Point(211, 270);
            this.datatext.Name = "datatext";
            this.datatext.Size = new System.Drawing.Size(100, 22);
            this.datatext.TabIndex = 9;
            // 
            // kohatext
            // 
            this.kohatext.Location = new System.Drawing.Point(211, 312);
            this.kohatext.Name = "kohatext";
            this.kohatext.Size = new System.Drawing.Size(100, 22);
            this.kohatext.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.add_terminet);
            // 
            // terminetDataGrid
            // 
            this.terminetDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terminetDataGrid.Location = new System.Drawing.Point(499, 108);
            this.terminetDataGrid.Name = "terminetDataGrid";
            this.terminetDataGrid.RowTemplate.Height = 24;
            this.terminetDataGrid.Size = new System.Drawing.Size(640, 258);
            this.terminetDataGrid.TabIndex = 11;
            // 
            // Terminet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 538);
            this.Controls.Add(this.terminetDataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kohatext);
            this.Controls.Add(this.datatext);
            this.Controls.Add(this.mbiemritext);
            this.Controls.Add(this.emritext);
            this.Controls.Add(this.terminetidtext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Terminet";
            this.Text = "Terminet";
            this.Load += new System.EventHandler(this.Terminet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminetDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox terminetidtext;
        private System.Windows.Forms.TextBox emritext;
        private System.Windows.Forms.TextBox mbiemritext;
        private System.Windows.Forms.TextBox datatext;
        private System.Windows.Forms.TextBox kohatext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView terminetDataGrid;
    }
}