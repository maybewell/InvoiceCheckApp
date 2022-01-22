namespace InvoiceCheckApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LablePrizeType = new System.Windows.Forms.Label();
            this.InputNumberBox = new System.Windows.Forms.TextBox();
            this.OneBtn = new System.Windows.Forms.Button();
            this.SecondBtn = new System.Windows.Forms.Button();
            this.ThirdBtn = new System.Windows.Forms.Button();
            this.LabelOfJackPot = new System.Windows.Forms.Label();
            this.LabelOfSpecialPrize = new System.Windows.Forms.Label();
            this.LabelOfVerySpecialPrize = new System.Windows.Forms.Label();
            this.LabelOfSixthPrize = new System.Windows.Forms.Label();
            this.LableOfCurrentInterval = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LablePrizeType
            // 
            this.LablePrizeType.AutoSize = true;
            this.LablePrizeType.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LablePrizeType.Location = new System.Drawing.Point(12, 316);
            this.LablePrizeType.Name = "LablePrizeType";
            this.LablePrizeType.Size = new System.Drawing.Size(90, 19);
            this.LablePrizeType.TabIndex = 0;
            this.LablePrizeType.Text = "中獎資訊:";
            // 
            // InputNumberBox
            // 
            this.InputNumberBox.Location = new System.Drawing.Point(174, 357);
            this.InputNumberBox.MaxLength = 3;
            this.InputNumberBox.Name = "InputNumberBox";
            this.InputNumberBox.Size = new System.Drawing.Size(100, 22);
            this.InputNumberBox.TabIndex = 1;
            this.InputNumberBox.TextChanged += new System.EventHandler(this.InputNumberBox_TextChanged);
            this.InputNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputNumberBox_KeyPress);
            // 
            // OneBtn
            // 
            this.OneBtn.AutoSize = true;
            this.OneBtn.Location = new System.Drawing.Point(12, 12);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(75, 23);
            this.OneBtn.TabIndex = 2;
            this.OneBtn.Text = "這一期";
            this.OneBtn.UseVisualStyleBackColor = true;
            this.OneBtn.Click += new System.EventHandler(this.SelectInterval);
            // 
            // SecondBtn
            // 
            this.SecondBtn.AutoSize = true;
            this.SecondBtn.Location = new System.Drawing.Point(151, 12);
            this.SecondBtn.Name = "SecondBtn";
            this.SecondBtn.Size = new System.Drawing.Size(75, 23);
            this.SecondBtn.TabIndex = 3;
            this.SecondBtn.Text = "上一期";
            this.SecondBtn.UseVisualStyleBackColor = true;
            this.SecondBtn.Click += new System.EventHandler(this.SelectInterval);
            // 
            // ThirdBtn
            // 
            this.ThirdBtn.AutoSize = true;
            this.ThirdBtn.Location = new System.Drawing.Point(290, 12);
            this.ThirdBtn.Name = "ThirdBtn";
            this.ThirdBtn.Size = new System.Drawing.Size(75, 23);
            this.ThirdBtn.TabIndex = 4;
            this.ThirdBtn.Text = "上上期";
            this.ThirdBtn.UseVisualStyleBackColor = true;
            this.ThirdBtn.Click += new System.EventHandler(this.SelectInterval);
            // 
            // LabelOfJackPot
            // 
            this.LabelOfJackPot.AutoSize = true;
            this.LabelOfJackPot.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelOfJackPot.Location = new System.Drawing.Point(12, 190);
            this.LabelOfJackPot.Name = "LabelOfJackPot";
            this.LabelOfJackPot.Size = new System.Drawing.Size(90, 19);
            this.LabelOfJackPot.TabIndex = 5;
            this.LabelOfJackPot.Text = "頭獎號碼:";
            // 
            // LabelOfSpecialPrize
            // 
            this.LabelOfSpecialPrize.AutoSize = true;
            this.LabelOfSpecialPrize.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelOfSpecialPrize.Location = new System.Drawing.Point(12, 147);
            this.LabelOfSpecialPrize.Name = "LabelOfSpecialPrize";
            this.LabelOfSpecialPrize.Size = new System.Drawing.Size(90, 19);
            this.LabelOfSpecialPrize.TabIndex = 6;
            this.LabelOfSpecialPrize.Text = "特獎號碼:";
            // 
            // LabelOfVerySpecialPrize
            // 
            this.LabelOfVerySpecialPrize.AutoSize = true;
            this.LabelOfVerySpecialPrize.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelOfVerySpecialPrize.Location = new System.Drawing.Point(12, 104);
            this.LabelOfVerySpecialPrize.Name = "LabelOfVerySpecialPrize";
            this.LabelOfVerySpecialPrize.Size = new System.Drawing.Size(109, 19);
            this.LabelOfVerySpecialPrize.TabIndex = 7;
            this.LabelOfVerySpecialPrize.Text = "特別獎號碼:";
            // 
            // LabelOfSixthPrize
            // 
            this.LabelOfSixthPrize.AutoSize = true;
            this.LabelOfSixthPrize.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelOfSixthPrize.Location = new System.Drawing.Point(12, 233);
            this.LabelOfSixthPrize.Name = "LabelOfSixthPrize";
            this.LabelOfSixthPrize.Size = new System.Drawing.Size(90, 19);
            this.LabelOfSixthPrize.TabIndex = 8;
            this.LabelOfSixthPrize.Text = "六獎號碼:";
            // 
            // LableOfCurrentInterval
            // 
            this.LableOfCurrentInterval.AutoSize = true;
            this.LableOfCurrentInterval.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LableOfCurrentInterval.Location = new System.Drawing.Point(12, 59);
            this.LableOfCurrentInterval.Name = "LableOfCurrentInterval";
            this.LableOfCurrentInterval.Size = new System.Drawing.Size(128, 19);
            this.LableOfCurrentInterval.TabIndex = 9;
            this.LableOfCurrentInterval.Text = "目前選擇期數:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "請輸入發票末3碼:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LableOfCurrentInterval);
            this.Controls.Add(this.LabelOfSixthPrize);
            this.Controls.Add(this.LabelOfVerySpecialPrize);
            this.Controls.Add(this.LabelOfSpecialPrize);
            this.Controls.Add(this.LabelOfJackPot);
            this.Controls.Add(this.ThirdBtn);
            this.Controls.Add(this.SecondBtn);
            this.Controls.Add(this.OneBtn);
            this.Controls.Add(this.InputNumberBox);
            this.Controls.Add(this.LablePrizeType);
            this.Name = "Form1";
            this.Text = "發票兌獎App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LablePrizeType;
        private System.Windows.Forms.TextBox InputNumberBox;
        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button SecondBtn;
        private System.Windows.Forms.Button ThirdBtn;
        private System.Windows.Forms.Label LabelOfJackPot;
        private System.Windows.Forms.Label LabelOfSpecialPrize;
        private System.Windows.Forms.Label LabelOfVerySpecialPrize;
        private System.Windows.Forms.Label LabelOfSixthPrize;
        private System.Windows.Forms.Label LableOfCurrentInterval;
        private System.Windows.Forms.Label label1;
    }
}

