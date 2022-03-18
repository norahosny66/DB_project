
namespace DB_project
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
            this.check_btn = new System.Windows.Forms.Button();
            this.txt_admin_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.show_price = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.meal_name_cmb = new System.Windows.Forms.ComboBox();
            this.meal_price = new System.Windows.Forms.TextBox();
            this.meal_name_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.meal_type = new System.Windows.Forms.Label();
            this.type_txt = new System.Windows.Forms.TextBox();
            this.txt_admin_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(268, 74);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(75, 23);
            this.check_btn.TabIndex = 1;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_admin_id
            // 
            this.txt_admin_id.Location = new System.Drawing.Point(141, 48);
            this.txt_admin_id.Name = "txt_admin_id";
            this.txt_admin_id.Size = new System.Drawing.Size(100, 20);
            this.txt_admin_id.TabIndex = 3;
            this.txt_admin_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin_id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "admin_name";
            // 
            // show_price
            // 
            this.show_price.Location = new System.Drawing.Point(407, 330);
            this.show_price.Name = "show_price";
            this.show_price.Size = new System.Drawing.Size(99, 23);
            this.show_price.TabIndex = 6;
            this.show_price.Text = "show meal price";
            this.show_price.UseVisualStyleBackColor = true;
            this.show_price.Click += new System.EventHandler(this.show_price_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(298, 330);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 7;
            this.insert_btn.Text = "insert meal";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // meal_name_cmb
            // 
            this.meal_name_cmb.FormattingEnabled = true;
            this.meal_name_cmb.Location = new System.Drawing.Point(338, 174);
            this.meal_name_cmb.Name = "meal_name_cmb";
            this.meal_name_cmb.Size = new System.Drawing.Size(121, 21);
            this.meal_name_cmb.TabIndex = 8;
            // 
            // meal_price
            // 
            this.meal_price.Location = new System.Drawing.Point(338, 219);
            this.meal_price.Name = "meal_price";
            this.meal_price.Size = new System.Drawing.Size(100, 20);
            this.meal_price.TabIndex = 9;
            this.meal_price.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // meal_name_label
            // 
            this.meal_name_label.AutoSize = true;
            this.meal_name_label.Location = new System.Drawing.Point(265, 177);
            this.meal_name_label.Name = "meal_name_label";
            this.meal_name_label.Size = new System.Drawing.Size(58, 13);
            this.meal_name_label.TabIndex = 10;
            this.meal_name_label.Text = "meal name";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(265, 226);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(55, 13);
            this.price_label.TabIndex = 11;
            this.price_label.Text = "meal price";
            // 
            // meal_type
            // 
            this.meal_type.AutoSize = true;
            this.meal_type.Location = new System.Drawing.Point(265, 269);
            this.meal_type.Name = "meal_type";
            this.meal_type.Size = new System.Drawing.Size(52, 13);
            this.meal_type.TabIndex = 12;
            this.meal_type.Text = "meal type";
            this.meal_type.Click += new System.EventHandler(this.label3_Click);
            // 
            // type_txt
            // 
            this.type_txt.Location = new System.Drawing.Point(338, 262);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(100, 20);
            this.type_txt.TabIndex = 13;
            // 
            // txt_admin_name
            // 
            this.txt_admin_name.Location = new System.Drawing.Point(141, 95);
            this.txt_admin_name.Name = "txt_admin_name";
            this.txt_admin_name.Size = new System.Drawing.Size(100, 20);
            this.txt_admin_name.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_admin_name);
            this.Controls.Add(this.type_txt);
            this.Controls.Add(this.meal_type);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.meal_name_label);
            this.Controls.Add(this.meal_price);
            this.Controls.Add(this.meal_name_cmb);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.show_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_admin_id);
            this.Controls.Add(this.check_btn);
            this.Name = "Form1";
            this.Text = "9";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.TextBox txt_admin_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button show_price;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.ComboBox meal_name_cmb;
        private System.Windows.Forms.TextBox meal_price;
        private System.Windows.Forms.Label meal_name_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label meal_type;
        private System.Windows.Forms.TextBox type_txt;
        private System.Windows.Forms.TextBox txt_admin_name;
    }
}

