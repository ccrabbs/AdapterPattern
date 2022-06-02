namespace AdapterPattern
{
    partial class AdapterPatternForm
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
            this.btnInterfaceAdapter = new System.Windows.Forms.Button();
            this.btnClassAdapter = new System.Windows.Forms.Button();
            this.btnObjectAdapter = new System.Windows.Forms.Button();
            this.btnTwoWayAdapter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInterfaceAdapter
            // 
            this.btnInterfaceAdapter.Location = new System.Drawing.Point(94, 35);
            this.btnInterfaceAdapter.Name = "btnInterfaceAdapter";
            this.btnInterfaceAdapter.Size = new System.Drawing.Size(107, 23);
            this.btnInterfaceAdapter.TabIndex = 0;
            this.btnInterfaceAdapter.Text = "Interface Adapter";
            this.btnInterfaceAdapter.UseVisualStyleBackColor = true;
            this.btnInterfaceAdapter.Click += new System.EventHandler(this.ButtonInterfaceAdapter_Click);
            // 
            // btnClassAdapter
            // 
            this.btnClassAdapter.Location = new System.Drawing.Point(94, 90);
            this.btnClassAdapter.Name = "btnClassAdapter";
            this.btnClassAdapter.Size = new System.Drawing.Size(107, 23);
            this.btnClassAdapter.TabIndex = 1;
            this.btnClassAdapter.Text = "ClassAdapter";
            this.btnClassAdapter.UseVisualStyleBackColor = true;
            this.btnClassAdapter.Click += new System.EventHandler(this.ButtonClassAdapter_Click);
            // 
            // btnObjectAdapter
            // 
            this.btnObjectAdapter.Location = new System.Drawing.Point(94, 142);
            this.btnObjectAdapter.Name = "btnObjectAdapter";
            this.btnObjectAdapter.Size = new System.Drawing.Size(107, 23);
            this.btnObjectAdapter.TabIndex = 2;
            this.btnObjectAdapter.Text = "Object Adapter";
            this.btnObjectAdapter.UseVisualStyleBackColor = true;
            this.btnObjectAdapter.Click += new System.EventHandler(this.ButtonObjectAdapter_Click);
            // 
            // btnTwoWayAdapter
            // 
            this.btnTwoWayAdapter.Location = new System.Drawing.Point(94, 192);
            this.btnTwoWayAdapter.Name = "btnTwoWayAdapter";
            this.btnTwoWayAdapter.Size = new System.Drawing.Size(107, 23);
            this.btnTwoWayAdapter.TabIndex = 3;
            this.btnTwoWayAdapter.Text = "Two Way Adapter";
            this.btnTwoWayAdapter.UseVisualStyleBackColor = true;
            this.btnTwoWayAdapter.Click += new System.EventHandler(this.ButtonTwoWayAdapter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 327);
            this.Controls.Add(this.btnTwoWayAdapter);
            this.Controls.Add(this.btnObjectAdapter);
            this.Controls.Add(this.btnClassAdapter);
            this.Controls.Add(this.btnInterfaceAdapter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInterfaceAdapter;
        private System.Windows.Forms.Button btnClassAdapter;
        private System.Windows.Forms.Button btnObjectAdapter;
        private System.Windows.Forms.Button btnTwoWayAdapter;
    }
}

