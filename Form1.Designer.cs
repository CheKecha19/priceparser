
namespace priceparser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progress_obnovleniya_dannih = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progress_obnovleniya_stranitsy = new System.Windows.Forms.ProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.saver = new System.Windows.Forms.CheckBox();
            this.auto_check = new System.Windows.Forms.CheckBox();
            this.ALL_button = new System.Windows.Forms.RadioButton();
            this.MOE_button = new System.Windows.Forms.RadioButton();
            this.LOE_button = new System.Windows.Forms.RadioButton();
            this.coin = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.time_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.drop_link = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.drop_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drop_name = new System.Windows.Forms.TextBox();
            this.find_button_1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progress_obnovleniya_dannih
            // 
            this.progress_obnovleniya_dannih.ForeColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.progress_obnovleniya_dannih, "progress_obnovleniya_dannih");
            this.progress_obnovleniya_dannih.Name = "progress_obnovleniya_dannih";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // progress_obnovleniya_stranitsy
            // 
            this.progress_obnovleniya_stranitsy.ForeColor = System.Drawing.Color.Aqua;
            resources.ApplyResources(this.progress_obnovleniya_stranitsy, "progress_obnovleniya_stranitsy");
            this.progress_obnovleniya_stranitsy.Name = "progress_obnovleniya_stranitsy";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.saver);
            this.splitContainer1.Panel1.Controls.Add(this.auto_check);
            this.splitContainer1.Panel1.Controls.Add(this.ALL_button);
            this.splitContainer1.Panel1.Controls.Add(this.MOE_button);
            this.splitContainer1.Panel1.Controls.Add(this.LOE_button);
            this.splitContainer1.Panel1.Controls.Add(this.coin);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.time_text);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.drop_link);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.drop_price);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.drop_name);
            this.splitContainer1.Panel1.Controls.Add(this.find_button_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            // 
            // saver
            // 
            resources.ApplyResources(this.saver, "saver");
            this.saver.Name = "saver";
            this.saver.UseVisualStyleBackColor = true;
            // 
            // auto_check
            // 
            resources.ApplyResources(this.auto_check, "auto_check");
            this.auto_check.Name = "auto_check";
            this.auto_check.UseVisualStyleBackColor = true;
            // 
            // ALL_button
            // 
            resources.ApplyResources(this.ALL_button, "ALL_button");
            this.ALL_button.Name = "ALL_button";
            this.ALL_button.TabStop = true;
            this.ALL_button.UseVisualStyleBackColor = true;
            // 
            // MOE_button
            // 
            resources.ApplyResources(this.MOE_button, "MOE_button");
            this.MOE_button.Name = "MOE_button";
            this.MOE_button.TabStop = true;
            this.MOE_button.UseVisualStyleBackColor = true;
            // 
            // LOE_button
            // 
            resources.ApplyResources(this.LOE_button, "LOE_button");
            this.LOE_button.Name = "LOE_button";
            this.LOE_button.TabStop = true;
            this.LOE_button.UseVisualStyleBackColor = true;
            // 
            // coin
            // 
            this.coin.FormattingEnabled = true;
            this.coin.Items.AddRange(new object[] {
            resources.GetString("coin.Items"),
            resources.GetString("coin.Items1"),
            resources.GetString("coin.Items2")});
            resources.ApplyResources(this.coin, "coin");
            this.coin.Name = "coin";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Name = "label8";
            // 
            // time_text
            // 
            resources.ApplyResources(this.time_text, "time_text");
            this.time_text.Name = "time_text";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Name = "label7";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // drop_link
            // 
            resources.ApplyResources(this.drop_link, "drop_link");
            this.drop_link.Name = "drop_link";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Name = "label6";
            // 
            // drop_price
            // 
            resources.ApplyResources(this.drop_price, "drop_price");
            this.drop_price.Name = "drop_price";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Name = "label3";
            // 
            // drop_name
            // 
            resources.ApplyResources(this.drop_name, "drop_name");
            this.drop_name.Name = "drop_name";
            // 
            // find_button_1
            // 
            resources.ApplyResources(this.find_button_1, "find_button_1");
            this.find_button_1.Name = "find_button_1";
            this.find_button_1.UseVisualStyleBackColor = true;
            this.find_button_1.Click += new System.EventHandler(this.find_button_1_Click);
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.progress_obnovleniya_stranitsy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progress_obnovleniya_dannih);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progress_obnovleniya_dannih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progress_obnovleniya_stranitsy;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox drop_name;
        private System.Windows.Forms.Button find_button_1;
        private System.Windows.Forms.TextBox drop_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox drop_link;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox coin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox time_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton ALL_button;
        private System.Windows.Forms.RadioButton MOE_button;
        private System.Windows.Forms.RadioButton LOE_button;
        private System.Windows.Forms.CheckBox auto_check;
        private System.Windows.Forms.CheckBox saver;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

