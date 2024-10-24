namespace OpenStackAPI_Web
{
    partial class MainApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.portaddressTb = new System.Windows.Forms.TextBox();
            this.networkaddressTb = new System.Windows.Forms.TextBox();
            this.subnetnameTb = new System.Windows.Forms.TextBox();
            this.networknameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.networkidTb = new System.Windows.Forms.TextBox();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.FavorsTb = new System.Windows.Forms.TextBox();
            this.ImageTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.createnetworkBt = new System.Windows.Forms.Button();
            this.imagelistBt = new System.Windows.Forms.Button();
            this.createinstanceBt = new System.Windows.Forms.Button();
            this.keypairlistBt = new System.Windows.Forms.Button();
            this.flavorslistBt = new System.Windows.Forms.Button();
            this.eventlogTb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createnetworkBt);
            this.groupBox1.Controls.Add(this.portaddressTb);
            this.groupBox1.Controls.Add(this.networkaddressTb);
            this.groupBox1.Controls.Add(this.subnetnameTb);
            this.groupBox1.Controls.Add(this.networknameTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network";
            // 
            // portaddressTb
            // 
            this.portaddressTb.Location = new System.Drawing.Point(124, 115);
            this.portaddressTb.Name = "portaddressTb";
            this.portaddressTb.Size = new System.Drawing.Size(191, 22);
            this.portaddressTb.TabIndex = 6;
            // 
            // networkaddressTb
            // 
            this.networkaddressTb.Location = new System.Drawing.Point(124, 83);
            this.networkaddressTb.Name = "networkaddressTb";
            this.networkaddressTb.Size = new System.Drawing.Size(191, 22);
            this.networkaddressTb.TabIndex = 5;
            // 
            // subnetnameTb
            // 
            this.subnetnameTb.Location = new System.Drawing.Point(124, 49);
            this.subnetnameTb.Name = "subnetnameTb";
            this.subnetnameTb.Size = new System.Drawing.Size(191, 22);
            this.subnetnameTb.TabIndex = 4;
            // 
            // networknameTb
            // 
            this.networknameTb.Location = new System.Drawing.Point(124, 15);
            this.networknameTb.Name = "networknameTb";
            this.networknameTb.Size = new System.Drawing.Size(191, 22);
            this.networknameTb.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Network address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subnet name:  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Network Name: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.createinstanceBt);
            this.groupBox2.Controls.Add(this.networkidTb);
            this.groupBox2.Controls.Add(this.NameTb);
            this.groupBox2.Controls.Add(this.FavorsTb);
            this.groupBox2.Controls.Add(this.ImageTb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instance";
            // 
            // networkidTb
            // 
            this.networkidTb.Location = new System.Drawing.Point(124, 133);
            this.networkidTb.Name = "networkidTb";
            this.networkidTb.Size = new System.Drawing.Size(191, 22);
            this.networkidTb.TabIndex = 10;
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(124, 101);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(191, 22);
            this.NameTb.TabIndex = 9;
            // 
            // FavorsTb
            // 
            this.FavorsTb.Location = new System.Drawing.Point(124, 66);
            this.FavorsTb.Name = "FavorsTb";
            this.FavorsTb.Size = new System.Drawing.Size(191, 22);
            this.FavorsTb.TabIndex = 8;
            // 
            // ImageTb
            // 
            this.ImageTb.Location = new System.Drawing.Point(124, 33);
            this.ImageTb.Name = "ImageTb";
            this.ImageTb.Size = new System.Drawing.Size(191, 22);
            this.ImageTb.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Favors: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Network ID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Image: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.eventlogTb);
            this.groupBox3.Location = new System.Drawing.Point(399, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 508);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flavorslistBt);
            this.groupBox4.Controls.Add(this.keypairlistBt);
            this.groupBox4.Controls.Add(this.imagelistBt);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(12, 444);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 62);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Name: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Network ID: ";
            // 
            // createnetworkBt
            // 
            this.createnetworkBt.Location = new System.Drawing.Point(19, 156);
            this.createnetworkBt.Name = "createnetworkBt";
            this.createnetworkBt.Size = new System.Drawing.Size(315, 42);
            this.createnetworkBt.TabIndex = 10;
            this.createnetworkBt.Text = "Create";
            this.createnetworkBt.UseVisualStyleBackColor = true;
            // 
            // imagelistBt
            // 
            this.imagelistBt.Location = new System.Drawing.Point(9, 14);
            this.imagelistBt.Name = "imagelistBt";
            this.imagelistBt.Size = new System.Drawing.Size(95, 42);
            this.imagelistBt.TabIndex = 11;
            this.imagelistBt.Text = "List Images";
            this.imagelistBt.UseVisualStyleBackColor = true;
            // 
            // createinstanceBt
            // 
            this.createinstanceBt.Location = new System.Drawing.Point(19, 161);
            this.createinstanceBt.Name = "createinstanceBt";
            this.createinstanceBt.Size = new System.Drawing.Size(315, 46);
            this.createinstanceBt.TabIndex = 12;
            this.createinstanceBt.Text = "Create";
            this.createinstanceBt.UseVisualStyleBackColor = true;
            // 
            // keypairlistBt
            // 
            this.keypairlistBt.Location = new System.Drawing.Point(124, 14);
            this.keypairlistBt.Name = "keypairlistBt";
            this.keypairlistBt.Size = new System.Drawing.Size(95, 42);
            this.keypairlistBt.TabIndex = 12;
            this.keypairlistBt.Text = "List keypair";
            this.keypairlistBt.UseVisualStyleBackColor = true;
            // 
            // flavorslistBt
            // 
            this.flavorslistBt.Location = new System.Drawing.Point(239, 14);
            this.flavorslistBt.Name = "flavorslistBt";
            this.flavorslistBt.Size = new System.Drawing.Size(95, 42);
            this.flavorslistBt.TabIndex = 13;
            this.flavorslistBt.Text = "List flavors";
            this.flavorslistBt.UseVisualStyleBackColor = true;
            // 
            // eventlogTb
            // 
            this.eventlogTb.Enabled = false;
            this.eventlogTb.Location = new System.Drawing.Point(3, 18);
            this.eventlogTb.Multiline = true;
            this.eventlogTb.Name = "eventlogTb";
            this.eventlogTb.ReadOnly = true;
            this.eventlogTb.Size = new System.Drawing.Size(572, 484);
            this.eventlogTb.TabIndex = 0;
            // 
            // MainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 532);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainApplication";
            this.Text = "MainApplication";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox portaddressTb;
        private System.Windows.Forms.TextBox networkaddressTb;
        private System.Windows.Forms.TextBox subnetnameTb;
        private System.Windows.Forms.TextBox networknameTb;
        private System.Windows.Forms.TextBox ImageTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox networkidTb;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.TextBox FavorsTb;
        private System.Windows.Forms.Button imagelistBt;
        private System.Windows.Forms.Button createnetworkBt;
        private System.Windows.Forms.Button createinstanceBt;
        private System.Windows.Forms.Button flavorslistBt;
        private System.Windows.Forms.Button keypairlistBt;
        private System.Windows.Forms.TextBox eventlogTb;
    }
}