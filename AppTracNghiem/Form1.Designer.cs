namespace AppTracNghiem
{
    partial class Form1
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
            this.rdbt_A = new System.Windows.Forms.RadioButton();
            this.rdbt_B = new System.Windows.Forms.RadioButton();
            this.rdbt_C = new System.Windows.Forms.RadioButton();
            this.rdbt_D = new System.Windows.Forms.RadioButton();
            this.lb_CauHoi = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Nop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbt_A
            // 
            this.rdbt_A.AutoSize = true;
            this.rdbt_A.Location = new System.Drawing.Point(96, 148);
            this.rdbt_A.Name = "rdbt_A";
            this.rdbt_A.Size = new System.Drawing.Size(70, 17);
            this.rdbt_A.TabIndex = 0;
            this.rdbt_A.TabStop = true;
            this.rdbt_A.Text = "Đáp án A";
            this.rdbt_A.UseVisualStyleBackColor = true;
            this.rdbt_A.CheckedChanged += new System.EventHandler(this.rdbt_A_CheckedChanged);
            // 
            // rdbt_B
            // 
            this.rdbt_B.AutoSize = true;
            this.rdbt_B.Location = new System.Drawing.Point(96, 181);
            this.rdbt_B.Name = "rdbt_B";
            this.rdbt_B.Size = new System.Drawing.Size(70, 17);
            this.rdbt_B.TabIndex = 1;
            this.rdbt_B.TabStop = true;
            this.rdbt_B.Text = "Đáp án B";
            this.rdbt_B.UseVisualStyleBackColor = true;
            this.rdbt_B.CheckedChanged += new System.EventHandler(this.rdbt_B_CheckedChanged);
            // 
            // rdbt_C
            // 
            this.rdbt_C.AutoSize = true;
            this.rdbt_C.Location = new System.Drawing.Point(96, 212);
            this.rdbt_C.Name = "rdbt_C";
            this.rdbt_C.Size = new System.Drawing.Size(70, 17);
            this.rdbt_C.TabIndex = 2;
            this.rdbt_C.TabStop = true;
            this.rdbt_C.Text = "Đáp án C";
            this.rdbt_C.UseVisualStyleBackColor = true;
            this.rdbt_C.CheckedChanged += new System.EventHandler(this.rdbt_C_CheckedChanged);
            // 
            // rdbt_D
            // 
            this.rdbt_D.AutoSize = true;
            this.rdbt_D.Location = new System.Drawing.Point(96, 245);
            this.rdbt_D.Name = "rdbt_D";
            this.rdbt_D.Size = new System.Drawing.Size(71, 17);
            this.rdbt_D.TabIndex = 3;
            this.rdbt_D.TabStop = true;
            this.rdbt_D.Text = "Đáp án D";
            this.rdbt_D.UseVisualStyleBackColor = true;
            this.rdbt_D.CheckedChanged += new System.EventHandler(this.rdbt_D_CheckedChanged);
            // 
            // lb_CauHoi
            // 
            this.lb_CauHoi.AutoSize = true;
            this.lb_CauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CauHoi.Location = new System.Drawing.Point(109, 66);
            this.lb_CauHoi.Name = "lb_CauHoi";
            this.lb_CauHoi.Size = new System.Drawing.Size(69, 25);
            this.lb_CauHoi.TabIndex = 4;
            this.lb_CauHoi.Text = "Câu 1";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(386, 327);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 5;
            this.btn_Next.Text = "->";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(248, 327);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "<-";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Nop
            // 
            this.btn_Nop.Location = new System.Drawing.Point(552, 327);
            this.btn_Nop.Name = "btn_Nop";
            this.btn_Nop.Size = new System.Drawing.Size(75, 23);
            this.btn_Nop.TabIndex = 7;
            this.btn_Nop.Text = "Nộp bài";
            this.btn_Nop.UseVisualStyleBackColor = true;
            this.btn_Nop.Click += new System.EventHandler(this.btn_Nop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 394);
            this.Controls.Add(this.btn_Nop);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.lb_CauHoi);
            this.Controls.Add(this.rdbt_D);
            this.Controls.Add(this.rdbt_C);
            this.Controls.Add(this.rdbt_B);
            this.Controls.Add(this.rdbt_A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbt_A;
        private System.Windows.Forms.RadioButton rdbt_B;
        private System.Windows.Forms.RadioButton rdbt_C;
        private System.Windows.Forms.RadioButton rdbt_D;
        private System.Windows.Forms.Label lb_CauHoi;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Nop;
    }
}

