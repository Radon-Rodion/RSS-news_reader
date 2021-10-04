
namespace SPP_4
{
    partial class ReaderForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.RecordsList = new System.Windows.Forms.ListView();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.25F));
            this.tableLayoutPanel1.Controls.Add(this.AddressBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UpdateBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RecordsList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.WebBrowser, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AddressBox
            // 
            this.AddressBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressBox.Location = new System.Drawing.Point(3, 3);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(616, 20);
            this.AddressBox.TabIndex = 0;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateBtn.Location = new System.Drawing.Point(625, 3);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(172, 21);
            this.UpdateBtn.TabIndex = 1;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // RecordsList
            // 
            this.RecordsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordsList.HideSelection = false;
            this.RecordsList.Location = new System.Drawing.Point(625, 30);
            this.RecordsList.Name = "RecordsList";
            this.RecordsList.Size = new System.Drawing.Size(172, 417);
            this.RecordsList.TabIndex = 2;
            this.RecordsList.UseCompatibleStateImageBehavior = false;
            this.RecordsList.View = System.Windows.Forms.View.SmallIcon;
            this.RecordsList.SelectedIndexChanged += new System.EventHandler(this.RecordsList_SelectedIndexChanged);
            // 
            // WebBrowser
            // 
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser.Location = new System.Drawing.Point(3, 30);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(616, 417);
            this.WebBrowser.TabIndex = 3;
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReaderForm";
            this.Text = "RSS-Reader";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.ListView RecordsList;
        private System.Windows.Forms.WebBrowser WebBrowser;
    }
}

