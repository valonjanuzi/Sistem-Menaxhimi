namespace Econtact
{
    partial class MainDesign
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvterminetList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.txtboxSearch1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvterminetList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistem Menaxhimi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kontakti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.kontakticlick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(28, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Terminet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.terminet_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Terminet";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSearch.Location = new System.Drawing.Point(560, 143);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(773, 26);
            this.txtboxSearch.TabIndex = 26;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(492, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Kërko :";
            // 
            // dgvterminetList
            // 
            this.dgvterminetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvterminetList.Location = new System.Drawing.Point(492, 185);
            this.dgvterminetList.Name = "dgvterminetList";
            this.dgvterminetList.RowTemplate.Height = 24;
            this.dgvterminetList.Size = new System.Drawing.Size(841, 96);
            this.dgvterminetList.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Kërko :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvContactList
            // 
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Location = new System.Drawing.Point(496, 358);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.RowTemplate.Height = 24;
            this.dgvContactList.Size = new System.Drawing.Size(837, 105);
            this.dgvContactList.TabIndex = 28;
            // 
            // txtboxSearch1
            // 
            this.txtboxSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSearch1.Location = new System.Drawing.Point(560, 313);
            this.txtboxSearch1.Name = "txtboxSearch1";
            this.txtboxSearch1.Size = new System.Drawing.Size(773, 26);
            this.txtboxSearch1.TabIndex = 27;
            this.txtboxSearch1.TextChanged += new System.EventHandler(this.txtboxSearch1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kontakti";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(28, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 45);
            this.button3.TabIndex = 31;
            this.button3.Text = "Chat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.chatClick);
            // 
            // MainDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 581);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvContactList);
            this.Controls.Add(this.txtboxSearch1);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvterminetList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MainDesign";
            this.Text = "MainDesign";
            this.Load += new System.EventHandler(this.MainDesign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvterminetList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvterminetList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.TextBox txtboxSearch1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}