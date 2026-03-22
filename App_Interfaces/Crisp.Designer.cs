
namespace App_Interfaces
{
    partial class Crisp
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
            btn_crisp_saladas = new Button();
            btn_crisp_dulces = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_crisp_salir = new Button();
            SuspendLayout();
            // 
            // btn_crisp_saladas
            // 
            btn_crisp_saladas.Location = new Point(53, 105);
            btn_crisp_saladas.Name = "btn_crisp_saladas";
            btn_crisp_saladas.Size = new Size(89, 36);
            btn_crisp_saladas.TabIndex = 0;
            btn_crisp_saladas.Text = "SALADAS";
            btn_crisp_saladas.UseVisualStyleBackColor = true;
            btn_crisp_saladas.Click += btn_crisp_saladas_Click;
            // 
            // btn_crisp_dulces
            // 
            btn_crisp_dulces.Location = new Point(209, 105);
            btn_crisp_dulces.Name = "btn_crisp_dulces";
            btn_crisp_dulces.Size = new Size(98, 36);
            btn_crisp_dulces.TabIndex = 1;
            btn_crisp_dulces.Text = "DULCES";
            btn_crisp_dulces.UseVisualStyleBackColor = true;
            btn_crisp_dulces.Click += btn_crisp_dulces_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 33);
            label1.Name = "label1";
            label1.Size = new Size(289, 26);
            label1.TabIndex = 2;
            label1.Text = "Elije como quieres tus Crispetas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 59);
            label2.Name = "label2";
            label2.Size = new Size(220, 20);
            label2.TabIndex = 3;
            label2.Text = "Nota: Puedes elejir mas de una";
            // 
            // btn_crisp_salir
            // 
            btn_crisp_salir.Location = new Point(137, 169);
            btn_crisp_salir.Name = "btn_crisp_salir";
            btn_crisp_salir.Size = new Size(77, 23);
            btn_crisp_salir.TabIndex = 4;
            btn_crisp_salir.Text = "SALIR";
            btn_crisp_salir.UseVisualStyleBackColor = true;
            btn_crisp_salir.Click += btn_crisp_salir_Click;
            // 
            // Crisp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 231);
            Controls.Add(btn_crisp_salir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_crisp_dulces);
            Controls.Add(btn_crisp_saladas);
            Name = "Crisp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crispetas Pequeña";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion


        private Button btn_crisp_saladas;
        private Button btn_crisp_dulces;
        private Label label1;
        private Label label2;
        private Button btn_crisp_salir;
    }
}