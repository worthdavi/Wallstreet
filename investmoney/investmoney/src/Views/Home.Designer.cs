﻿
namespace investmoney.src.Views
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataTableActives = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblActivesBalance = new System.Windows.Forms.Label();
            this.pnlLogoHome = new System.Windows.Forms.Panel();
            this.btnPainelAdministrativo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableActives)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTableActives
            // 
            this.dataTableActives.AllowUserToAddRows = false;
            this.dataTableActives.AllowUserToDeleteRows = false;
            this.dataTableActives.AllowUserToResizeColumns = false;
            this.dataTableActives.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableActives.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataTableActives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableActives.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataTableActives.GridColor = System.Drawing.Color.White;
            this.dataTableActives.Location = new System.Drawing.Point(12, 107);
            this.dataTableActives.MultiSelect = false;
            this.dataTableActives.Name = "dataTableActives";
            this.dataTableActives.ReadOnly = true;
            this.dataTableActives.RowHeadersVisible = false;
            this.dataTableActives.Size = new System.Drawing.Size(887, 246);
            this.dataTableActives.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "BUY ACTIVES";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "SELL ACTIVES";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Location = new System.Drawing.Point(9, 91);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(118, 13);
            this.lblAccountBalance.TabIndex = 6;
            this.lblAccountBalance.Text = "Account Balance Label";
            // 
            // lblActivesBalance
            // 
            this.lblActivesBalance.AutoSize = true;
            this.lblActivesBalance.Location = new System.Drawing.Point(9, 356);
            this.lblActivesBalance.Name = "lblActivesBalance";
            this.lblActivesBalance.Size = new System.Drawing.Size(129, 13);
            this.lblActivesBalance.TabIndex = 7;
            this.lblActivesBalance.Text = "Your actives balance is: ?";
            // 
            // pnlLogoHome
            // 
            this.pnlLogoHome.BackgroundImage = global::investmoney.Properties.Resources.investmoney_brand;
            this.pnlLogoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogoHome.Location = new System.Drawing.Point(294, 4);
            this.pnlLogoHome.Name = "pnlLogoHome";
            this.pnlLogoHome.Size = new System.Drawing.Size(338, 100);
            this.pnlLogoHome.TabIndex = 8;
            // 
            // btnPainelAdministrativo
            // 
            this.btnPainelAdministrativo.BackgroundImage = global::investmoney.Properties.Resources.Engrenagem_Bicolor_PNG;
            this.btnPainelAdministrativo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPainelAdministrativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPainelAdministrativo.Location = new System.Drawing.Point(864, 4);
            this.btnPainelAdministrativo.Name = "btnPainelAdministrativo";
            this.btnPainelAdministrativo.Size = new System.Drawing.Size(35, 33);
            this.btnPainelAdministrativo.TabIndex = 9;
            this.btnPainelAdministrativo.UseVisualStyleBackColor = true;
            this.btnPainelAdministrativo.Click += new System.EventHandler(this.btnPainelAdministrativo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMenuName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(699, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 93);
            this.panel1.TabIndex = 10;
            // 
            // lblMenuName
            // 
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.Font = new System.Drawing.Font("Bebas Neue", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuName.Location = new System.Drawing.Point(32, 0);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(139, 48);
            this.lblMenuName.TabIndex = 11;
            this.lblMenuName.Text = "ADVERTISE";
            this.lblMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.ForeColor = System.Drawing.Color.Blue;
            this.lblHistory.Location = new System.Drawing.Point(9, 425);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(202, 13);
            this.lblHistory.TabIndex = 11;
            this.lblHistory.Text = "Click here to see your transactions history";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.btnPainelAdministrativo);
            this.Controls.Add(this.pnlLogoHome);
            this.Controls.Add(this.lblActivesBalance);
            this.Controls.Add(this.lblAccountBalance);
            this.Controls.Add(this.dataTableActives);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - {0}";
            ((System.ComponentModel.ISupportInitialize)(this.dataTableActives)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataTableActives;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblActivesBalance;
        private System.Windows.Forms.Panel pnlLogoHome;
        private System.Windows.Forms.Button btnPainelAdministrativo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.Label lblHistory;
    }
}