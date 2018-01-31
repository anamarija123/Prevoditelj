namespace Prevoditelj
{
    partial class Prevoditelj_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prevoditelj_form));
            this.lblIzvorni = new System.Windows.Forms.Label();
            this.comboIzvorni = new System.Windows.Forms.ComboBox();
            this.Izvorni_textBox = new System.Windows.Forms.TextBox();
            this.Prevedi_button = new System.Windows.Forms.Button();
            this.lblOdredisni = new System.Windows.Forms.Label();
            this.comboOdredisni = new System.Windows.Forms.ComboBox();
            this.Odredisni_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIzvorni
            // 
            resources.ApplyResources(this.lblIzvorni, "lblIzvorni");
            this.lblIzvorni.Name = "lblIzvorni";
            // 
            // comboIzvorni
            // 
            this.comboIzvorni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIzvorni.FormattingEnabled = true;
            resources.ApplyResources(this.comboIzvorni, "comboIzvorni");
            this.comboIzvorni.Name = "comboIzvorni";
            this.comboIzvorni.Sorted = true;
            this.comboIzvorni.SelectedIndexChanged += new System.EventHandler(this.comboIzvorni_SelectedIndexChanged);
            // 
            // Izvorni_textBox
            // 
            resources.ApplyResources(this.Izvorni_textBox, "Izvorni_textBox");
            this.Izvorni_textBox.Name = "Izvorni_textBox";
            this.Izvorni_textBox.TextChanged += new System.EventHandler(this.Izvorni_textBox_TextChanged);
            // 
            // Prevedi_button
            // 
            resources.ApplyResources(this.Prevedi_button, "Prevedi_button");
            this.Prevedi_button.Name = "Prevedi_button";
            this.Prevedi_button.UseVisualStyleBackColor = true;
            this.Prevedi_button.Click += new System.EventHandler(this.Prevedi_button_Click);
            // 
            // lblOdredisni
            // 
            resources.ApplyResources(this.lblOdredisni, "lblOdredisni");
            this.lblOdredisni.Name = "lblOdredisni";
            // 
            // comboOdredisni
            // 
            this.comboOdredisni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOdredisni.FormattingEnabled = true;
            resources.ApplyResources(this.comboOdredisni, "comboOdredisni");
            this.comboOdredisni.Name = "comboOdredisni";
            this.comboOdredisni.Sorted = true;
            // 
            // Odredisni_textBox
            // 
            resources.ApplyResources(this.Odredisni_textBox, "Odredisni_textBox");
            this.Odredisni_textBox.Name = "Odredisni_textBox";
            // 
            // Prevoditelj_form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Odredisni_textBox);
            this.Controls.Add(this.comboOdredisni);
            this.Controls.Add(this.lblOdredisni);
            this.Controls.Add(this.Prevedi_button);
            this.Controls.Add(this.Izvorni_textBox);
            this.Controls.Add(this.comboIzvorni);
            this.Controls.Add(this.lblIzvorni);
            this.Name = "Prevoditelj_form";
            this.Load += new System.EventHandler(this.Prevoditeljforma_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzvorni;
        private System.Windows.Forms.ComboBox comboIzvorni;
        private System.Windows.Forms.TextBox Izvorni_textBox;
        private System.Windows.Forms.Button Prevedi_button;
        private System.Windows.Forms.Label lblOdredisni;
        private System.Windows.Forms.ComboBox comboOdredisni;
        private System.Windows.Forms.TextBox Odredisni_textBox;
    }
}

