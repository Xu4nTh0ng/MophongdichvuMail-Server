namespace client2
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
            this.preview_richtextbox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subject_textbox = new System.Windows.Forms.TextBox();
            this.sender_textbox = new System.Windows.Forms.TextBox();
            this.recipient_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.send_button = new System.Windows.Forms.Button();
            this.body_richtextbox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recipient_name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // preview_richtextbox
            // 
            this.preview_richtextbox.Location = new System.Drawing.Point(9, 21);
            this.preview_richtextbox.Name = "preview_richtextbox";
            this.preview_richtextbox.ReadOnly = true;
            this.preview_richtextbox.Size = new System.Drawing.Size(375, 444);
            this.preview_richtextbox.TabIndex = 8;
            this.preview_richtextbox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.preview_richtextbox);
            this.groupBox2.Location = new System.Drawing.Point(406, -15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 480);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.subject_textbox);
            this.groupBox1.Controls.Add(this.sender_textbox);
            this.groupBox1.Controls.Add(this.recipient_textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.send_button);
            this.groupBox1.Controls.Add(this.body_richtextbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.recipient_name);
            this.groupBox1.Location = new System.Drawing.Point(5, -15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 480);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send";
            // 
            // subject_textbox
            // 
            this.subject_textbox.Location = new System.Drawing.Point(97, 144);
            this.subject_textbox.Name = "subject_textbox";
            this.subject_textbox.Size = new System.Drawing.Size(261, 23);
            this.subject_textbox.TabIndex = 1;
            // 
            // sender_textbox
            // 
            this.sender_textbox.Location = new System.Drawing.Point(97, 37);
            this.sender_textbox.Name = "sender_textbox";
            this.sender_textbox.ReadOnly = true;
            this.sender_textbox.Size = new System.Drawing.Size(261, 23);
            this.sender_textbox.TabIndex = 12;
            // 
            // recipient_textbox
            // 
            this.recipient_textbox.Location = new System.Drawing.Point(97, 97);
            this.recipient_textbox.Name = "recipient_textbox";
            this.recipient_textbox.Size = new System.Drawing.Size(261, 23);
            this.recipient_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(240, 427);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(129, 38);
            this.send_button.TabIndex = 8;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // body_richtextbox
            // 
            this.body_richtextbox.Location = new System.Drawing.Point(25, 266);
            this.body_richtextbox.Name = "body_richtextbox";
            this.body_richtextbox.Size = new System.Drawing.Size(344, 155);
            this.body_richtextbox.TabIndex = 3;
            this.body_richtextbox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Body:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Embed file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject:";
            // 
            // recipient_name
            // 
            this.recipient_name.AutoSize = true;
            this.recipient_name.Location = new System.Drawing.Point(25, 100);
            this.recipient_name.Name = "recipient_name";
            this.recipient_name.Size = new System.Drawing.Size(59, 15);
            this.recipient_name.TabIndex = 2;
            this.recipient_name.Text = "Recipient:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox preview_richtextbox;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox subject_textbox;
        private TextBox sender_textbox;
        private TextBox recipient_textbox;
        private Label label1;
        private Button button2;
        private Button send_button;
        private RichTextBox body_richtextbox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        public Label recipient_name;
        private Button button1;
    }
}