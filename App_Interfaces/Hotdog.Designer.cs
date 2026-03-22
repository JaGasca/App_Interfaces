namespace App_Interfaces
{
    partial class Hotdog
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
            btn_crispbig_salir = new Button();
            label2 = new Label();
            label1 = new Label();
            btn_hotdog_kep = new Button();
            btn_hotdog_full = new Button();
            btn_hotdog_mos = new Button();
            SuspendLayout();
            // 
            // btn_crispbig_salir
            // 
            btn_crispbig_salir.Location = new Point(224, 181);
            btn_crispbig_salir.Name = "btn_crispbig_salir";
            btn_crispbig_salir.Size = new Size(70, 23);
            btn_crispbig_salir.TabIndex = 14;
            btn_crispbig_salir.Text = "SALIR";
            btn_crispbig_salir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 62);
            label2.Name = "label2";
            label2.Size = new Size(268, 20);
            label2.TabIndex = 13;
            label2.Text = "Nota: Puedes elejir mas de una opción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 36);
            label1.Name = "label1";
            label1.Size = new Size(322, 26);
            label1.TabIndex = 12;
            label1.Text = "Elije como quieres tu Perro Caliente";
            // 
            // btn_hotdog_kep
            // 
            btn_hotdog_kep.Location = new Point(213, 95);
            btn_hotdog_kep.Name = "btn_hotdog_kep";
            btn_hotdog_kep.Size = new Size(90, 52);
            btn_hotdog_kep.TabIndex = 11;
            btn_hotdog_kep.Text = "SOLO KETCHUP";
            btn_hotdog_kep.UseVisualStyleBackColor = true;
            btn_hotdog_kep.Click += btn_hotdog_kep_Click;
            // 
            // btn_hotdog_full
            // 
            btn_hotdog_full.Location = new Point(55, 95);
            btn_hotdog_full.Name = "btn_hotdog_full";
            btn_hotdog_full.Size = new Size(89, 52);
            btn_hotdog_full.TabIndex = 10;
            btn_hotdog_full.Text = "KETCHUP Y MOSTAZA";
            btn_hotdog_full.UseVisualStyleBackColor = true;
            btn_hotdog_full.Click += btn_hotdog_full_Click;
            // 
            // btn_hotdog_mos
            // 
            btn_hotdog_mos.Location = new Point(55, 166);
            btn_hotdog_mos.Name = "btn_hotdog_mos";
            btn_hotdog_mos.Size = new Size(89, 52);
            btn_hotdog_mos.TabIndex = 15;
            btn_hotdog_mos.Text = "SOLO MOSTAZA";
            btn_hotdog_mos.UseVisualStyleBackColor = true;
            btn_hotdog_mos.Click += btn_hotdog_mos_Click;
            // 
            // Hotdog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 231);
            Controls.Add(btn_hotdog_mos);
            Controls.Add(btn_crispbig_salir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_hotdog_kep);
            Controls.Add(btn_hotdog_full);
            Name = "Hotdog";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_crispbig_salir;
        private Label label2;
        private Label label1;
        private Button btn_hotdog_kep;
        private Button btn_hotdog_full;
        private Button btn_hotdog_mos;
    }
}