
namespace FormConsome
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.btntodos = new System.Windows.Forms.Button();
            this.btnporid = new System.Windows.Forms.Button();
            this.TXTBUSCA = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.TXTDELETAR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView1
            // 
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(12, 12);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(776, 226);
            this.GridView1.TabIndex = 0;
            // 
            // btntodos
            // 
            this.btntodos.Location = new System.Drawing.Point(12, 316);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(151, 63);
            this.btntodos.TabIndex = 1;
            this.btntodos.Text = "BUSCAR TODOS";
            this.btntodos.UseVisualStyleBackColor = true;
            this.btntodos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnporid
            // 
            this.btnporid.Location = new System.Drawing.Point(196, 316);
            this.btnporid.Name = "btnporid";
            this.btnporid.Size = new System.Drawing.Size(169, 63);
            this.btnporid.TabIndex = 2;
            this.btnporid.Text = "BUSCAR POR ID";
            this.btnporid.UseVisualStyleBackColor = true;
            this.btnporid.Click += new System.EventHandler(this.button2_Click);
            // 
            // TXTBUSCA
            // 
            this.TXTBUSCA.Location = new System.Drawing.Point(196, 279);
            this.TXTBUSCA.Name = "TXTBUSCA";
            this.TXTBUSCA.Size = new System.Drawing.Size(169, 20);
            this.TXTBUSCA.TabIndex = 3;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(447, 316);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(169, 63);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "DELETAR";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // TXTDELETAR
            // 
            this.TXTDELETAR.Location = new System.Drawing.Point(447, 279);
            this.TXTDELETAR.Name = "TXTDELETAR";
            this.TXTDELETAR.Size = new System.Drawing.Size(169, 20);
            this.TXTDELETAR.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTDELETAR);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.TXTBUSCA);
            this.Controls.Add(this.btnporid);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.GridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.Button btntodos;
        private System.Windows.Forms.Button btnporid;
        private System.Windows.Forms.TextBox TXTBUSCA;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox TXTDELETAR;
    }
}

