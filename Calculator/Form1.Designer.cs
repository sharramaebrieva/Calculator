
namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_00 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_subtract = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_clearAll = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_sign = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_0.Location = new System.Drawing.Point(84, 344);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(68, 53);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dot.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dot.Location = new System.Drawing.Point(158, 344);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(68, 53);
            this.btn_dot.TabIndex = 1;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = false;
            this.btn_dot.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_equal.Location = new System.Drawing.Point(232, 344);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(68, 53);
            this.btn_equal.TabIndex = 2;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = false;
            this.btn_equal.Click += new System.EventHandler(this.ButtonClick_Equal);
            // 
            // btn_00
            // 
            this.btn_00.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_00.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_00.Location = new System.Drawing.Point(10, 344);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(68, 53);
            this.btn_00.TabIndex = 3;
            this.btn_00.Text = "00";
            this.btn_00.UseVisualStyleBackColor = false;
            this.btn_00.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_4.Location = new System.Drawing.Point(10, 226);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(68, 53);
            this.btn_4.TabIndex = 7;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_subtract
            // 
            this.btn_subtract.BackColor = System.Drawing.Color.Pink;
            this.btn_subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subtract.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_subtract.Location = new System.Drawing.Point(232, 226);
            this.btn_subtract.Name = "btn_subtract";
            this.btn_subtract.Size = new System.Drawing.Size(68, 53);
            this.btn_subtract.TabIndex = 6;
            this.btn_subtract.Text = "-";
            this.btn_subtract.UseVisualStyleBackColor = false;
            this.btn_subtract.Click += new System.EventHandler(this.ButtonClick_Subtract);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_6.Location = new System.Drawing.Point(158, 226);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(68, 53);
            this.btn_6.TabIndex = 5;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_5.Location = new System.Drawing.Point(84, 226);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(68, 53);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_1.Location = new System.Drawing.Point(10, 285);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(68, 53);
            this.btn_1.TabIndex = 11;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Pink;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(232, 285);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(68, 53);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.ButtonClick_Add);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_3.Location = new System.Drawing.Point(158, 285);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(68, 53);
            this.btn_3.TabIndex = 9;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_2.Location = new System.Drawing.Point(84, 285);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(68, 53);
            this.btn_2.TabIndex = 8;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_7.Location = new System.Drawing.Point(10, 167);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(68, 53);
            this.btn_7.TabIndex = 15;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.BackColor = System.Drawing.Color.Pink;
            this.btn_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multiply.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_multiply.Location = new System.Drawing.Point(232, 167);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(68, 53);
            this.btn_multiply.TabIndex = 14;
            this.btn_multiply.Text = "×";
            this.btn_multiply.UseVisualStyleBackColor = false;
            this.btn_multiply.Click += new System.EventHandler(this.ButtonClick_Multiply);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_9.Location = new System.Drawing.Point(158, 167);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(68, 53);
            this.btn_9.TabIndex = 13;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_8.Location = new System.Drawing.Point(84, 167);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(68, 53);
            this.btn_8.TabIndex = 12;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_clearAll
            // 
            this.btn_clearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearAll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clearAll.Location = new System.Drawing.Point(10, 108);
            this.btn_clearAll.Name = "btn_clearAll";
            this.btn_clearAll.Size = new System.Drawing.Size(68, 53);
            this.btn_clearAll.TabIndex = 19;
            this.btn_clearAll.Text = "CA";
            this.btn_clearAll.UseVisualStyleBackColor = false;
            this.btn_clearAll.Click += new System.EventHandler(this.Button_ClickClearAll);
            // 
            // btn_divide
            // 
            this.btn_divide.BackColor = System.Drawing.Color.Pink;
            this.btn_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_divide.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_divide.Location = new System.Drawing.Point(232, 108);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(68, 53);
            this.btn_divide.TabIndex = 18;
            this.btn_divide.Text = "÷";
            this.btn_divide.UseVisualStyleBackColor = false;
            // 
            // btn_sign
            // 
            this.btn_sign.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sign.Location = new System.Drawing.Point(158, 108);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(68, 53);
            this.btn_sign.TabIndex = 17;
            this.btn_sign.Text = "+/-";
            this.btn_sign.UseVisualStyleBackColor = false;
            this.btn_sign.Click += new System.EventHandler(this.Button_ClickSign);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.Location = new System.Drawing.Point(84, 108);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(68, 53);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Del";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.ButtonClick_Delete);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDisplay.Location = new System.Drawing.Point(10, 12);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(292, 51);
            this.textBoxDisplay.TabIndex = 20;
            this.textBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBoxDisplay_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxResult.Location = new System.Drawing.Point(10, 62);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(292, 40);
            this.textBoxResult.TabIndex = 21;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(313, 406);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.btn_clearAll);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_subtract);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_00);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_subtract;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_clearAll;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

