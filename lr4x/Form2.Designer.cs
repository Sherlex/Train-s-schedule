﻿namespace lr4x
{
    partial class Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberMasked = new System.Windows.Forms.MaskedTextBox();
            this.DepartureMasked = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ArrivalMasked = new System.Windows.Forms.MaskedTextBox();
            this.Departure_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.Arrival_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(169, 385);
            this.Save.Margin = new System.Windows.Forms.Padding(4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(110, 28);
            this.Save.TabIndex = 0;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер поезда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Отправление";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Время отправления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(57, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Время прибытия";
            // 
            // NumberMasked
            // 
            this.NumberMasked.BeepOnError = true;
            this.NumberMasked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberMasked.Location = new System.Drawing.Point(251, 43);
            this.NumberMasked.Margin = new System.Windows.Forms.Padding(4);
            this.NumberMasked.Mask = "№0000";
            this.NumberMasked.Name = "NumberMasked";
            this.NumberMasked.Size = new System.Drawing.Size(132, 24);
            this.NumberMasked.TabIndex = 5;
            // 
            // DepartureMasked
            // 
            this.DepartureMasked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartureMasked.Location = new System.Drawing.Point(251, 114);
            this.DepartureMasked.Margin = new System.Windows.Forms.Padding(4);
            this.DepartureMasked.Mask = "????????????????????";
            this.DepartureMasked.Name = "DepartureMasked";
            this.DepartureMasked.Size = new System.Drawing.Size(132, 24);
            this.DepartureMasked.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(57, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Прибытие";
            // 
            // ArrivalMasked
            // 
            this.ArrivalMasked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrivalMasked.Location = new System.Drawing.Point(251, 185);
            this.ArrivalMasked.Margin = new System.Windows.Forms.Padding(4);
            this.ArrivalMasked.Mask = "????????????????????";
            this.ArrivalMasked.Name = "ArrivalMasked";
            this.ArrivalMasked.Size = new System.Drawing.Size(132, 24);
            this.ArrivalMasked.TabIndex = 10;
            // 
            // Departure_TimePicker
            // 
            this.Departure_TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Departure_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Departure_TimePicker.Location = new System.Drawing.Point(251, 256);
            this.Departure_TimePicker.MinDate = new System.DateTime(1990, 12, 31, 0, 0, 0, 0);
            this.Departure_TimePicker.Name = "Departure_TimePicker";
            this.Departure_TimePicker.ShowUpDown = true;
            this.Departure_TimePicker.Size = new System.Drawing.Size(132, 24);
            this.Departure_TimePicker.TabIndex = 11;
            this.Departure_TimePicker.Value = new System.DateTime(2019, 11, 22, 0, 0, 0, 0);
            // 
            // Arrival_TimePicker
            // 
            this.Arrival_TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arrival_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Arrival_TimePicker.Location = new System.Drawing.Point(251, 327);
            this.Arrival_TimePicker.Name = "Arrival_TimePicker";
            this.Arrival_TimePicker.ShowUpDown = true;
            this.Arrival_TimePicker.Size = new System.Drawing.Size(132, 24);
            this.Arrival_TimePicker.TabIndex = 12;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 426);
            this.Controls.Add(this.Arrival_TimePicker);
            this.Controls.Add(this.Departure_TimePicker);
            this.Controls.Add(this.ArrivalMasked);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DepartureMasked);
            this.Controls.Add(this.NumberMasked);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Data";
            this.Text = "Ввод данных";
            this.Load += new System.EventHandler(this.Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox NumberMasked;
        private System.Windows.Forms.MaskedTextBox DepartureMasked;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox ArrivalMasked;
        private System.Windows.Forms.DateTimePicker Arrival_TimePicker;
        private System.Windows.Forms.DateTimePicker Departure_TimePicker;
    }
}