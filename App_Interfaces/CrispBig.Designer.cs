namespace App_Interfaces
{
    partial class CrispBig
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
            btn_crispbig_dulces = new Button();
            btn_crispbig_saladas = new Button();
            SuspendLayout();
            // 
            // btn_crispbig_salir
            // 
            btn_crispbig_salir.Location = new Point(140, 172);
            btn_crispbig_salir.Name = "btn_crispbig_salir";
            btn_crispbig_salir.Size = new Size(77, 23);
            btn_crispbig_salir.TabIndex = 9;
            btn_crispbig_salir.Text = "SALIR";
            btn_crispbig_salir.UseVisualStyleBackColor = true;
            btn_crispbig_salir.Click += btn_crispbig_salir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 62);
            label2.Name = "label2";
            label2.Size = new Size(220, 20);
            label2.TabIndex = 8;
            label2.Text = "Nota: Puedes elejir mas de una";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 36);
            label1.Name = "label1";
            label1.Size = new Size(289, 26);
            label1.TabIndex = 7;
            label1.Text = "Elije como quieres tus Crispetas";
            // 
            // btn_crispbig_dulces
            // 
            btn_crispbig_dulces.Location = new Point(212, 108);
            btn_crispbig_dulces.Name = "btn_crispbig_dulces";
            btn_crispbig_dulces.Size = new Size(98, 36);
            btn_crispbig_dulces.TabIndex = 6;
            btn_crispbig_dulces.Text = "DULCES";
            btn_crispbig_dulces.UseVisualStyleBackColor = true;
            btn_crispbig_dulces.Click += btn_crispbig_dulces_Click;
            // 
            // btn_crispbig_saladas
            // 
            btn_crispbig_saladas.Location = new Point(56, 108);
            btn_crispbig_saladas.Name = "btn_crispbig_saladas";
            btn_crispbig_saladas.Size = new Size(89, 36);
            btn_crispbig_saladas.TabIndex = 5;
            btn_crispbig_saladas.Text = "SALADAS";
            btn_crispbig_saladas.UseVisualStyleBackColor = true;
            btn_crispbig_saladas.Click += btn_crispbig_saladas_Click;
            // 
            // CrispBig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 231);
            Controls.Add(btn_crispbig_salir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_crispbig_dulces);
            Controls.Add(btn_crispbig_saladas);
            Name = "CrispBig";
            Text = "Crispetas Grandes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_crispbig_salir;
        private Label label2;
        private Label label1;
        private Button btn_crispbig_dulces;
        private Button btn_crispbig_saladas;
    }
}