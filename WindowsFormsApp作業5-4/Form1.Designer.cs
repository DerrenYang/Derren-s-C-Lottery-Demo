namespace WindowsFormsApp作業5_4
{
    partial class form1
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
            this.components = new System.ComponentModel.Container();
            this.lb選號 = new System.Windows.Forms.Label();
            this.btn隨機選號 = new System.Windows.Forms.Button();
            this.btn開獎 = new System.Windows.Forms.Button();
            this.lb開獎號碼 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.lb11 = new System.Windows.Forms.Label();
            this.lb12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.timer10 = new System.Windows.Forms.Timer(this.components);
            this.timer11 = new System.Windows.Forms.Timer(this.components);
            this.timer12 = new System.Windows.Forms.Timer(this.components);
            this.btn中獎結果 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb回應訊息 = new System.Windows.Forms.Label();
            this.lb跑馬燈 = new System.Windows.Forms.Label();
            this.timer13 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb選號
            // 
            this.lb選號.BackColor = System.Drawing.Color.White;
            this.lb選號.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb選號.Location = new System.Drawing.Point(328, 125);
            this.lb選號.Name = "lb選號";
            this.lb選號.Size = new System.Drawing.Size(444, 28);
            this.lb選號.TabIndex = 0;
            this.lb選號.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn隨機選號
            // 
            this.btn隨機選號.BackColor = System.Drawing.Color.Silver;
            this.btn隨機選號.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn隨機選號.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn隨機選號.Location = new System.Drawing.Point(60, 356);
            this.btn隨機選號.Name = "btn隨機選號";
            this.btn隨機選號.Size = new System.Drawing.Size(246, 39);
            this.btn隨機選號.TabIndex = 1;
            this.btn隨機選號.Text = "隨機選號";
            this.btn隨機選號.UseVisualStyleBackColor = false;
            this.btn隨機選號.Click += new System.EventHandler(this.btn隨機選號_Click);
            // 
            // btn開獎
            // 
            this.btn開獎.BackColor = System.Drawing.Color.Maroon;
            this.btn開獎.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn開獎.ForeColor = System.Drawing.Color.White;
            this.btn開獎.Location = new System.Drawing.Point(469, 187);
            this.btn開獎.Name = "btn開獎";
            this.btn開獎.Size = new System.Drawing.Size(168, 39);
            this.btn開獎.TabIndex = 2;
            this.btn開獎.Text = "開出本期號碼";
            this.btn開獎.UseVisualStyleBackColor = false;
            this.btn開獎.Click += new System.EventHandler(this.btn開獎_Click);
            // 
            // lb開獎號碼
            // 
            this.lb開獎號碼.BackColor = System.Drawing.Color.White;
            this.lb開獎號碼.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb開獎號碼.Location = new System.Drawing.Point(328, 417);
            this.lb開獎號碼.Name = "lb開獎號碼";
            this.lb開獎號碼.Size = new System.Drawing.Size(444, 28);
            this.lb開獎號碼.TabIndex = 3;
            this.lb開獎號碼.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.White;
            this.lb1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb1.ForeColor = System.Drawing.Color.Black;
            this.lb1.Location = new System.Drawing.Point(331, 246);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(58, 56);
            this.lb1.TabIndex = 4;
            this.lb1.Text = "?";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.Color.White;
            this.lb2.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb2.Location = new System.Drawing.Point(410, 246);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(58, 56);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "?";
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3
            // 
            this.lb3.BackColor = System.Drawing.Color.White;
            this.lb3.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb3.Location = new System.Drawing.Point(490, 246);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(58, 56);
            this.lb3.TabIndex = 6;
            this.lb3.Text = "?";
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb4
            // 
            this.lb4.BackColor = System.Drawing.Color.White;
            this.lb4.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb4.Location = new System.Drawing.Point(566, 246);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(58, 56);
            this.lb4.TabIndex = 7;
            this.lb4.Text = "?";
            this.lb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb5
            // 
            this.lb5.BackColor = System.Drawing.Color.White;
            this.lb5.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb5.Location = new System.Drawing.Point(641, 246);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(58, 56);
            this.lb5.TabIndex = 8;
            this.lb5.Text = "?";
            this.lb5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb6
            // 
            this.lb6.BackColor = System.Drawing.Color.White;
            this.lb6.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb6.Location = new System.Drawing.Point(714, 246);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(58, 56);
            this.lb6.TabIndex = 9;
            this.lb6.Text = "?";
            this.lb6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb7
            // 
            this.lb7.BackColor = System.Drawing.Color.White;
            this.lb7.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb7.Location = new System.Drawing.Point(331, 324);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(58, 56);
            this.lb7.TabIndex = 10;
            this.lb7.Text = "?";
            this.lb7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb8
            // 
            this.lb8.BackColor = System.Drawing.Color.White;
            this.lb8.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb8.Location = new System.Drawing.Point(410, 324);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(58, 56);
            this.lb8.TabIndex = 11;
            this.lb8.Text = "?";
            this.lb8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb9
            // 
            this.lb9.BackColor = System.Drawing.Color.White;
            this.lb9.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb9.Location = new System.Drawing.Point(490, 324);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(58, 56);
            this.lb9.TabIndex = 12;
            this.lb9.Text = "?";
            this.lb9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb10
            // 
            this.lb10.BackColor = System.Drawing.Color.White;
            this.lb10.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb10.Location = new System.Drawing.Point(566, 324);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(58, 56);
            this.lb10.TabIndex = 13;
            this.lb10.Text = "?";
            this.lb10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb11
            // 
            this.lb11.BackColor = System.Drawing.Color.White;
            this.lb11.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb11.Location = new System.Drawing.Point(641, 324);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(58, 56);
            this.lb11.TabIndex = 14;
            this.lb11.Text = "?";
            this.lb11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb12
            // 
            this.lb12.BackColor = System.Drawing.Color.White;
            this.lb12.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb12.Location = new System.Drawing.Point(714, 324);
            this.lb12.Name = "lb12";
            this.lb12.Size = new System.Drawing.Size(58, 56);
            this.lb12.TabIndex = 15;
            this.lb12.Text = "?";
            this.lb12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // timer8
            // 
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // timer9
            // 
            this.timer9.Tick += new System.EventHandler(this.timer9_Tick);
            // 
            // timer10
            // 
            this.timer10.Tick += new System.EventHandler(this.timer10_Tick);
            // 
            // timer11
            // 
            this.timer11.Tick += new System.EventHandler(this.timer11_Tick);
            // 
            // timer12
            // 
            this.timer12.Tick += new System.EventHandler(this.timer12_Tick);
            // 
            // btn中獎結果
            // 
            this.btn中獎結果.BackColor = System.Drawing.Color.DarkRed;
            this.btn中獎結果.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn中獎結果.ForeColor = System.Drawing.Color.White;
            this.btn中獎結果.Location = new System.Drawing.Point(469, 471);
            this.btn中獎結果.Name = "btn中獎結果";
            this.btn中獎結果.Size = new System.Drawing.Size(155, 49);
            this.btn中獎結果.TabIndex = 16;
            this.btn中獎結果.Text = "中獎結果";
            this.btn中獎結果.UseVisualStyleBackColor = false;
            this.btn中獎結果.Click += new System.EventHandler(this.btn中獎結果_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(443, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "您的號碼";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb回應訊息
            // 
            this.lb回應訊息.BackColor = System.Drawing.Color.Black;
            this.lb回應訊息.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb回應訊息.ForeColor = System.Drawing.Color.Gold;
            this.lb回應訊息.Location = new System.Drawing.Point(60, 417);
            this.lb回應訊息.Name = "lb回應訊息";
            this.lb回應訊息.Size = new System.Drawing.Size(246, 103);
            this.lb回應訊息.TabIndex = 18;
            // 
            // lb跑馬燈
            // 
            this.lb跑馬燈.BackColor = System.Drawing.Color.Black;
            this.lb跑馬燈.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb跑馬燈.ForeColor = System.Drawing.Color.White;
            this.lb跑馬燈.Location = new System.Drawing.Point(0, 9);
            this.lb跑馬燈.Name = "lb跑馬燈";
            this.lb跑馬燈.Size = new System.Drawing.Size(491, 58);
            this.lb跑馬燈.TabIndex = 19;
            this.lb跑馬燈.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer13
            // 
            this.timer13.Tick += new System.EventHandler(this.timer13_Tick);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(838, 558);
            this.Controls.Add(this.lb跑馬燈);
            this.Controls.Add(this.lb回應訊息);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn中獎結果);
            this.Controls.Add(this.lb12);
            this.Controls.Add(this.lb11);
            this.Controls.Add(this.lb10);
            this.Controls.Add(this.lb9);
            this.Controls.Add(this.lb8);
            this.Controls.Add(this.lb7);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lb開獎號碼);
            this.Controls.Add(this.btn開獎);
            this.Controls.Add(this.btn隨機選號);
            this.Controls.Add(this.lb選號);
            this.Name = "form1";
            this.Text = "雙贏彩迎財神";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb選號;
        private System.Windows.Forms.Button btn隨機選號;
        private System.Windows.Forms.Button btn開獎;
        private System.Windows.Forms.Label lb開獎號碼;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.Label lb12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Timer timer9;
        private System.Windows.Forms.Timer timer10;
        private System.Windows.Forms.Timer timer11;
        private System.Windows.Forms.Timer timer12;
        private System.Windows.Forms.Button btn中獎結果;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb回應訊息;
        private System.Windows.Forms.Label lb跑馬燈;
        private System.Windows.Forms.Timer timer13;
    }
}

