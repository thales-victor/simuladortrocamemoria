namespace Trabalho_AED_AOC
{
    partial class Simulador
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulador));
            this.labelRAM = new MetroFramework.Controls.MetroLabel();
            this.cb_RAM = new MetroFramework.Controls.MetroComboBox();
            this.cb_Bloco = new MetroFramework.Controls.MetroComboBox();
            this.labelBloco = new MetroFramework.Controls.MetroLabel();
            this.labelCache = new MetroFramework.Controls.MetroLabel();
            this.labelTecnica = new MetroFramework.Controls.MetroLabel();
            this.labelAlgoritmo = new MetroFramework.Controls.MetroLabel();
            this.btn_Calcular = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtbox_Bloco = new MetroFramework.Controls.MetroTextBox();
            this.txtbox_RAM = new MetroFramework.Controls.MetroTextBox();
            this.cb_Tecnica = new MetroFramework.Controls.MetroComboBox();
            this.txtbox_Cache = new MetroFramework.Controls.MetroTextBox();
            this.cb_Algoritmo = new MetroFramework.Controls.MetroComboBox();
            this.painel_Carregar = new MetroFramework.Controls.MetroPanel();
            this.label_Historico = new MetroFramework.Controls.MetroLabel();
            this.label_Check = new MetroFramework.Controls.MetroLabel();
            this.btn_Carregar = new MetroFramework.Controls.MetroButton();
            this.txtbox_Acessar = new MetroFramework.Controls.MetroTextBox();
            this.labelAcessar = new MetroFramework.Controls.MetroLabel();
            this.dgv_Cache = new System.Windows.Forms.DataGridView();
            this.dgv_RAM = new System.Windows.Forms.DataGridView();
            this.label_dvgCache = new MetroFramework.Controls.MetroLabel();
            this.label_dvgRAM = new MetroFramework.Controls.MetroLabel();
            this.btn_Limpar = new MetroFramework.Controls.MetroButton();
            this.dgv_Blocos = new System.Windows.Forms.DataGridView();
            this.label_dgvBlocos = new MetroFramework.Controls.MetroLabel();
            this.btn_Acessar = new MetroFramework.Controls.MetroButton();
            this.t_slide = new System.Windows.Forms.Timer(this.components);
            this.t_check = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.painel_Carregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cache)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Blocos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelRAM.Location = new System.Drawing.Point(23, 8);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(125, 25);
            this.labelRAM.TabIndex = 0;
            this.labelRAM.Text = "Memória RAM:";
            this.labelRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cb_RAM
            // 
            this.cb_RAM.BackColor = System.Drawing.Color.White;
            this.cb_RAM.FormattingEnabled = true;
            this.cb_RAM.ItemHeight = 23;
            this.cb_RAM.Items.AddRange(new object[] {
            "Bytes",
            "KBytes",
            "Mbytes",
            "GBytes"});
            this.cb_RAM.Location = new System.Drawing.Point(286, 8);
            this.cb_RAM.Name = "cb_RAM";
            this.cb_RAM.Size = new System.Drawing.Size(87, 29);
            this.cb_RAM.Style = MetroFramework.MetroColorStyle.Lime;
            this.cb_RAM.TabIndex = 1;
            this.cb_RAM.UseSelectable = true;
            // 
            // cb_Bloco
            // 
            this.cb_Bloco.FormattingEnabled = true;
            this.cb_Bloco.ItemHeight = 23;
            this.cb_Bloco.Items.AddRange(new object[] {
            "Bytes",
            "KBytes",
            "Mbytes",
            "GBytes"});
            this.cb_Bloco.Location = new System.Drawing.Point(286, 46);
            this.cb_Bloco.Name = "cb_Bloco";
            this.cb_Bloco.Size = new System.Drawing.Size(87, 29);
            this.cb_Bloco.Style = MetroFramework.MetroColorStyle.Lime;
            this.cb_Bloco.TabIndex = 3;
            this.cb_Bloco.UseSelectable = true;
            // 
            // labelBloco
            // 
            this.labelBloco.AutoSize = true;
            this.labelBloco.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelBloco.Location = new System.Drawing.Point(23, 46);
            this.labelBloco.Name = "labelBloco";
            this.labelBloco.Size = new System.Drawing.Size(157, 25);
            this.labelBloco.TabIndex = 2;
            this.labelBloco.Text = "Tamanho do bloco:";
            this.labelBloco.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelCache
            // 
            this.labelCache.AutoSize = true;
            this.labelCache.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelCache.Location = new System.Drawing.Point(851, 26);
            this.labelCache.Name = "labelCache";
            this.labelCache.Size = new System.Drawing.Size(63, 25);
            this.labelCache.TabIndex = 4;
            this.labelCache.Text = "Cache:";
            this.labelCache.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelTecnica
            // 
            this.labelTecnica.AutoSize = true;
            this.labelTecnica.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelTecnica.Location = new System.Drawing.Point(572, 8);
            this.labelTecnica.Name = "labelTecnica";
            this.labelTecnica.Size = new System.Drawing.Size(70, 25);
            this.labelTecnica.TabIndex = 6;
            this.labelTecnica.Text = "Técnica:";
            this.labelTecnica.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelAlgoritmo
            // 
            this.labelAlgoritmo.AutoSize = true;
            this.labelAlgoritmo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelAlgoritmo.Location = new System.Drawing.Point(572, 46);
            this.labelAlgoritmo.Name = "labelAlgoritmo";
            this.labelAlgoritmo.Size = new System.Drawing.Size(91, 25);
            this.labelAlgoritmo.TabIndex = 8;
            this.labelAlgoritmo.Text = "Algorítmo:";
            this.labelAlgoritmo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(1094, 25);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(85, 29);
            this.btn_Calcular.TabIndex = 7;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Calcular.UseSelectable = true;
            this.btn_Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Silver;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtbox_Bloco);
            this.metroPanel1.Controls.Add(this.txtbox_RAM);
            this.metroPanel1.Controls.Add(this.cb_Tecnica);
            this.metroPanel1.Controls.Add(this.btn_Calcular);
            this.metroPanel1.Controls.Add(this.txtbox_Cache);
            this.metroPanel1.Controls.Add(this.cb_Algoritmo);
            this.metroPanel1.Controls.Add(this.cb_RAM);
            this.metroPanel1.Controls.Add(this.labelAlgoritmo);
            this.metroPanel1.Controls.Add(this.labelRAM);
            this.metroPanel1.Controls.Add(this.labelCache);
            this.metroPanel1.Controls.Add(this.labelBloco);
            this.metroPanel1.Controls.Add(this.labelTecnica);
            this.metroPanel1.Controls.Add(this.cb_Bloco);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-3, 59);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1206, 84);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(994, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "linha(s)";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtbox_Bloco
            // 
            // 
            // 
            // 
            this.txtbox_Bloco.CustomButton.Image = null;
            this.txtbox_Bloco.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtbox_Bloco.CustomButton.Name = "";
            this.txtbox_Bloco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbox_Bloco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbox_Bloco.CustomButton.TabIndex = 1;
            this.txtbox_Bloco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbox_Bloco.CustomButton.UseSelectable = true;
            this.txtbox_Bloco.CustomButton.Visible = false;
            this.txtbox_Bloco.Lines = new string[0];
            this.txtbox_Bloco.Location = new System.Drawing.Point(189, 49);
            this.txtbox_Bloco.MaxLength = 32767;
            this.txtbox_Bloco.Name = "txtbox_Bloco";
            this.txtbox_Bloco.PasswordChar = '\0';
            this.txtbox_Bloco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_Bloco.SelectedText = "";
            this.txtbox_Bloco.SelectionLength = 0;
            this.txtbox_Bloco.SelectionStart = 0;
            this.txtbox_Bloco.ShortcutsEnabled = true;
            this.txtbox_Bloco.Size = new System.Drawing.Size(75, 23);
            this.txtbox_Bloco.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtbox_Bloco.TabIndex = 2;
            this.txtbox_Bloco.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbox_Bloco.UseSelectable = true;
            this.txtbox_Bloco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbox_Bloco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtbox_RAM
            // 
            // 
            // 
            // 
            this.txtbox_RAM.CustomButton.Image = null;
            this.txtbox_RAM.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtbox_RAM.CustomButton.Name = "";
            this.txtbox_RAM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbox_RAM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbox_RAM.CustomButton.TabIndex = 1;
            this.txtbox_RAM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbox_RAM.CustomButton.UseSelectable = true;
            this.txtbox_RAM.CustomButton.Visible = false;
            this.txtbox_RAM.Lines = new string[0];
            this.txtbox_RAM.Location = new System.Drawing.Point(189, 10);
            this.txtbox_RAM.MaxLength = 32767;
            this.txtbox_RAM.Name = "txtbox_RAM";
            this.txtbox_RAM.PasswordChar = '\0';
            this.txtbox_RAM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_RAM.SelectedText = "";
            this.txtbox_RAM.SelectionLength = 0;
            this.txtbox_RAM.SelectionStart = 0;
            this.txtbox_RAM.ShortcutsEnabled = true;
            this.txtbox_RAM.Size = new System.Drawing.Size(75, 23);
            this.txtbox_RAM.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtbox_RAM.TabIndex = 0;
            this.txtbox_RAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbox_RAM.UseSelectable = true;
            this.txtbox_RAM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbox_RAM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cb_Tecnica
            // 
            this.cb_Tecnica.FormattingEnabled = true;
            this.cb_Tecnica.ItemHeight = 23;
            this.cb_Tecnica.Items.AddRange(new object[] {
            "Direta",
            "Associativa"});
            this.cb_Tecnica.Location = new System.Drawing.Point(669, 8);
            this.cb_Tecnica.Name = "cb_Tecnica";
            this.cb_Tecnica.Size = new System.Drawing.Size(102, 29);
            this.cb_Tecnica.Style = MetroFramework.MetroColorStyle.Lime;
            this.cb_Tecnica.TabIndex = 4;
            this.cb_Tecnica.UseSelectable = true;
            this.cb_Tecnica.SelectedIndexChanged += new System.EventHandler(this.Tecnica_Select);
            // 
            // txtbox_Cache
            // 
            // 
            // 
            // 
            this.txtbox_Cache.CustomButton.Image = null;
            this.txtbox_Cache.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtbox_Cache.CustomButton.Name = "";
            this.txtbox_Cache.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbox_Cache.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbox_Cache.CustomButton.TabIndex = 1;
            this.txtbox_Cache.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbox_Cache.CustomButton.UseSelectable = true;
            this.txtbox_Cache.CustomButton.Visible = false;
            this.txtbox_Cache.Lines = new string[0];
            this.txtbox_Cache.Location = new System.Drawing.Point(919, 29);
            this.txtbox_Cache.MaxLength = 32767;
            this.txtbox_Cache.Name = "txtbox_Cache";
            this.txtbox_Cache.PasswordChar = '\0';
            this.txtbox_Cache.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_Cache.SelectedText = "";
            this.txtbox_Cache.SelectionLength = 0;
            this.txtbox_Cache.SelectionStart = 0;
            this.txtbox_Cache.ShortcutsEnabled = true;
            this.txtbox_Cache.Size = new System.Drawing.Size(75, 23);
            this.txtbox_Cache.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtbox_Cache.TabIndex = 6;
            this.txtbox_Cache.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbox_Cache.UseSelectable = true;
            this.txtbox_Cache.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbox_Cache.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cb_Algoritmo
            // 
            this.cb_Algoritmo.FormattingEnabled = true;
            this.cb_Algoritmo.ItemHeight = 23;
            this.cb_Algoritmo.Items.AddRange(new object[] {
            "LRU",
            "LFU",
            "FIFO"});
            this.cb_Algoritmo.Location = new System.Drawing.Point(669, 46);
            this.cb_Algoritmo.Name = "cb_Algoritmo";
            this.cb_Algoritmo.Size = new System.Drawing.Size(102, 29);
            this.cb_Algoritmo.Style = MetroFramework.MetroColorStyle.Lime;
            this.cb_Algoritmo.TabIndex = 5;
            this.cb_Algoritmo.UseSelectable = true;
            // 
            // painel_Carregar
            // 
            this.painel_Carregar.BackColor = System.Drawing.Color.Silver;
            this.painel_Carregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painel_Carregar.Controls.Add(this.label_Historico);
            this.painel_Carregar.Controls.Add(this.label_Check);
            this.painel_Carregar.Controls.Add(this.btn_Carregar);
            this.painel_Carregar.Controls.Add(this.txtbox_Acessar);
            this.painel_Carregar.Controls.Add(this.labelAcessar);
            this.painel_Carregar.HorizontalScrollbarBarColor = true;
            this.painel_Carregar.HorizontalScrollbarHighlightOnWheel = false;
            this.painel_Carregar.HorizontalScrollbarSize = 10;
            this.painel_Carregar.Location = new System.Drawing.Point(-3, 70);
            this.painel_Carregar.Name = "painel_Carregar";
            this.painel_Carregar.Size = new System.Drawing.Size(1206, 54);
            this.painel_Carregar.TabIndex = 12;
            this.painel_Carregar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.painel_Carregar.VerticalScrollbarBarColor = true;
            this.painel_Carregar.VerticalScrollbarHighlightOnWheel = false;
            this.painel_Carregar.VerticalScrollbarSize = 10;
            // 
            // label_Historico
            // 
            this.label_Historico.Location = new System.Drawing.Point(430, 17);
            this.label_Historico.Name = "label_Historico";
            this.label_Historico.Size = new System.Drawing.Size(331, 23);
            this.label_Historico.TabIndex = 11;
            this.label_Historico.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_Check
            // 
            this.label_Check.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label_Check.Location = new System.Drawing.Point(1115, 13);
            this.label_Check.Name = "label_Check";
            this.label_Check.Size = new System.Drawing.Size(64, 20);
            this.label_Check.TabIndex = 10;
            this.label_Check.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Carregar
            // 
            this.btn_Carregar.Location = new System.Drawing.Point(335, 13);
            this.btn_Carregar.Name = "btn_Carregar";
            this.btn_Carregar.Size = new System.Drawing.Size(85, 29);
            this.btn_Carregar.TabIndex = 9;
            this.btn_Carregar.Text = "Carregar";
            this.btn_Carregar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Carregar.UseSelectable = true;
            this.btn_Carregar.Click += new System.EventHandler(this.Carregar_Click);
            // 
            // txtbox_Acessar
            // 
            // 
            // 
            // 
            this.txtbox_Acessar.CustomButton.Image = null;
            this.txtbox_Acessar.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtbox_Acessar.CustomButton.Name = "";
            this.txtbox_Acessar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbox_Acessar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbox_Acessar.CustomButton.TabIndex = 1;
            this.txtbox_Acessar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbox_Acessar.CustomButton.UseSelectable = true;
            this.txtbox_Acessar.CustomButton.Visible = false;
            this.txtbox_Acessar.Lines = new string[0];
            this.txtbox_Acessar.Location = new System.Drawing.Point(198, 16);
            this.txtbox_Acessar.MaxLength = 32767;
            this.txtbox_Acessar.Name = "txtbox_Acessar";
            this.txtbox_Acessar.PasswordChar = '\0';
            this.txtbox_Acessar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_Acessar.SelectedText = "";
            this.txtbox_Acessar.SelectionLength = 0;
            this.txtbox_Acessar.SelectionStart = 0;
            this.txtbox_Acessar.ShortcutsEnabled = true;
            this.txtbox_Acessar.Size = new System.Drawing.Size(123, 23);
            this.txtbox_Acessar.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtbox_Acessar.TabIndex = 8;
            this.txtbox_Acessar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbox_Acessar.UseSelectable = true;
            this.txtbox_Acessar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbox_Acessar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelAcessar
            // 
            this.labelAcessar.AutoSize = true;
            this.labelAcessar.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelAcessar.Location = new System.Drawing.Point(23, 14);
            this.labelAcessar.Name = "labelAcessar";
            this.labelAcessar.Size = new System.Drawing.Size(173, 25);
            this.labelAcessar.TabIndex = 2;
            this.labelAcessar.Text = "Bloco a ser acessado:";
            this.labelAcessar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgv_Cache
            // 
            this.dgv_Cache.AllowUserToAddRows = false;
            this.dgv_Cache.AllowUserToDeleteRows = false;
            this.dgv_Cache.AllowUserToResizeColumns = false;
            this.dgv_Cache.AllowUserToResizeRows = false;
            this.dgv_Cache.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Cache.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgv_Cache.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Cache.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Cache.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Cache.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Cache.Location = new System.Drawing.Point(697, 233);
            this.dgv_Cache.MultiSelect = false;
            this.dgv_Cache.Name = "dgv_Cache";
            this.dgv_Cache.ReadOnly = true;
            this.dgv_Cache.RowHeadersVisible = false;
            this.dgv_Cache.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Cache.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cache.Size = new System.Drawing.Size(389, 424);
            this.dgv_Cache.TabIndex = 13;
            // 
            // dgv_RAM
            // 
            this.dgv_RAM.AllowUserToAddRows = false;
            this.dgv_RAM.AllowUserToDeleteRows = false;
            this.dgv_RAM.AllowUserToResizeColumns = false;
            this.dgv_RAM.AllowUserToResizeRows = false;
            this.dgv_RAM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_RAM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgv_RAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_RAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_RAM.Location = new System.Drawing.Point(207, 233);
            this.dgv_RAM.MultiSelect = false;
            this.dgv_RAM.Name = "dgv_RAM";
            this.dgv_RAM.ReadOnly = true;
            this.dgv_RAM.RowHeadersVisible = false;
            this.dgv_RAM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_RAM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_RAM.Size = new System.Drawing.Size(389, 424);
            this.dgv_RAM.TabIndex = 13;
            // 
            // label_dvgCache
            // 
            this.label_dvgCache.AutoSize = true;
            this.label_dvgCache.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label_dvgCache.Location = new System.Drawing.Point(697, 200);
            this.label_dvgCache.Name = "label_dvgCache";
            this.label_dvgCache.Size = new System.Drawing.Size(132, 25);
            this.label_dvgCache.TabIndex = 15;
            this.label_dvgCache.Text = "Memória Cache";
            this.label_dvgCache.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_dvgRAM
            // 
            this.label_dvgRAM.AutoSize = true;
            this.label_dvgRAM.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label_dvgRAM.Location = new System.Drawing.Point(207, 200);
            this.label_dvgRAM.Name = "label_dvgRAM";
            this.label_dvgRAM.Size = new System.Drawing.Size(121, 25);
            this.label_dvgRAM.TabIndex = 16;
            this.label_dvgRAM.Text = "Memória RAM";
            this.label_dvgRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(1101, 606);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(85, 51);
            this.btn_Limpar.TabIndex = 17;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Limpar.UseSelectable = true;
            this.btn_Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // dgv_Blocos
            // 
            this.dgv_Blocos.AllowUserToAddRows = false;
            this.dgv_Blocos.AllowUserToDeleteRows = false;
            this.dgv_Blocos.AllowUserToResizeColumns = false;
            this.dgv_Blocos.AllowUserToResizeRows = false;
            this.dgv_Blocos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Blocos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgv_Blocos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Blocos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Blocos.ColumnHeadersVisible = false;
            this.dgv_Blocos.Location = new System.Drawing.Point(21, 233);
            this.dgv_Blocos.MultiSelect = false;
            this.dgv_Blocos.Name = "dgv_Blocos";
            this.dgv_Blocos.ReadOnly = true;
            this.dgv_Blocos.RowHeadersVisible = false;
            this.dgv_Blocos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Blocos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Blocos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Blocos.Size = new System.Drawing.Size(106, 424);
            this.dgv_Blocos.TabIndex = 18;
            // 
            // label_dgvBlocos
            // 
            this.label_dgvBlocos.AutoSize = true;
            this.label_dgvBlocos.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label_dgvBlocos.Location = new System.Drawing.Point(21, 200);
            this.label_dgvBlocos.Name = "label_dgvBlocos";
            this.label_dgvBlocos.Size = new System.Drawing.Size(61, 25);
            this.label_dgvBlocos.TabIndex = 19;
            this.label_dgvBlocos.Text = "Blocos";
            this.label_dgvBlocos.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_Acessar
            // 
            this.btn_Acessar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Acessar.Location = new System.Drawing.Point(143, 403);
            this.btn_Acessar.Name = "btn_Acessar";
            this.btn_Acessar.Size = new System.Drawing.Size(48, 63);
            this.btn_Acessar.TabIndex = 20;
            this.btn_Acessar.Text = " >";
            this.btn_Acessar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Acessar.UseSelectable = true;
            this.btn_Acessar.Click += new System.EventHandler(this.Acessar_Click);
            // 
            // t_slide
            // 
            this.t_slide.Interval = 1;
            this.t_slide.Tick += new System.EventHandler(this.t_slide_Tick);
            // 
            // t_check
            // 
            this.t_check.Interval = 2000;
            this.t_check.Tick += new System.EventHandler(this.t_check_Tick);
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Controls.Add(this.btn_Acessar);
            this.Controls.Add(this.label_dgvBlocos);
            this.Controls.Add(this.dgv_Blocos);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.label_dvgRAM);
            this.Controls.Add(this.label_dvgCache);
            this.Controls.Add(this.dgv_RAM);
            this.Controls.Add(this.dgv_Cache);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.painel_Carregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 680);
            this.Name = "Simulador";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Simulador de Memória";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Simulador_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.painel_Carregar.ResumeLayout(false);
            this.painel_Carregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cache)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Blocos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelRAM;
        private MetroFramework.Controls.MetroComboBox cb_RAM;
        private MetroFramework.Controls.MetroComboBox cb_Bloco;
        private MetroFramework.Controls.MetroLabel labelBloco;
        private MetroFramework.Controls.MetroLabel labelCache;
        private MetroFramework.Controls.MetroLabel labelTecnica;
        private MetroFramework.Controls.MetroLabel labelAlgoritmo;
        private MetroFramework.Controls.MetroButton btn_Calcular;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel painel_Carregar;
        private MetroFramework.Controls.MetroLabel labelAcessar;
        private MetroFramework.Controls.MetroTextBox txtbox_Acessar;
        private MetroFramework.Controls.MetroButton btn_Carregar;
        private System.Windows.Forms.DataGridView dgv_Cache;
        private System.Windows.Forms.DataGridView dgv_RAM;
        private MetroFramework.Controls.MetroLabel label_dvgCache;
        private MetroFramework.Controls.MetroLabel label_dvgRAM;
        private MetroFramework.Controls.MetroButton btn_Limpar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtbox_Bloco;
        private MetroFramework.Controls.MetroTextBox txtbox_RAM;
        private MetroFramework.Controls.MetroComboBox cb_Tecnica;
        private MetroFramework.Controls.MetroTextBox txtbox_Cache;
        private MetroFramework.Controls.MetroComboBox cb_Algoritmo;
        private System.Windows.Forms.DataGridView dgv_Blocos;
        private MetroFramework.Controls.MetroLabel label_dgvBlocos;
        private MetroFramework.Controls.MetroButton btn_Acessar;
        private System.Windows.Forms.Timer t_slide;
        private System.Windows.Forms.Timer t_check;
        private MetroFramework.Controls.MetroLabel label_Historico;
        private MetroFramework.Controls.MetroLabel label_Check;
    }
}

