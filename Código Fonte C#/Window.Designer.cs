namespace Sistema___CPA
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.ListaProvas = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Liberar = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NomeProva = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Aplicado = new System.Windows.Forms.DomainUpDown();
            this.Letivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Questoes = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RESULTADOS = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.progressBar6 = new Sistema___CPA.NewProgressBar();
            this.progressBar5 = new Sistema___CPA.NewProgressBar();
            this.progressBar4 = new Sistema___CPA.NewProgressBar();
            this.progressBar3 = new Sistema___CPA.NewProgressBar();
            this.progressBar2 = new Sistema___CPA.NewProgressBar();
            this.progressBar1 = new Sistema___CPA.NewProgressBar();
            this.NaoSei2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Otimo2 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.Regular2 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.Bom2 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.Ruim2 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.Pessimo2 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NaoSeil = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Otimol = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Regularl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Boml = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Ruiml = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Pessimol = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EixoText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.QuestaoText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eixo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Questoes)).BeginInit();
            this.RESULTADOS.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.ListaProvas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 630);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROVAS";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(53, 594);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Recarregar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // ListaProvas
            // 
            this.ListaProvas.FormattingEnabled = true;
            this.ListaProvas.Location = new System.Drawing.Point(6, 19);
            this.ListaProvas.Name = "ListaProvas";
            this.ListaProvas.Size = new System.Drawing.Size(267, 563);
            this.ListaProvas.TabIndex = 0;
            this.ListaProvas.SelectedIndexChanged += new System.EventHandler(this.ListaProvas_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Liberar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.NomeProva);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.Aplicado);
            this.groupBox2.Controls.Add(this.Letivo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(298, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFORMAÇÕES";
            // 
            // Liberar
            // 
            this.Liberar.Items.Add("Não");
            this.Liberar.Items.Add("Sim");
            this.Liberar.Location = new System.Drawing.Point(91, 70);
            this.Liberar.Name = "Liberar";
            this.Liberar.Size = new System.Drawing.Size(493, 20);
            this.Liberar.TabIndex = 11;
            this.Liberar.Text = "Selecione..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Liberar: ";
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Location = new System.Drawing.Point(224, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Editar Prova";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(409, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Apagar Prova";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // NomeProva
            // 
            this.NomeProva.Location = new System.Drawing.Point(91, 16);
            this.NomeProva.Name = "NomeProva";
            this.NomeProva.Size = new System.Drawing.Size(493, 20);
            this.NomeProva.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(40, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Incluir Prova";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Aplicado
            // 
            this.Aplicado.Items.Add("Técnico Administrativo");
            this.Aplicado.Items.Add("Corpo Docente");
            this.Aplicado.Items.Add("Corpo Discente");
            this.Aplicado.Items.Add("Comunidade");
            this.Aplicado.Location = new System.Drawing.Point(237, 44);
            this.Aplicado.Name = "Aplicado";
            this.Aplicado.Size = new System.Drawing.Size(347, 20);
            this.Aplicado.TabIndex = 5;
            this.Aplicado.Text = "Selecione..";
            // 
            // Letivo
            // 
            this.Letivo.Location = new System.Drawing.Point(91, 44);
            this.Letivo.Name = "Letivo";
            this.Letivo.Size = new System.Drawing.Size(59, 20);
            this.Letivo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Aplicado para:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Período Letivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome da Prova:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Questoes);
            this.groupBox3.Location = new System.Drawing.Point(297, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 387);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "QUESTOES";
            // 
            // Questoes
            // 
            this.Questoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Questoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Questoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Questoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.count,
            this.questao,
            this.eixo});
            this.Questoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Questoes.Location = new System.Drawing.Point(3, 16);
            this.Questoes.Name = "Questoes";
            this.Questoes.Size = new System.Drawing.Size(597, 368);
            this.Questoes.TabIndex = 0;
            this.Questoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Questoes_CellContentClick);
            this.Questoes.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Questoes_DataError);
            this.Questoes.SelectionChanged += new System.EventHandler(this.Questoes_SelectionChanged);
            // 
            // button6
            // 
            this.button6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button6.Location = new System.Drawing.Point(524, 606);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Editar Questão";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(670, 606);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Apagar Questão";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(375, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Incluir Questão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RESULTADOS
            // 
            this.RESULTADOS.Controls.Add(this.groupBox5);
            this.RESULTADOS.Controls.Add(this.groupBox4);
            this.RESULTADOS.Location = new System.Drawing.Point(906, 12);
            this.RESULTADOS.Name = "RESULTADOS";
            this.RESULTADOS.Size = new System.Drawing.Size(282, 630);
            this.RESULTADOS.TabIndex = 3;
            this.RESULTADOS.TabStop = false;
            this.RESULTADOS.Text = "Resultados";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.progressBar6);
            this.groupBox5.Controls.Add(this.progressBar5);
            this.groupBox5.Controls.Add(this.progressBar4);
            this.groupBox5.Controls.Add(this.progressBar3);
            this.groupBox5.Controls.Add(this.progressBar2);
            this.groupBox5.Controls.Add(this.progressBar1);
            this.groupBox5.Controls.Add(this.NaoSei2);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.Otimo2);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.Regular2);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.Bom2);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.Ruim2);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.Pessimo2);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Location = new System.Drawing.Point(17, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(249, 260);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resultado por Prova Selecionada";
            this.groupBox5.Enter += new System.EventHandler(this.GroupBox5_Enter);
            // 
            // progressBar6
            // 
            this.progressBar6.CustomText = null;
            this.progressBar6.DisplayStyle = Sistema___CPA.NewProgressBar.ProgressBarDisplayText.CustomText;
            this.progressBar6.Location = new System.Drawing.Point(75, 194);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(139, 12);
            this.progressBar6.TabIndex = 24;
            // 
            // progressBar5
            // 
            this.progressBar5.CustomText = null;
            this.progressBar5.DisplayStyle = Sistema___CPA.NewProgressBar.ProgressBarDisplayText.CustomText;
            this.progressBar5.Location = new System.Drawing.Point(75, 175);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(139, 12);
            this.progressBar5.TabIndex = 23;
            // 
            // progressBar4
            // 
            this.progressBar4.CustomText = null;
            this.progressBar4.DisplayStyle = Sistema___CPA.NewProgressBar.ProgressBarDisplayText.CustomText;
            this.progressBar4.Location = new System.Drawing.Point(75, 155);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(139, 12);
            this.progressBar4.TabIndex = 22;
            // 
            // progressBar3
            // 
            this.progressBar3.CustomText = null;
            this.progressBar3.DisplayStyle = Sistema___CPA.NewProgressBar.ProgressBarDisplayText.CustomText;
            this.progressBar3.Location = new System.Drawing.Point(75, 134);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(139, 12);
            this.progressBar3.TabIndex = 21;
            // 
            // progressBar2
            // 
            this.progressBar2.CustomText = null;
            this.progressBar2.DisplayStyle = Sistema___CPA.NewProgressBar.ProgressBarDisplayText.CustomText;
            this.progressBar2.Location = new System.Drawing.Point(75, 114);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(139, 12);
            this.progressBar2.TabIndex = 20;
            // 
            // progressBar1
            // 
            this.progressBar1.CustomText = null;
            this.progressBar1.DisplayStyle = Sistema___CPA.NewProgressBar.ProgressBarDisplayText.CustomText;
            this.progressBar1.Location = new System.Drawing.Point(75, 95);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(139, 12);
            this.progressBar1.TabIndex = 19;
            // 
            // NaoSei2
            // 
            this.NaoSei2.AutoSize = true;
            this.NaoSei2.Location = new System.Drawing.Point(96, 193);
            this.NaoSei2.Name = "NaoSei2";
            this.NaoSei2.Size = new System.Drawing.Size(50, 13);
            this.NaoSei2.TabIndex = 16;
            this.NaoSei2.Text = "Questão:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 193);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "6-Não Sei:";
            // 
            // Otimo2
            // 
            this.Otimo2.AutoSize = true;
            this.Otimo2.Location = new System.Drawing.Point(96, 174);
            this.Otimo2.Name = "Otimo2";
            this.Otimo2.Size = new System.Drawing.Size(50, 13);
            this.Otimo2.TabIndex = 14;
            this.Otimo2.Text = "Questão:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 174);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "5-Ótimo:";
            // 
            // Regular2
            // 
            this.Regular2.AutoSize = true;
            this.Regular2.Location = new System.Drawing.Point(96, 155);
            this.Regular2.Name = "Regular2";
            this.Regular2.Size = new System.Drawing.Size(50, 13);
            this.Regular2.TabIndex = 12;
            this.Regular2.Text = "Questão:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 155);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 13);
            this.label26.TabIndex = 11;
            this.label26.Text = "4-Regular:";
            // 
            // Bom2
            // 
            this.Bom2.AutoSize = true;
            this.Bom2.Location = new System.Drawing.Point(96, 133);
            this.Bom2.Name = "Bom2";
            this.Bom2.Size = new System.Drawing.Size(50, 13);
            this.Bom2.TabIndex = 10;
            this.Bom2.Text = "Questão:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 133);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(40, 13);
            this.label28.TabIndex = 9;
            this.label28.Text = "3-Bom:";
            // 
            // Ruim2
            // 
            this.Ruim2.AutoSize = true;
            this.Ruim2.Location = new System.Drawing.Point(96, 112);
            this.Ruim2.Name = "Ruim2";
            this.Ruim2.Size = new System.Drawing.Size(50, 13);
            this.Ruim2.TabIndex = 8;
            this.Ruim2.Text = "Questão:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 112);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 13);
            this.label30.TabIndex = 7;
            this.label30.Text = "2-Ruim:";
            // 
            // Pessimo2
            // 
            this.Pessimo2.AutoSize = true;
            this.Pessimo2.Location = new System.Drawing.Point(96, 94);
            this.Pessimo2.Name = "Pessimo2";
            this.Pessimo2.Size = new System.Drawing.Size(50, 13);
            this.Pessimo2.TabIndex = 6;
            this.Pessimo2.Text = "Questão:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 94);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(61, 13);
            this.label32.TabIndex = 5;
            this.label32.Text = "1-Péssimo: ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(106, 31);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(55, 13);
            this.label33.TabIndex = 4;
            this.label33.Text = "Contagem";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NaoSeil);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.Otimol);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.Regularl);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.Boml);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.Ruiml);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.Pessimol);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.EixoText);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.QuestaoText);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(17, 304);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 265);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado por Questão Selecionada";
            // 
            // NaoSeil
            // 
            this.NaoSeil.AutoSize = true;
            this.NaoSeil.Location = new System.Drawing.Point(106, 231);
            this.NaoSeil.Name = "NaoSeil";
            this.NaoSeil.Size = new System.Drawing.Size(50, 13);
            this.NaoSeil.TabIndex = 16;
            this.NaoSeil.Text = "Questão:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 231);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "6-Não Sei:";
            // 
            // Otimol
            // 
            this.Otimol.AutoSize = true;
            this.Otimol.Location = new System.Drawing.Point(106, 209);
            this.Otimol.Name = "Otimol";
            this.Otimol.Size = new System.Drawing.Size(50, 13);
            this.Otimol.TabIndex = 14;
            this.Otimol.Text = "Questão:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 209);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "5-Ótimo:";
            // 
            // Regularl
            // 
            this.Regularl.AutoSize = true;
            this.Regularl.Location = new System.Drawing.Point(106, 186);
            this.Regularl.Name = "Regularl";
            this.Regularl.Size = new System.Drawing.Size(50, 13);
            this.Regularl.TabIndex = 12;
            this.Regularl.Text = "Questão:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "4-Regular:";
            // 
            // Boml
            // 
            this.Boml.AutoSize = true;
            this.Boml.Location = new System.Drawing.Point(106, 164);
            this.Boml.Name = "Boml";
            this.Boml.Size = new System.Drawing.Size(50, 13);
            this.Boml.TabIndex = 10;
            this.Boml.Text = "Questão:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "3-Bom:";
            // 
            // Ruiml
            // 
            this.Ruiml.AutoSize = true;
            this.Ruiml.Location = new System.Drawing.Point(106, 140);
            this.Ruiml.Name = "Ruiml";
            this.Ruiml.Size = new System.Drawing.Size(50, 13);
            this.Ruiml.TabIndex = 8;
            this.Ruiml.Text = "Questão:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "2-Ruim:";
            // 
            // Pessimol
            // 
            this.Pessimol.AutoSize = true;
            this.Pessimol.Location = new System.Drawing.Point(106, 115);
            this.Pessimol.Name = "Pessimol";
            this.Pessimol.Size = new System.Drawing.Size(50, 13);
            this.Pessimol.TabIndex = 6;
            this.Pessimol.Text = "Questão:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "1-Péssimo: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Contagem";
            // 
            // EixoText
            // 
            this.EixoText.AutoSize = true;
            this.EixoText.Location = new System.Drawing.Point(64, 65);
            this.EixoText.Name = "EixoText";
            this.EixoText.Size = new System.Drawing.Size(50, 13);
            this.EixoText.TabIndex = 3;
            this.EixoText.Text = "Questão:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Eixo:";
            // 
            // QuestaoText
            // 
            this.QuestaoText.AutoSize = true;
            this.QuestaoText.Location = new System.Drawing.Point(64, 38);
            this.QuestaoText.Name = "QuestaoText";
            this.QuestaoText.Size = new System.Drawing.Size(50, 13);
            this.QuestaoText.TabIndex = 1;
            this.QuestaoText.Text = "Questão:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Questão:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(435, 632);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(276, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sistema criado por Djunio Filho - djunio_rmf@hotmail.com";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 20;
            // 
            // count
            // 
            this.count.HeaderText = "#";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.count.Width = 25;
            // 
            // questao
            // 
            this.questao.HeaderText = "Questão";
            this.questao.Name = "questao";
            this.questao.Width = 375;
            // 
            // eixo
            // 
            this.eixo.HeaderText = "Eixo";
            this.eixo.Items.AddRange(new object[] {
            "1 - ENSINO",
            "2 - COMUNICAÇÃO E INFORMAÇÃO",
            "3 - EXTENSÃO ",
            "4 - PESQUISA",
            "5 - AMBIENTE E CONDIÇÕES DE TRABALHO ",
            "6 - ORGANIZAÇÃO E OBJETIVOS INSTITUCIONAIS"});
            this.eixo.Name = "eixo";
            this.eixo.Width = 159;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1198, 647);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.RESULTADOS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.Text = "Sistema de Inclusão de Avaliações - CPA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Questoes)).EndInit();
            this.RESULTADOS.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox ListaProvas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox NomeProva;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DomainUpDown Aplicado;
        private System.Windows.Forms.TextBox Letivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView Questoes;
        private System.Windows.Forms.GroupBox RESULTADOS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label NaoSeil;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label Otimol;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label Regularl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Boml;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Ruiml;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Pessimol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EixoText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label QuestaoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label NaoSei2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label Otimo2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label Regular2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label Bom2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label Ruim2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label Pessimo2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown Liberar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private NewProgressBar progressBar6;
        private NewProgressBar progressBar5;
        private NewProgressBar progressBar4;
        private NewProgressBar progressBar3;
        private NewProgressBar progressBar2;
        private NewProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn questao;
        private System.Windows.Forms.DataGridViewComboBoxColumn eixo;
    }
}

