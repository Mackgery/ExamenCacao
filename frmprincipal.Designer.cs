
namespace Login1
{
    partial class frmprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprincipal));
            this.btnProd = new System.Windows.Forms.Button();
            this.btnCiu = new System.Windows.Forms.Button();
            this.btnClie = new System.Windows.Forms.Button();
            this.btnRep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProd
            // 
            this.btnProd.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.Location = new System.Drawing.Point(86, 103);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(135, 68);
            this.btnProd.TabIndex = 0;
            this.btnProd.Text = "Productos";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnCiu
            // 
            this.btnCiu.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiu.Location = new System.Drawing.Point(330, 103);
            this.btnCiu.Name = "btnCiu";
            this.btnCiu.Size = new System.Drawing.Size(135, 68);
            this.btnCiu.TabIndex = 1;
            this.btnCiu.Text = "Ciudades";
            this.btnCiu.UseVisualStyleBackColor = true;
            this.btnCiu.Click += new System.EventHandler(this.btnCiu_Click);
            // 
            // btnClie
            // 
            this.btnClie.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClie.Location = new System.Drawing.Point(86, 224);
            this.btnClie.Name = "btnClie";
            this.btnClie.Size = new System.Drawing.Size(135, 68);
            this.btnClie.TabIndex = 2;
            this.btnClie.Text = "Clientes";
            this.btnClie.UseVisualStyleBackColor = true;
            this.btnClie.Click += new System.EventHandler(this.btnClie_Click);
            // 
            // btnRep
            // 
            this.btnRep.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRep.Location = new System.Drawing.Point(330, 224);
            this.btnRep.Name = "btnRep";
            this.btnRep.Size = new System.Drawing.Size(135, 68);
            this.btnRep.TabIndex = 3;
            this.btnRep.Text = "Reportes";
            this.btnRep.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(178, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Monosabios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRep);
            this.Controls.Add(this.btnClie);
            this.Controls.Add(this.btnCiu);
            this.Controls.Add(this.btnProd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monosabios";
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnCiu;
        private System.Windows.Forms.Button btnClie;
        private System.Windows.Forms.Button btnRep;
        private System.Windows.Forms.Label label1;
    }
}