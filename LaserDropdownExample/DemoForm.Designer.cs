
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LaserDropdownExample
{
    partial class DemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBeltWidth = new System.Windows.Forms.ComboBox();
            this.cmbCarcassStyle = new System.Windows.Forms.ComboBox();
            this.cmbMshaCertification = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "BELT WIDTH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CARCASS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "MSHA CERT.";
            // 
            // cmbBeltWidth
            // 
            this.cmbBeltWidth.DisplayMember = "Key";
            this.cmbBeltWidth.FormattingEnabled = true;
            this.cmbBeltWidth.Location = new System.Drawing.Point(33, 204);
            this.cmbBeltWidth.Name = "cmbBeltWidth";
            this.cmbBeltWidth.Size = new System.Drawing.Size(121, 23);
            this.cmbBeltWidth.TabIndex = 6;
            this.cmbBeltWidth.ValueMember = "Value";
            // 
            // cmbCarcassStyle
            // 
            this.cmbCarcassStyle.FormattingEnabled = true;
            this.cmbCarcassStyle.Location = new System.Drawing.Point(160, 204);
            this.cmbCarcassStyle.Name = "cmbCarcassStyle";
            this.cmbCarcassStyle.Size = new System.Drawing.Size(202, 23);
            this.cmbCarcassStyle.TabIndex = 7;
            this.cmbCarcassStyle.SelectedIndexChanged += new System.EventHandler(this.cmbCarcassStyle_SelectedIndexChanged);
            // 
            // cmbMshaCertification
            // 
            this.cmbMshaCertification.FormattingEnabled = true;
            this.cmbMshaCertification.Location = new System.Drawing.Point(368, 204);
            this.cmbMshaCertification.Name = "cmbMshaCertification";
            this.cmbMshaCertification.Size = new System.Drawing.Size(177, 23);
            this.cmbMshaCertification.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(122, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 60);
            this.label4.TabIndex = 9;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(122, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 60);
            this.label5.TabIndex = 10;
            this.label5.Text = "FENNER DUNLOP LASER\r\nBRANDING COMBOBOX EXAMPLE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 282);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMshaCertification);
            this.Controls.Add(this.cmbCarcassStyle);
            this.Controls.Add(this.cmbBeltWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DemoForm";
            this.Text = "Fenner Dunlop | Laser Branding Demo Program (v1.1.0)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBeltWidth;
        private System.Windows.Forms.ComboBox cmbCarcassStyle;
        private System.Windows.Forms.ComboBox cmbMshaCertification;
        private Label label4;
        private Label label5;
    }
}