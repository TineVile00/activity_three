namespace WindowsFormsApplication4
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
            this.survey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.netherLand = new System.Windows.Forms.CheckBox();
            this.australia = new System.Windows.Forms.CheckBox();
            this.india = new System.Windows.Forms.CheckBox();
            this.hongKong = new System.Windows.Forms.CheckBox();
            this.othersLabel = new System.Windows.Forms.Label();
            this.otherTxtBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.othersBox = new System.Windows.Forms.CheckBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // survey
            // 
            this.survey.AutoSize = true;
            this.survey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.survey.Location = new System.Drawing.Point(27, 30);
            this.survey.Name = "survey";
            this.survey.Size = new System.Drawing.Size(80, 26);
            this.survey.TabIndex = 0;
            this.survey.Text = "Survey";
            this.survey.Click += new System.EventHandler(this.survey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(29, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "What country would you like to visit?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // netherLand
            // 
            this.netherLand.AutoSize = true;
            this.netherLand.Location = new System.Drawing.Point(32, 120);
            this.netherLand.Name = "netherLand";
            this.netherLand.Size = new System.Drawing.Size(83, 17);
            this.netherLand.TabIndex = 2;
            this.netherLand.Text = "Netherlands";
            this.netherLand.UseVisualStyleBackColor = true;
            // 
            // australia
            // 
            this.australia.AutoSize = true;
            this.australia.Location = new System.Drawing.Point(32, 156);
            this.australia.Name = "australia";
            this.australia.Size = new System.Drawing.Size(66, 17);
            this.australia.TabIndex = 3;
            this.australia.Text = "Australia";
            this.australia.UseVisualStyleBackColor = true;
            // 
            // india
            // 
            this.india.AutoSize = true;
            this.india.Location = new System.Drawing.Point(160, 156);
            this.india.Name = "india";
            this.india.Size = new System.Drawing.Size(49, 17);
            this.india.TabIndex = 4;
            this.india.Text = "India";
            this.india.UseVisualStyleBackColor = true;
            // 
            // hongKong
            // 
            this.hongKong.AutoSize = true;
            this.hongKong.Location = new System.Drawing.Point(160, 120);
            this.hongKong.Name = "hongKong";
            this.hongKong.Size = new System.Drawing.Size(76, 17);
            this.hongKong.TabIndex = 5;
            this.hongKong.Text = "Hongkong";
            this.hongKong.UseVisualStyleBackColor = true;
            // 
            // othersLabel
            // 
            this.othersLabel.AutoSize = true;
            this.othersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.othersLabel.Location = new System.Drawing.Point(29, 251);
            this.othersLabel.Name = "othersLabel";
            this.othersLabel.Size = new System.Drawing.Size(163, 18);
            this.othersLabel.TabIndex = 6;
            this.othersLabel.Text = "If Other, Please specify:";
            this.othersLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // otherTxtBox
            // 
            this.otherTxtBox.Location = new System.Drawing.Point(32, 285);
            this.otherTxtBox.Name = "otherTxtBox";
            this.otherTxtBox.Size = new System.Drawing.Size(176, 20);
            this.otherTxtBox.TabIndex = 7;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(59, 357);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(176, 357);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // othersBox
            // 
            this.othersBox.AutoSize = true;
            this.othersBox.Location = new System.Drawing.Point(32, 190);
            this.othersBox.Name = "othersBox";
            this.othersBox.Size = new System.Drawing.Size(57, 17);
            this.othersBox.TabIndex = 10;
            this.othersBox.Text = "Others";
            this.othersBox.UseVisualStyleBackColor = true;
            this.othersBox.CheckedChanged += new System.EventHandler(this.othersBox_CheckedChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(295, 357);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 400);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.othersBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.otherTxtBox);
            this.Controls.Add(this.othersLabel);
            this.Controls.Add(this.hongKong);
            this.Controls.Add(this.india);
            this.Controls.Add(this.australia);
            this.Controls.Add(this.netherLand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.survey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label survey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox netherLand;
        private System.Windows.Forms.CheckBox australia;
        private System.Windows.Forms.CheckBox india;
        private System.Windows.Forms.CheckBox hongKong;
        private System.Windows.Forms.Label othersLabel;
        private System.Windows.Forms.TextBox otherTxtBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.CheckBox othersBox;
        private System.Windows.Forms.Button clearBtn;

    }
}

