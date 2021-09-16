using System.Drawing;

namespace TradingDataTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StockCodes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "欲取得資訊日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(160, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "起始日";
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(259, 104);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 29);
            this.StartDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "至";
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(698, 104);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(200, 29);
            this.EndDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(599, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "結束日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14F);
            this.label5.Location = new System.Drawing.Point(35, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "欲取得代號(多筆用逗號分隔)";
            // 
            // StockCodes
            // 
            this.StockCodes.Location = new System.Drawing.Point(164, 301);
            this.StockCodes.Multiline = true;
            this.StockCodes.Name = "StockCodes";
            this.StockCodes.Size = new System.Drawing.Size(734, 181);
            this.StockCodes.TabIndex = 7;
            this.StockCodes.Text = "範例: 0001,0002,0003";
            this.StockCodes.ForeColor = Color.Gray;
            this.StockCodes.Font = new System.Drawing.Font("新細明體", 12);
            this.StockCodes.LostFocus += new System.EventHandler(this.StockCodes_Blur);
            this.StockCodes.GotFocus += new System.EventHandler(this.StockCodes_Focus);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 575);
            this.Controls.Add(this.StockCodes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StockCodes;
    }
}

