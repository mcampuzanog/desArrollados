namespace HotelSOL1.FormsAPP
{
    partial class ProveedorStockForm
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
            btnVerStock = new Button();
            btnRealizarPedido = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // btnVerStock
            // 
            btnVerStock.BackColor = SystemColors.GradientActiveCaption;
            btnVerStock.ForeColor = SystemColors.MenuHighlight;
            btnVerStock.Location = new Point(40, 147);
            btnVerStock.Name = "btnVerStock";
            btnVerStock.Size = new Size(220, 50);
            btnVerStock.TabIndex = 2;
            btnVerStock.Text = "Ver stock";
            btnVerStock.UseVisualStyleBackColor = false;
            // 
            // btnRealizarPedido
            // 
            btnRealizarPedido.BackColor = SystemColors.GradientActiveCaption;
            btnRealizarPedido.ForeColor = SystemColors.MenuHighlight;
            btnRealizarPedido.Location = new Point(40, 227);
            btnRealizarPedido.Name = "btnRealizarPedido";
            btnRealizarPedido.Size = new Size(220, 50);
            btnRealizarPedido.TabIndex = 3;
            btnRealizarPedido.Text = "Realizar pedido";
            btnRealizarPedido.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(40, 66);
            button1.Name = "button1";
            button1.Size = new Size(220, 50);
            button1.TabIndex = 4;
            button1.Text = "Ver proveedores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(438, 66);
            button2.Name = "button2";
            button2.Size = new Size(220, 50);
            button2.TabIndex = 5;
            button2.Text = "Ver albaranes";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.ForeColor = SystemColors.MenuHighlight;
            button3.Location = new Point(438, 147);
            button3.Name = "button3";
            button3.Size = new Size(220, 50);
            button3.TabIndex = 6;
            button3.Text = "Ver facturas proveedores";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientActiveCaption;
            button4.ForeColor = SystemColors.MenuHighlight;
            button4.Location = new Point(438, 227);
            button4.Name = "button4";
            button4.Size = new Size(220, 50);
            button4.TabIndex = 7;
            button4.Text = "Ver pedidos";
            button4.UseVisualStyleBackColor = false;
            // 
            // ProveedorStockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.LogoHotelSOL;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(693, 336);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnRealizarPedido);
            Controls.Add(btnVerStock);
            DoubleBuffered = true;
            Name = "ProveedorStockForm";
            Text = "StockForm";
            Load += StockForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerStock;
        private Button btnRealizarPedido;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}