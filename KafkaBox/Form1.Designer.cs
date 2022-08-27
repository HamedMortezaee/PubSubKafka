namespace KafkaBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_publish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richtxt_publish = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_topic_publish = new System.Windows.Forms.TextBox();
            this.btn_subscribe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_subscribe = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_topic_subscribe = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_kafka_ddress = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_publish);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.richtxt_publish);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_topic_publish);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "publish";
            // 
            // btn_publish
            // 
            this.btn_publish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_publish.Location = new System.Drawing.Point(16, 350);
            this.btn_publish.Name = "btn_publish";
            this.btn_publish.Size = new System.Drawing.Size(83, 32);
            this.btn_publish.TabIndex = 4;
            this.btn_publish.Text = "Publish";
            this.btn_publish.UseVisualStyleBackColor = false;
            this.btn_publish.Click += new System.EventHandler(this.btn_publish_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Payload";
            // 
            // richtxt_publish
            // 
            this.richtxt_publish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richtxt_publish.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richtxt_publish.Location = new System.Drawing.Point(16, 126);
            this.richtxt_publish.Name = "richtxt_publish";
            this.richtxt_publish.Size = new System.Drawing.Size(369, 206);
            this.richtxt_publish.TabIndex = 2;
            this.richtxt_publish.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Topic to publish";
            // 
            // txt_topic_publish
            // 
            this.txt_topic_publish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_topic_publish.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_topic_publish.Location = new System.Drawing.Point(16, 61);
            this.txt_topic_publish.Name = "txt_topic_publish";
            this.txt_topic_publish.Size = new System.Drawing.Size(369, 23);
            this.txt_topic_publish.TabIndex = 0;
            // 
            // btn_subscribe
            // 
            this.btn_subscribe.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_subscribe.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_subscribe.Location = new System.Drawing.Point(15, 350);
            this.btn_subscribe.Name = "btn_subscribe";
            this.btn_subscribe.Size = new System.Drawing.Size(111, 32);
            this.btn_subscribe.TabIndex = 5;
            this.btn_subscribe.Text = "Subbscribe";
            this.btn_subscribe.UseVisualStyleBackColor = false;
            this.btn_subscribe.Click += new System.EventHandler(this.btn_subscribe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_subscribe);
            this.groupBox2.Controls.Add(this.btn_subscribe);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_topic_subscribe);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox2.Location = new System.Drawing.Point(451, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 388);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "subscribe";
            // 
            // listBox_subscribe
            // 
            this.listBox_subscribe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_subscribe.FormattingEnabled = true;
            this.listBox_subscribe.ItemHeight = 15;
            this.listBox_subscribe.Location = new System.Drawing.Point(15, 139);
            this.listBox_subscribe.Name = "listBox_subscribe";
            this.listBox_subscribe.Size = new System.Drawing.Size(369, 184);
            this.listBox_subscribe.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(15, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subscribe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Topic to subscribe";
            // 
            // txt_topic_subscribe
            // 
            this.txt_topic_subscribe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_topic_subscribe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_topic_subscribe.Location = new System.Drawing.Point(15, 61);
            this.txt_topic_subscribe.Name = "txt_topic_subscribe";
            this.txt_topic_subscribe.Size = new System.Drawing.Size(369, 23);
            this.txt_topic_subscribe.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_kafka_ddress);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(838, 113);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kafka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(16, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kafka address";
            // 
            // txt_kafka_ddress
            // 
            this.txt_kafka_ddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_kafka_ddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_kafka_ddress.Location = new System.Drawing.Point(16, 61);
            this.txt_kafka_ddress.Name = "txt_kafka_ddress";
            this.txt_kafka_ddress.Size = new System.Drawing.Size(369, 23);
            this.txt_kafka_ddress.TabIndex = 0;
            this.txt_kafka_ddress.Text = "http://localhost:9092";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 606);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kafka";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txt_topic_publish;
        private Label label1;
        private Label label3;
        private RichTextBox richtxt_publish;
        private Label label2;
        private TextBox txt_topic_subscribe;
        private Button btn_publish;
        private Label label4;
        private GroupBox groupBox3;
        private Label label6;
        private TextBox txt_kafka_ddress;
        private Button btn_subscribe;
        private ListBox listBox_subscribe;
    }
}