
namespace Aula_WinForms
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
            this.components = new System.ComponentModel.Container();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbresultado = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbcon = new System.Windows.Forms.Label();
            this.lbnao = new System.Windows.Forms.Label();
            this.lbsim = new System.Windows.Forms.Label();
            this.lbidade = new System.Windows.Forms.Label();
            this.txtida = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnconfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnconfirmar.Location = new System.Drawing.Point(42, 148);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(167, 43);
            this.btnconfirmar.TabIndex = 0;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbnome
            // 
            this.txbnome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txbnome.Location = new System.Drawing.Point(42, 54);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(167, 23);
            this.txbnome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "INSIRA VALORES";
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtnum.Location = new System.Drawing.Point(42, 93);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(167, 23);
            this.txtnum.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbresultado);
            this.groupBox1.Controls.Add(this.txtnum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbnome);
            this.groupBox1.Controls.Add(this.btnconfirmar);
            this.groupBox1.Location = new System.Drawing.Point(31, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 205);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadorqa";
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(44, 133);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(0, 15);
            this.lbresultado.TabIndex = 4;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(33, 47);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(178, 23);
            this.txtnome.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "CONFIRMAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Insira seu nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbcon);
            this.groupBox2.Controls.Add(this.lbnao);
            this.groupBox2.Controls.Add(this.lbsim);
            this.groupBox2.Controls.Add(this.lbidade);
            this.groupBox2.Controls.Add(this.txtida);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtnome);
            this.groupBox2.Location = new System.Drawing.Point(436, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 238);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NOMe";
            // 
            // lbcon
            // 
            this.lbcon.AutoSize = true;
            this.lbcon.Location = new System.Drawing.Point(33, 132);
            this.lbcon.Name = "lbcon";
            this.lbcon.Size = new System.Drawing.Size(98, 15);
            this.lbcon.TabIndex = 12;
            this.lbcon.Text = "MAIOR DE IDADE";
            // 
            // lbnao
            // 
            this.lbnao.AutoSize = true;
            this.lbnao.Location = new System.Drawing.Point(111, 150);
            this.lbnao.Name = "lbnao";
            this.lbnao.Size = new System.Drawing.Size(33, 15);
            this.lbnao.TabIndex = 11;
            this.lbnao.Text = "NÂO";
            // 
            // lbsim
            // 
            this.lbsim.AutoSize = true;
            this.lbsim.Location = new System.Drawing.Point(33, 150);
            this.lbsim.Name = "lbsim";
            this.lbsim.Size = new System.Drawing.Size(27, 15);
            this.lbsim.TabIndex = 10;
            this.lbsim.Text = "SIM";
            // 
            // lbidade
            // 
            this.lbidade.AutoSize = true;
            this.lbidade.Location = new System.Drawing.Point(33, 73);
            this.lbidade.Name = "lbidade";
            this.lbidade.Size = new System.Drawing.Size(40, 15);
            this.lbidade.TabIndex = 9;
            this.lbidade.Text = "IDADE";
            // 
            // txtida
            // 
            this.txtida.Location = new System.Drawing.Point(33, 94);
            this.txtida.Name = "txtida";
            this.txtida.Size = new System.Drawing.Size(100, 23);
            this.txtida.TabIndex = 8;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(81, 377);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(86, 26);
            this.bt1.TabIndex = 9;
            this.bt1.Text = "b1 - Left";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(277, 377);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(86, 26);
            this.bt2.TabIndex = 10;
            this.bt2.Text = "bt2 - Right";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(167, 409);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(112, 33);
            this.bt3.TabIndex = 11;
            this.bt3.Text = "bt 3 - Middle";
            this.bt3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(850, 499);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Label lbcon;
        private System.Windows.Forms.Label lbnao;
        private System.Windows.Forms.Label lbsim;
        private System.Windows.Forms.Label lbidade;
        private System.Windows.Forms.TextBox txtida;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
    }
}

