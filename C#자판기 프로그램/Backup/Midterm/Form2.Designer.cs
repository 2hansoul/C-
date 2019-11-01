namespace Midterm
{
    partial class Form2
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bnameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bpriceLabel = new System.Windows.Forms.Label();
            this.bquantityLabel = new System.Windows.Forms.Label();
            this.keepgoingButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "선택하신 음료수 :";
            // 
            // bnameLabel
            // 
            this.bnameLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.bnameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bnameLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnameLabel.Location = new System.Drawing.Point(130, 14);
            this.bnameLabel.Name = "bnameLabel";
            this.bnameLabel.Size = new System.Drawing.Size(106, 18);
            this.bnameLabel.TabIndex = 1;
            this.bnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(83, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "수량 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(83, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "금액 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bpriceLabel);
            this.groupBox1.Controls.Add(this.bquantityLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bnameLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // bpriceLabel
            // 
            this.bpriceLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.bpriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bpriceLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bpriceLabel.Location = new System.Drawing.Point(130, 93);
            this.bpriceLabel.Name = "bpriceLabel";
            this.bpriceLabel.Size = new System.Drawing.Size(106, 21);
            this.bpriceLabel.TabIndex = 5;
            this.bpriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bquantityLabel
            // 
            this.bquantityLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.bquantityLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bquantityLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bquantityLabel.Location = new System.Drawing.Point(130, 53);
            this.bquantityLabel.Name = "bquantityLabel";
            this.bquantityLabel.Size = new System.Drawing.Size(106, 18);
            this.bquantityLabel.TabIndex = 4;
            this.bquantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keepgoingButton
            // 
            this.keepgoingButton.Location = new System.Drawing.Point(145, 153);
            this.keepgoingButton.Name = "keepgoingButton";
            this.keepgoingButton.Size = new System.Drawing.Size(107, 30);
            this.keepgoingButton.TabIndex = 6;
            this.keepgoingButton.Text = "계속주문하기";
            this.keepgoingButton.UseVisualStyleBackColor = true;
            this.keepgoingButton.Click += new System.EventHandler(this.keepgoingButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(259, 191);
            this.Controls.Add(this.keepgoingButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "음료 선택 현황";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bnameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label bpriceLabel;
        private System.Windows.Forms.Label bquantityLabel;
        private System.Windows.Forms.Button keepgoingButton;
    }
}