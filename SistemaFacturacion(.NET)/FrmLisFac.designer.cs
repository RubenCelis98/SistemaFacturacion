﻿namespace SistemaFacturacion__C_Scharp_SQL_Server
{
    partial class FrmLisFac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLisFac));
            this.txtNumFac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFac = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFac)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumFac
            // 
            this.txtNumFac.Location = new System.Drawing.Point(140, 15);
            this.txtNumFac.Name = "txtNumFac";
            this.txtNumFac.Size = new System.Drawing.Size(1060, 22);
            this.txtNumFac.TabIndex = 0;
            this.txtNumFac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumFac_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número de factura:";
            // 
            // dgvFac
            // 
            this.dgvFac.AllowUserToAddRows = false;
            this.dgvFac.AllowUserToDeleteRows = false;
            this.dgvFac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFac.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFac.Location = new System.Drawing.Point(9, 55);
            this.dgvFac.Name = "dgvFac";
            this.dgvFac.ReadOnly = true;
            this.dgvFac.RowTemplate.Height = 24;
            this.dgvFac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFac.Size = new System.Drawing.Size(1191, 654);
            this.dgvFac.TabIndex = 1;
            // 
            // FrmLisFac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 721);
            this.Controls.Add(this.txtNumFac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFac);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLisFac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de facturas";
            this.Load += new System.EventHandler(this.FrmLisFac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumFac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFac;
    }
}