namespace FinCalc
{
    partial class Form_calc
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.txt_credit_sum = new System.Windows.Forms.TextBox();
            this.lbl_credit_sum_desc = new System.Windows.Forms.Label();
            this.lbl_procent_desc = new System.Windows.Forms.Label();
            this.txt_procent = new System.Windows.Forms.TextBox();
            this.txt_duration_desc = new System.Windows.Forms.Label();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.cmb_duration = new System.Windows.Forms.ComboBox();
            this.date_credit = new System.Windows.Forms.DateTimePicker();
            this.lbl_date_desc = new System.Windows.Forms.Label();
            this.cmb_periods = new System.Windows.Forms.ComboBox();
            this.lbl_periods_desc = new System.Windows.Forms.Label();
            this.btn_calculation = new System.Windows.Forms.Button();
            this.pnl_results = new System.Windows.Forms.Panel();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.lbl_results_all = new System.Windows.Forms.Label();
            this.lbl_results_procent = new System.Windows.Forms.Label();
            this.lbl_results_all_desc = new System.Windows.Forms.Label();
            this.lbl_results_procent_desc = new System.Windows.Forms.Label();
            this.chart_results = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_results)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_credit_sum
            // 
            this.txt_credit_sum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_credit_sum.Location = new System.Drawing.Point(10, 26);
            this.txt_credit_sum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_credit_sum.MaxLength = 10;
            this.txt_credit_sum.Name = "txt_credit_sum";
            this.txt_credit_sum.Size = new System.Drawing.Size(128, 20);
            this.txt_credit_sum.TabIndex = 0;
            this.txt_credit_sum.Text = "100000";
            this.txt_credit_sum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypress);
            // 
            // lbl_credit_sum_desc
            // 
            this.lbl_credit_sum_desc.AutoSize = true;
            this.lbl_credit_sum_desc.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F);
            this.lbl_credit_sum_desc.Location = new System.Drawing.Point(10, 15);
            this.lbl_credit_sum_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_credit_sum_desc.Name = "lbl_credit_sum_desc";
            this.lbl_credit_sum_desc.Size = new System.Drawing.Size(100, 12);
            this.lbl_credit_sum_desc.TabIndex = 1;
            this.lbl_credit_sum_desc.Text = "Сумма кредита/займа";
            // 
            // lbl_procent_desc
            // 
            this.lbl_procent_desc.AutoSize = true;
            this.lbl_procent_desc.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F);
            this.lbl_procent_desc.Location = new System.Drawing.Point(10, 102);
            this.lbl_procent_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_procent_desc.Name = "lbl_procent_desc";
            this.lbl_procent_desc.Size = new System.Drawing.Size(89, 12);
            this.lbl_procent_desc.TabIndex = 3;
            this.lbl_procent_desc.Text = "Ставка, % годовых";
            // 
            // txt_procent
            // 
            this.txt_procent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_procent.Location = new System.Drawing.Point(10, 116);
            this.txt_procent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_procent.MaxLength = 5;
            this.txt_procent.Name = "txt_procent";
            this.txt_procent.Size = new System.Drawing.Size(128, 20);
            this.txt_procent.TabIndex = 2;
            this.txt_procent.Text = "5,00";
            this.txt_procent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypress_float);
            // 
            // txt_duration_desc
            // 
            this.txt_duration_desc.AutoSize = true;
            this.txt_duration_desc.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F);
            this.txt_duration_desc.Location = new System.Drawing.Point(10, 213);
            this.txt_duration_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_duration_desc.Name = "txt_duration_desc";
            this.txt_duration_desc.Size = new System.Drawing.Size(93, 12);
            this.txt_duration_desc.TabIndex = 5;
            this.txt_duration_desc.Text = "Срок кредита/займа";
            // 
            // txt_duration
            // 
            this.txt_duration.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_duration.Location = new System.Drawing.Point(10, 191);
            this.txt_duration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_duration.MaxLength = 2;
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(128, 20);
            this.txt_duration.TabIndex = 4;
            this.txt_duration.Text = "1";
            this.txt_duration.TextChanged += new System.EventHandler(this.txt_duration_TextChanged);
            this.txt_duration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypress);
            // 
            // cmb_duration
            // 
            this.cmb_duration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmb_duration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_duration.FormattingEnabled = true;
            this.cmb_duration.Items.AddRange(new object[] {
            "Месяц",
            "Год"});
            this.cmb_duration.Location = new System.Drawing.Point(152, 190);
            this.cmb_duration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_duration.Name = "cmb_duration";
            this.cmb_duration.Size = new System.Drawing.Size(104, 21);
            this.cmb_duration.TabIndex = 6;
            this.cmb_duration.SelectedIndexChanged += new System.EventHandler(this.cmb_duration_SelectedIndexChanged);
            // 
            // date_credit
            // 
            this.date_credit.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.date_credit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_credit.Location = new System.Drawing.Point(10, 72);
            this.date_credit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date_credit.Name = "date_credit";
            this.date_credit.Size = new System.Drawing.Size(128, 20);
            this.date_credit.TabIndex = 7;
            this.date_credit.ValueChanged += new System.EventHandler(this.date_credit_ValueChanged);
            // 
            // lbl_date_desc
            // 
            this.lbl_date_desc.AutoSize = true;
            this.lbl_date_desc.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F);
            this.lbl_date_desc.Location = new System.Drawing.Point(9, 60);
            this.lbl_date_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date_desc.Name = "lbl_date_desc";
            this.lbl_date_desc.Size = new System.Drawing.Size(61, 12);
            this.lbl_date_desc.TabIndex = 8;
            this.lbl_date_desc.Text = "Дата выдачи";
            // 
            // cmb_periods
            // 
            this.cmb_periods.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmb_periods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_periods.FormattingEnabled = true;
            this.cmb_periods.Items.AddRange(new object[] {
            "Ежемесячно",
            "Ежеквартально",
            "Ежегодно"});
            this.cmb_periods.Location = new System.Drawing.Point(10, 157);
            this.cmb_periods.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_periods.Name = "cmb_periods";
            this.cmb_periods.Size = new System.Drawing.Size(128, 21);
            this.cmb_periods.TabIndex = 9;
            // 
            // lbl_periods_desc
            // 
            this.lbl_periods_desc.AutoSize = true;
            this.lbl_periods_desc.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F);
            this.lbl_periods_desc.Location = new System.Drawing.Point(11, 143);
            this.lbl_periods_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_periods_desc.Name = "lbl_periods_desc";
            this.lbl_periods_desc.Size = new System.Drawing.Size(120, 12);
            this.lbl_periods_desc.TabIndex = 10;
            this.lbl_periods_desc.Text = "Периодичность погашения";
            // 
            // btn_calculation
            // 
            this.btn_calculation.Location = new System.Drawing.Point(10, 354);
            this.btn_calculation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_calculation.Name = "btn_calculation";
            this.btn_calculation.Size = new System.Drawing.Size(248, 19);
            this.btn_calculation.TabIndex = 11;
            this.btn_calculation.Text = "Рассчитать";
            this.btn_calculation.UseVisualStyleBackColor = true;
            this.btn_calculation.Click += new System.EventHandler(this.btn_calculation_Click);
            // 
            // pnl_results
            // 
            this.pnl_results.BackColor = System.Drawing.Color.White;
            this.pnl_results.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_results.Controls.Add(this.lbl_results_all);
            this.pnl_results.Controls.Add(this.lbl_results_procent);
            this.pnl_results.Controls.Add(this.lbl_results_all_desc);
            this.pnl_results.Controls.Add(this.lbl_results_procent_desc);
            this.pnl_results.Controls.Add(this.chart_results);
            this.pnl_results.Location = new System.Drawing.Point(270, 15);
            this.pnl_results.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_results.Name = "pnl_results";
            this.pnl_results.Size = new System.Drawing.Size(636, 330);
            this.pnl_results.TabIndex = 12;
            this.pnl_results.Visible = false;
            // 
            // btn_schedule
            // 
            this.btn_schedule.Location = new System.Drawing.Point(801, 354);
            this.btn_schedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(105, 28);
            this.btn_schedule.TabIndex = 5;
            this.btn_schedule.Text = "График платежей";
            this.btn_schedule.UseVisualStyleBackColor = true;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // lbl_results_all
            // 
            this.lbl_results_all.AutoSize = true;
            this.lbl_results_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_results_all.Location = new System.Drawing.Point(477, 284);
            this.lbl_results_all.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_results_all.Name = "lbl_results_all";
            this.lbl_results_all.Size = new System.Drawing.Size(0, 17);
            this.lbl_results_all.TabIndex = 4;
            // 
            // lbl_results_procent
            // 
            this.lbl_results_procent.AutoSize = true;
            this.lbl_results_procent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_results_procent.Location = new System.Drawing.Point(477, 249);
            this.lbl_results_procent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_results_procent.Name = "lbl_results_procent";
            this.lbl_results_procent.Size = new System.Drawing.Size(0, 17);
            this.lbl_results_procent.TabIndex = 3;
            // 
            // lbl_results_all_desc
            // 
            this.lbl_results_all_desc.AutoSize = true;
            this.lbl_results_all_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_results_all_desc.Location = new System.Drawing.Point(308, 284);
            this.lbl_results_all_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_results_all_desc.Name = "lbl_results_all_desc";
            this.lbl_results_all_desc.Size = new System.Drawing.Size(125, 17);
            this.lbl_results_all_desc.TabIndex = 2;
            this.lbl_results_all_desc.Text = "Долг + проценты:";
            // 
            // lbl_results_procent_desc
            // 
            this.lbl_results_procent_desc.AutoSize = true;
            this.lbl_results_procent_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_results_procent_desc.Location = new System.Drawing.Point(308, 249);
            this.lbl_results_procent_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_results_procent_desc.Name = "lbl_results_procent_desc";
            this.lbl_results_procent_desc.Size = new System.Drawing.Size(172, 17);
            this.lbl_results_procent_desc.TabIndex = 1;
            this.lbl_results_procent_desc.Text = "Начисленные проценты:";
            // 
            // chart_results
            // 
            this.chart_results.BackColor = System.Drawing.Color.Transparent;
            this.chart_results.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            this.chart_results.BorderlineColor = System.Drawing.Color.Empty;
            this.chart_results.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart_results.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart_results.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_results.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_results.Legends.Add(legend1);
            this.chart_results.Location = new System.Drawing.Point(4, 22);
            this.chart_results.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart_results.Name = "chart_results";
            this.chart_results.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chart_results.Size = new System.Drawing.Size(273, 244);
            this.chart_results.TabIndex = 0;
            this.chart_results.Text = "chart1";
            // 
            // Form_calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(917, 486);
            this.Controls.Add(this.btn_schedule);
            this.Controls.Add(this.pnl_results);
            this.Controls.Add(this.btn_calculation);
            this.Controls.Add(this.lbl_periods_desc);
            this.Controls.Add(this.cmb_periods);
            this.Controls.Add(this.lbl_date_desc);
            this.Controls.Add(this.date_credit);
            this.Controls.Add(this.cmb_duration);
            this.Controls.Add(this.txt_duration_desc);
            this.Controls.Add(this.txt_duration);
            this.Controls.Add(this.lbl_procent_desc);
            this.Controls.Add(this.txt_procent);
            this.Controls.Add(this.lbl_credit_sum_desc);
            this.Controls.Add(this.txt_credit_sum);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_calc";
            this.Text = "FinCalculator";
            this.pnl_results.ResumeLayout(false);
            this.pnl_results.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_credit_sum;
        private System.Windows.Forms.Label lbl_credit_sum_desc;
        private System.Windows.Forms.Label lbl_procent_desc;
        private System.Windows.Forms.TextBox txt_procent;
        private System.Windows.Forms.Label txt_duration_desc;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.ComboBox cmb_duration;
        private System.Windows.Forms.DateTimePicker date_credit;
        private System.Windows.Forms.Label lbl_date_desc;
        private System.Windows.Forms.ComboBox cmb_periods;
        private System.Windows.Forms.Label lbl_periods_desc;
        private System.Windows.Forms.Button btn_calculation;
        private System.Windows.Forms.Panel pnl_results;
        private System.Windows.Forms.Label lbl_results_all;
        private System.Windows.Forms.Label lbl_results_procent;
        private System.Windows.Forms.Label lbl_results_all_desc;
        private System.Windows.Forms.Label lbl_results_procent_desc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_results;
        private System.Windows.Forms.Button btn_schedule;
    }
}