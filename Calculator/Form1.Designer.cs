
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_0 = new System.Windows.Forms.Button();
            this.dot_btn = new System.Windows.Forms.Button();
            this.equal_btn = new System.Windows.Forms.Button();
            this.btn_00 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_0.Location = new System.Drawing.Point(86, 329);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(68, 53);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            // 
            // dot_btn
            // 
            this.dot_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dot_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dot_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dot_btn.Location = new System.Drawing.Point(160, 329);
            this.dot_btn.Name = "dot_btn";
            this.dot_btn.Size = new System.Drawing.Size(68, 53);
            this.dot_btn.TabIndex = 1;
            this.dot_btn.Text = ".";
            this.dot_btn.UseVisualStyleBackColor = false;
            // 
            // equal_btn
            // 
            this.equal_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.equal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equal_btn.Location = new System.Drawing.Point(234, 329);
            this.equal_btn.Name = "equal_btn";
            this.equal_btn.Size = new System.Drawing.Size(68, 53);
            this.equal_btn.TabIndex = 2;
            this.equal_btn.Text = "=";
            this.equal_btn.UseVisualStyleBackColor = false;
            // 
            // btn_00
            // 
            this.btn_00.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_00.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_00.Location = new System.Drawing.Point(12, 329);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(68, 53);
            this.btn_00.TabIndex = 3;
            this.btn_00.Text = "00";
            this.btn_00.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(316, 394);
            this.Controls.Add(this.btn_00);
            this.Controls.Add(this.equal_btn);
            this.Controls.Add(this.dot_btn);
            this.Controls.Add(this.btn_0);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button dot_btn;
        private System.Windows.Forms.Button equal_btn;
        private System.Windows.Forms.Button btn_00;
    }
}

