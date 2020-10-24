using System;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    partial class VillageWindow
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
            System.Windows.Forms.Label MenuTopLabel;
            this.drawing_space = new System.Windows.Forms.Panel();
            this.menuBar = new System.Windows.Forms.Panel();
            this.water_btn = new System.Windows.Forms.RadioButton();
            this.tree_btn = new System.Windows.Forms.RadioButton();
            this.House_btn = new System.Windows.Forms.RadioButton();
            this.open_village_btn = new System.Windows.Forms.Button();
            this.save_village_btn = new System.Windows.Forms.Button();
            this.new_village_btn = new System.Windows.Forms.Button();
            this.NationlistBox = new System.Windows.Forms.ListBox();
            this.Village_name_textBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            MenuTopLabel = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTopLabel
            // 
            MenuTopLabel.AutoSize = true;
            MenuTopLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            MenuTopLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            MenuTopLabel.Location = new System.Drawing.Point(42, 30);
            MenuTopLabel.Name = "MenuTopLabel";
            MenuTopLabel.Size = new System.Drawing.Size(167, 24);
            MenuTopLabel.TabIndex = 0;
            MenuTopLabel.Text = "Age of Villagers";
            MenuTopLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // drawing_space
            // 
            this.drawing_space.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawing_space.Location = new System.Drawing.Point(0, 0);
            this.drawing_space.Name = "drawing_space";
            this.drawing_space.Size = new System.Drawing.Size(600, 400);
            this.drawing_space.TabIndex = 0;
            this.drawing_space.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawing_space_MouseClick);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuBar.Controls.Add(this.water_btn);
            this.menuBar.Controls.Add(this.tree_btn);
            this.menuBar.Controls.Add(this.House_btn);
            this.menuBar.Controls.Add(this.open_village_btn);
            this.menuBar.Controls.Add(this.save_village_btn);
            this.menuBar.Controls.Add(this.new_village_btn);
            this.menuBar.Controls.Add(this.NationlistBox);
            this.menuBar.Controls.Add(this.Village_name_textBox);
            this.menuBar.Controls.Add(MenuTopLabel);
            this.menuBar.Location = new System.Drawing.Point(600, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(248, 400);
            this.menuBar.TabIndex = 1;
            // 
            // water_btn
            // 
            this.water_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.water_btn.AutoSize = true;
            this.water_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.water_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.water_btn.Location = new System.Drawing.Point(46, 260);
            this.water_btn.Name = "water_btn";
            this.water_btn.Size = new System.Drawing.Size(106, 20);
            this.water_btn.TabIndex = 8;
            this.water_btn.Text = "Water Source";
            this.water_btn.UseVisualStyleBackColor = true;
            // 
            // tree_btn
            // 
            this.tree_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.tree_btn.AutoSize = true;
            this.tree_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tree_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tree_btn.Location = new System.Drawing.Point(46, 234);
            this.tree_btn.Name = "tree_btn";
            this.tree_btn.Size = new System.Drawing.Size(51, 20);
            this.tree_btn.TabIndex = 7;
            this.tree_btn.Text = "Tree";
            this.tree_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tree_btn.UseVisualStyleBackColor = true;
            // 
            // House_btn
            // 
            this.House_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.House_btn.AutoSize = true;
            this.House_btn.BackColor = System.Drawing.Color.Transparent;
            this.House_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.House_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.House_btn.Location = new System.Drawing.Point(46, 208);
            this.House_btn.Name = "House_btn";
            this.House_btn.Size = new System.Drawing.Size(63, 20);
            this.House_btn.TabIndex = 6;
            this.House_btn.Text = "House";
            this.House_btn.UseVisualStyleBackColor = false;
            // 
            // open_village_btn
            // 
            this.open_village_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.open_village_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_village_btn.Location = new System.Drawing.Point(123, 349);
            this.open_village_btn.Name = "open_village_btn";
            this.open_village_btn.Padding = new System.Windows.Forms.Padding(2);
            this.open_village_btn.Size = new System.Drawing.Size(86, 30);
            this.open_village_btn.TabIndex = 5;
            this.open_village_btn.Text = "Open Village";
            this.open_village_btn.UseVisualStyleBackColor = false;
            this.open_village_btn.Click += new System.EventHandler(this.open_village_btn_Click);
            // 
            // save_village_btn
            // 
            this.save_village_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.save_village_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_village_btn.Location = new System.Drawing.Point(77, 313);
            this.save_village_btn.Name = "save_village_btn";
            this.save_village_btn.Padding = new System.Windows.Forms.Padding(2);
            this.save_village_btn.Size = new System.Drawing.Size(86, 30);
            this.save_village_btn.TabIndex = 4;
            this.save_village_btn.Text = "Save Village";
            this.save_village_btn.UseVisualStyleBackColor = false;
            this.save_village_btn.Click += new System.EventHandler(this.save_village_btn_Click);
            // 
            // new_village_btn
            // 
            this.new_village_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.new_village_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_village_btn.Location = new System.Drawing.Point(31, 349);
            this.new_village_btn.Name = "new_village_btn";
            this.new_village_btn.Padding = new System.Windows.Forms.Padding(2);
            this.new_village_btn.Size = new System.Drawing.Size(86, 30);
            this.new_village_btn.TabIndex = 3;
            this.new_village_btn.Text = "New Village";
            this.new_village_btn.UseVisualStyleBackColor = false;
            this.new_village_btn.Click += new System.EventHandler(this.new_village_btn_Click);
            // 
            // NationlistBox
            // 
            this.NationlistBox.BackColor = System.Drawing.SystemColors.Window;
            this.NationlistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NationlistBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationlistBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NationlistBox.FormattingEnabled = true;
            this.NationlistBox.ItemHeight = 16;
            this.NationlistBox.Items.AddRange(new object[] {
            "Arab Bedouin",
            "Bangladeshi Farmers",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.NationlistBox.Location = new System.Drawing.Point(46, 120);
            this.NationlistBox.Name = "NationlistBox";
            this.NationlistBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NationlistBox.ScrollAlwaysVisible = true;
            this.NationlistBox.Size = new System.Drawing.Size(163, 66);
            this.NationlistBox.Sorted = true;
            this.NationlistBox.TabIndex = 2;
            this.NationlistBox.SelectedIndexChanged += new System.EventHandler(this.NationlistBox_SelectedIndexChanged);
            // 
            // Village_name_textBox
            // 
            this.Village_name_textBox.AcceptsTab = true;
            this.Village_name_textBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Village_name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Village_name_textBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Village_name_textBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Village_name_textBox.Location = new System.Drawing.Point(46, 75);
            this.Village_name_textBox.Name = "Village_name_textBox";
            this.Village_name_textBox.Size = new System.Drawing.Size(163, 26);
            this.Village_name_textBox.TabIndex = 1;
            this.Village_name_textBox.Text = "village name";
            this.Village_name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Village_name_textBox.TextChanged += new System.EventHandler(this.Village_name_textBox_TextChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.CreatePrompt = true;
            this.saveFileDialog.Filter = "Age of villagers file|*.aov";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Age of villagers file|*.aov";
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(847, 396);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.drawing_space);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VillageWindow";
            this.Text = "Village Window";
            this.Load += new System.EventHandler(this.VillageWindow_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawing_space;
        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.TextBox Village_name_textBox;
        private System.Windows.Forms.ListBox NationlistBox;
        private System.Windows.Forms.Button new_village_btn;
        private System.Windows.Forms.Button save_village_btn;
        private System.Windows.Forms.Button open_village_btn;
        private System.Windows.Forms.RadioButton water_btn;
        private System.Windows.Forms.RadioButton tree_btn;
        private System.Windows.Forms.RadioButton House_btn;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
    }
}

