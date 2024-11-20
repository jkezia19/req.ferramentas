namespace ReqFerramentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.btGerir = new System.Windows.Forms.Button();
            this.btRequisições = new System.Windows.Forms.Button();
            this.btFerramentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btGerir
            // 
            this.btGerir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerir.Location = new System.Drawing.Point(73, 174);
            this.btGerir.Name = "btGerir";
            this.btGerir.Size = new System.Drawing.Size(149, 73);
            this.btGerir.TabIndex = 1;
            this.btGerir.Text = "Gerir Colaboradores";
            this.btGerir.UseVisualStyleBackColor = true;
            this.btGerir.Click += new System.EventHandler(this.btGerir_Click);
            // 
            // btRequisições
            // 
            this.btRequisições.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRequisições.Location = new System.Drawing.Point(292, 176);
            this.btRequisições.Name = "btRequisições";
            this.btRequisições.Size = new System.Drawing.Size(149, 73);
            this.btRequisições.TabIndex = 2;
            this.btRequisições.Text = "Gerir Requisições";
            this.btRequisições.UseVisualStyleBackColor = true;
            // 
            // btFerramentas
            // 
            this.btFerramentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFerramentas.Location = new System.Drawing.Point(506, 174);
            this.btFerramentas.Name = "btFerramentas";
            this.btFerramentas.Size = new System.Drawing.Size(149, 73);
            this.btFerramentas.TabIndex = 3;
            this.btFerramentas.Text = "Gerir Ferramentas";
            this.btFerramentas.UseVisualStyleBackColor = true;
            this.btFerramentas.Click += new System.EventHandler(this.btFerramentas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btFerramentas);
            this.Controls.Add(this.btRequisições);
            this.Controls.Add(this.btGerir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGerir;
        private System.Windows.Forms.Button btRequisições;
        private System.Windows.Forms.Button btFerramentas;
    }
}

