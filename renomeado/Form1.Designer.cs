namespace renomeado
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
            lblArquivos = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            buttonFolder = new Button();
            txtCaminho = new TextBox();
            btnRenomear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblArquivos
            // 
            lblArquivos.AutoSize = true;
            lblArquivos.Location = new Point(74, 9);
            lblArquivos.Name = "lblArquivos";
            lblArquivos.Size = new Size(0, 15);
            lblArquivos.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 17;
            label2.Text = "Novo nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 77);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(287, 23);
            txtNome.TabIndex = 16;
            // 
            // buttonFolder
            // 
            buttonFolder.Location = new Point(305, 27);
            buttonFolder.Name = "buttonFolder";
            buttonFolder.Size = new Size(41, 23);
            buttonFolder.TabIndex = 15;
            buttonFolder.Text = "...";
            buttonFolder.UseVisualStyleBackColor = true;
            buttonFolder.Click += buttonFolder_Click;
            // 
            // txtCaminho
            // 
            txtCaminho.Location = new Point(12, 27);
            txtCaminho.Name = "txtCaminho";
            txtCaminho.Size = new Size(287, 23);
            txtCaminho.TabIndex = 14;
            // 
            // btnRenomear
            // 
            btnRenomear.Location = new Point(12, 127);
            btnRenomear.Name = "btnRenomear";
            btnRenomear.Size = new Size(334, 23);
            btnRenomear.TabIndex = 13;
            btnRenomear.Text = "Renomear";
            btnRenomear.UseVisualStyleBackColor = true;
            btnRenomear.Click += btnRenomear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 12;
            label1.Text = "Caminho";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 161);
            Controls.Add(lblArquivos);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(buttonFolder);
            Controls.Add(txtCaminho);
            Controls.Add(btnRenomear);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArquivos;
        private Label label2;
        private TextBox txtNome;
        private Button buttonFolder;
        private TextBox txtCaminho;
        private Button btnRenomear;
        private Label label1;
    }
}
